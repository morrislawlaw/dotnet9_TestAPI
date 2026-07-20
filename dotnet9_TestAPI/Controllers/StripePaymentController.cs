using dotnet9_TestAPI.Models;
using dotnet9_TestAPI.Services;
using HotelBookingSystem.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripePaymentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HotelBookingSystemDbContext _context;
        private readonly IEmailService _emailService; // Add this

        public StripePaymentController(IConfiguration configuration, HotelBookingSystemDbContext context, IEmailService emailService)
        {
            _configuration = configuration;
            _context = context;
            _emailService = emailService;

            // Initialize the global Stripe configuration with your Secret Key from appsettings.json
            StripeConfiguration.ApiKey = _configuration["Stripe:SecretKey"];
        }

        // ===================================================
        // 🚀 CREATE STRIPE CHECKOUT SESSION CHECKOUT URL
        // ===================================================
        [Authorize]
        [HttpPost("CreateCheckoutSession")]
        public async Task<IActionResult> CreateCheckoutSession([FromBody] StripeCheckoutRequestDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.RoomIDs))
            {
                return BadRequest(new { message = "Invalid payment checkout request parameters." });
            }

            try
            {
                // 1. Get the current logged-in user email securely from the JWT token claims context
                var userEmail = User.FindFirst(ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(userEmail))
                {
                    return Unauthorized(new { message = "Invalid or expired session token." });
                }

                // 2. Calculate the exact number of nights for the stay configuration matrix
                DateOnly checkIn = DateOnly.Parse(dto.CheckInDate);
                DateOnly checkOut = DateOnly.Parse(dto.CheckOutDate);
                int totalNights = (checkOut.ToDateTime(TimeOnly.MinValue) - checkIn.ToDateTime(TimeOnly.MinValue)).Days;

                if (totalNights <= 0)
                {
                    return BadRequest(new { message = "Check-out date must be after check-in date." });
                }

                // 3. Look up your database rooms to calculate total pricing matching frontend choices
                var selectedRoomIdList = new List<int>();
                foreach (var idStr in dto.RoomIDs.Split(','))
                {
                    if (int.TryParse(idStr, out int id)) selectedRoomIdList.Add(id);
                }

                var dbRooms = await _context.Rooms
                    .Include(r => r.RoomType)
                    .Include(r => r.Hotel)
                    .Where(r => selectedRoomIdList.Contains(r.RoomId))
                    .ToListAsync();

                if (dbRooms.Count == 0)
                {
                    return BadRequest(new { message = "Selected rooms could not be found or mapped inside database." });
                }

                string hotelName = dbRooms[0].Hotel.HotelName;
                decimal totalAmountHkd = 0;

                foreach (var room in dbRooms)
                {
                    totalAmountHkd += room.RoomType.BasePricePerNight * totalNights;
                }

                // 4. Set up the Stripe Checkout Session Configuration Options
                var options = new SessionCreateOptions
                {
                    // Payment configurations
                    PaymentMethodTypes = new List<string> { "card" },
                    Mode = "payment",
                    CustomerEmail = userEmail, // Pre-fills their email on the Stripe form automatically!

                    // Redirect URLs when the transaction completes
                    SuccessUrl = $"https://488865.xyz/booking-confirmation?checkIn={dto.CheckInDate}&checkOut={dto.CheckOutDate}&total={totalAmountHkd}&session_id={{CHECKOUT_SESSION_ID}}",
                    CancelUrl = "https://488865.xyz/hotels",

                    // Pass custom metadata metadata parameters so our webhook can read them later to run the SP!
                    Metadata = new Dictionary<string, string>
                    {
                        { "UserEmail", userEmail },
                        { "CheckInDate", dto.CheckInDate },
                        { "CheckOutDate", dto.CheckOutDate },
                        { "RoomIDs", dto.RoomIDs }
                    },

                    // Define the visual cart item item lines that render on the checkout invoice screen
                    LineItems = new List<SessionLineItemOptions>
                    {
                        new SessionLineItemOptions
                        {
                            PriceData = new SessionLineItemPriceDataOptions
                            {
                                Currency = "hkd", // Set currency parameter strictly to HKD
                                UnitAmount = (long)(totalAmountHkd * 100), // Stripe calculates prices in CENTS (e.g. $1200 HKD = 120000 cents!)
                                ProductData = new SessionLineItemPriceDataProductDataOptions
                                {
                                    Name = $"{hotelName} Accommodation",
                                    Description = $"Stay from {dto.CheckInDate} to {dto.CheckOutDate} ({totalNights} Nights) — Rooms: {dto.RoomIDs}"
                                }
                            },
                            Quantity = 1
                        }
                    }
                };

                // 5. Fire request up to Stripe's cloud API servers to generate the URL link context
                var service = new SessionService();
                Session session = await service.CreateAsync(options);

                // 6. Return the secure Checkout Link back up to our Vue frontend application components
                return Ok(new
                {
                    success = true,
                    statusCode = 200,
                    checkoutUrl = session.Url // This is the unique Stripe web address link!
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    statusCode = 500,
                    message = "Stripe session setup compilation failure.",
                    errorDetails = ex.Message
                });
            }
        }

        // ===================================================
        // ⚓ SECURE STRIPE WEBHOOK LISTENER WITH DIAGNOSTIC LOGS
        // ===================================================
        [AllowAnonymous]
        [HttpPost("webhook")]
        public async Task<IActionResult> StripeWebhook()
        {
            Console.WriteLine("📢 [WEBHOOK] Incoming HTTP POST request detected from external network.");

            // 1. Read the raw incoming HTTP request body stream from Stripe
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            Console.WriteLine($"📢 [WEBHOOK] Raw payload received string length: {json.Length} characters.");

            try
            {
                // 2. Grab your Webhook Secret Sign key from Azure configuration settings
                var webhookSecret = _configuration["Stripe:WebhookSecret"];
                var signatureHeader = Request.Headers["Stripe-Signature"];

                Console.WriteLine($"📢 [WEBHOOK] Stored Webhook Secret starts with: {(string.IsNullOrEmpty(webhookSecret) ? "NULL!" : webhookSecret.Substring(0, Math.Min(8, webhookSecret.Length)))}");
                Console.WriteLine($"📢 [WEBHOOK] Incoming Stripe-Signature Header present: {!string.IsNullOrEmpty(signatureHeader)}");

                // 3. Verify that this request ACTUALLY came from Stripe using the digital signature header
                var stripeEvent = EventUtility.ConstructEvent(
                    json,
                    signatureHeader,
                    webhookSecret,
                    throwOnApiVersionMismatch: false
                );

                Console.WriteLine($"✅ [WEBHOOK] Event signature verified successfully! Event Type: '{stripeEvent.Type}'");

                // 4. Listen specifically for the "Checkout Session Completed" event notice
                if (stripeEvent.Type == EventTypes.CheckoutSessionCompleted)
                {
                    var session = stripeEvent.Data.Object as Stripe.Checkout.Session;

                    if (session != null && session.Metadata != null)
                    {
                        Console.WriteLine($"📢 [WEBHOOK] Processing session metadata for checkout user email: '{session.CustomerEmail}'");

                        // 5. Extract the transit metadata variables we stamped during checkout generation
                        string userEmail = session.Metadata["UserEmail"];
                        string checkInStr = session.Metadata["CheckInDate"];
                        string checkOutStr = session.Metadata["CheckOutDate"];
                        string roomIDs = session.Metadata["RoomIDs"];

                        Console.WriteLine($"📢 [WEBHOOK] Extracted Metadata parameters -> Email: {userEmail}, Stay: {checkInStr} to {checkOutStr}, Rooms: {roomIDs}");

                        // 6. Resolve the real CustomerID from your database table via their email address
                        var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == userEmail);
                        if (customer == null)
                        {
                            Console.WriteLine($"❌ [WEBHOOK ERROR] No customer profile found inside database for email '{userEmail}'");
                            return BadRequest();
                        }
                        Console.WriteLine($"📢 [WEBHOOK] Found database Customer record ID: #{customer.CustomerId}");

                        // 7. Parse dates cleanly to pass to your Repository Service tier
                        DateOnly checkIn = DateOnly.Parse(checkInStr);
                        DateOnly checkOut = DateOnly.Parse(checkOutStr);

                        // 8. Dynamically locate your BookingService instance from the HTTP Context scope
                        var bookingService = HttpContext.RequestServices.GetRequiredService<BookingService>();

                        // 9. Call your stored procedure to save it to SQL!
                        Console.WriteLine("📢 [WEBHOOK] Invoking database service execution layer...");
                        var bookingResult = await bookingService.CreateBookingAsync(
                            customer.CustomerId,
                            checkIn,
                            checkOut,
                            roomIDs,
                            paymentSuccess: true
                        );

                        if (bookingResult != null)
                        {
                            Console.WriteLine($"✅ [WEBHOOK] SQL Transaction complete! Booking record generated ID: #{bookingResult.NewBookingID}");

                            try
                            {
                                // 🚀 TRIGGER THE AUTOMATED EMAIL RECEIPTS PIPELINE
                                //Console.WriteLine("📢 [WEBHOOK] Resolving EmailService dependency provider instantiation...");
                                //var emailService = HttpContext.RequestServices.GetRequiredService<EmailService>();

                                string customerName = $"{customer.FirstName} {customer.LastName}";
                                string amountString = bookingResult.TotalAmount.ToString("N0");

                                Console.WriteLine($"📢 [WEBHOOK] Dispatched payload args out to Brevo engine -> To: {userEmail}, Name: {customerName}, Paid: HKD {amountString}");

                                bool emailSent = await _emailService.SendBookingConfirmationEmailAsync(
                                    recipientEmail: userEmail,
                                    recipientName: customerName,
                                    bookingId: bookingResult.NewBookingID,
                                    checkIn: checkInStr,
                                    checkOut: checkOutStr,
                                    roomDetails: roomIDs,
                                    totalPaidHkd: amountString
                                );

                                if (emailSent)
                                {
                                    Console.WriteLine($"📧 [WEBHOOK SUCCESS] Brevo API processing completed successfully. Receipt sent to: {userEmail}");
                                }
                                else
                                {
                                    Console.WriteLine("❌ [WEBHOOK ERROR] Brevo API endpoint rejected transmission request pack.");
                                }
                            }
                            catch (Exception mailEx)
                            {
                                Console.WriteLine($"❌ [WEBHOOK EXCEPTION] Failed while processing the email pipeline task loop: {mailEx.Message}");
                                Console.WriteLine($"❌ [WEBHOOK STACK TRACE] {mailEx.StackTrace}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("❌ [WEBHOOK ERROR] Database Service layer returned an empty execution result reference.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"📢 [WEBHOOK INFO] Ignored unhandled background notice event signature: '{stripeEvent.Type}'");
                }

                return Ok();
            }
            catch (StripeException ex)
            {
                Console.WriteLine($"❌ [WEBHOOK STRIPE CRASH] Cryptographic verification failed! Forged request or invalid config keys: {ex.Message}");
                return BadRequest();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ [WEBHOOK SYSTEM CRASH] Global runtime failure: {ex.Message}");
                Console.WriteLine($"❌ [WEBHOOK SYSTEM STACK TRACE] {ex.StackTrace}");
                return StatusCode(500);
            }
        }

        // ===================================================
        // STRIPE TRANSIT DATA TRANSFER OBJECT (DTO)
        // ===================================================
        public class StripeCheckoutRequestDto
        {
            public string CheckInDate { get; set; } = string.Empty;
            public string CheckOutDate { get; set; } = string.Empty;
            public string RoomIDs { get; set; } = string.Empty;
        }
    }
}

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace dotnet9_TestAPI.Services
{
    // The contract that allows us to substitute a fake service during testing
    public interface IEmailService
    {
        Task<bool> SendBookingConfirmationEmailAsync(string recipientEmail, string recipientName, int bookingId, string checkIn, string checkOut, string roomDetails, string totalPaidHkd);
    }

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public EmailService(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        //public async Task<bool> SendBookingConfirmationEmailAsync(string recipientEmail, string recipientName, int bookingId, string checkIn, string checkOut, string roomDetails, string totalPaidHkd)
        //{
        //    var apiKey = _configuration["Brevo:ApiKey"];
        //    var fromEmail = _configuration["Brevo:FromEmail"];
        //    var fromName = _configuration["Brevo:FromName"];

        //    if (string.IsNullOrEmpty(apiKey))
        //    {
        //        Console.WriteLine("❌ Email Configuration Error: Brevo API Key is missing.");
        //        return false;
        //    }

        //    // Define the JSON payload layout expected by Brevo's v3 API
        //    var emailPayload = new
        //    {
        //        sender = new { name = fromName, email = fromEmail },
        //        to = new[] { new { email = recipientEmail, name = recipientName } },
        //        subject = "Your HotelBook Reservation is Confirmed! 🎉",
        //        htmlContent = $@"
        //            <div style='font-family: sans-serif; max-width: 600px; margin: 0 auto; border: 1px solid #e2e8f0; border-radius: 24px; overflow: hidden; box-shadow: 0 4px 6px -1px rgba(0,0,0,0.05);'>
        //                <div style='background: linear-gradient(135deg, #2563eb, #4f46e5); padding: 32px; text-align: center; color: white;'>
        //                    <h1 style='margin: 0; font-size: 28px; font-weight: 800;'>Booking Confirmed!</h1>
        //                    <p style='margin: 8px 0 0 0; opacity: 0.9;'>Thank you for choosing HotelBook</p>
        //                </div>
        //                <div style='padding: 32px; background-color: #ffffff;'>
        //                    <h3 style='margin-top: 0; color: #0f172a; font-size: 20px;'>Hi {recipientName},</h3>
        //                    <p style='color: #475569; line-height: 1.6;'>Your card payment cleared successfully via Stripe. Your room inventory is locked down and your itinerary details are ready below:</p>

        //                    <div style='background-color: #f8fafc; border-radius: 16px; padding: 24px; margin: 24px 0;'>
        //                        <table style='width: 100%; border-collapse: collapse; font-size: 15px;'>
        //                            <tr><td style='padding: 6px 0; color: #64748b;'><strong>Booking Reference:</strong></td><td style='text-align: right; color: #0f172a; font-family: monospace; font-weight: bold;'>#{bookingId}</td></tr>
        //                            <tr><td style='padding: 6px 0; color: #64748b;'><strong>Check-In Date:</strong></td><td style='text-align: right; color: #0f172a;'>{checkIn}</td></tr>
        //                            <tr><td style='padding: 6px 0; color: #64748b;'><strong>Check-Out Date:</strong></td><td style='text-align: right; color: #0f172a;'>{checkOut}</td></tr>
        //                            <tr><td style='padding: 6px 0; color: #64748b;'><strong>Assigned Rooms:</strong></td><td style='text-align: right; color: #0f172a;'>{roomDetails}</td></tr>
        //                            <tr style='border-top: 1px solid #e2e8f0;'><td style='padding: 12px 0 0 0; color: #0f172a; font-weight: bold; font-size: 18px;'>Total Paid:</td><td style='padding: 12px 0 0 0; text-align: right; color: #10b981; font-weight: 900; font-size: 20px;'>HKD {totalPaidHkd}</td></tr>
        //                        </table>
        //                    </div>

        //                    <p style='color: #475569; font-size: 14px;'>You can view, update, or cancel your itinerary rules anytime by logging into your account dashboard profile under the 'My Bookings' tab.</p>
        //                    <hr style='border: 0; border-top: 1px solid #f1f5f9; margin: 32px 0;' />
        //                    <p style='text-align: center; color: #94a3b8; font-size: 12px; margin: 0;'>&copy; 2026 HotelBook Inc. Hong Kong • Taipei • Singapore</p>
        //                </div>
        //            </div>"
        //    };

        //    var request = new HttpRequestMessage(HttpMethod.Post, "https://api.brevo.com/v3/smtp/email");
        //    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    request.Headers.Add("api-key", apiKey);
        //    request.Content = new StringContent(JsonSerializer.Serialize(emailPayload), Encoding.UTF8, "application/json");

        //    var response = await _httpClient.SendAsync(request);
        //    return response.IsSuccessStatusCode;
        //}

        public async Task<bool> SendBookingConfirmationEmailAsync(string recipientEmail, string recipientName, int bookingId, string checkIn, string checkOut, string roomDetails, string totalPaidHkd)
        {
            // 🔍 Read exactly what .NET configuration resolves at runtime
            var apiKey = _configuration["Brevo:ApiKey"];
            var fromEmail = _configuration["Brevo:FromEmail"];
            var fromName = _configuration["Brevo:FromName"];

            // 📢 DIAGNOSTIC LOG BLOCKS: Let's see what is actually inside these variables
            Console.WriteLine("🔍 [BREVO CONFIG DIAGNOSTIC] Printing runtime keys resolved by Azure:");
            Console.WriteLine($"➔ FromEmail: '{(string.IsNullOrEmpty(fromEmail) ? "MISSING/NULL" : fromEmail)}'");
            Console.WriteLine($"➔ FromName: '{(string.IsNullOrEmpty(fromName) ? "MISSING/NULL" : fromName)}'");

            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("❌ [BREVO CONFIG CRITICAL] apiKey string variable is COMPLETELY NULL OR EMPTY inside the container context.");
            }
            else
            {
                // Safely show the structural shell bounds of the key string to test injection mechanics
                string maskedKey = apiKey.Length > 15
                    ? $"{apiKey.Substring(0, 12)}...{apiKey.Substring(apiKey.Length - 4)}"
                    : "STRING_TOO_SHORT_TO_MASK";
                Console.WriteLine($"➔ ApiKey Masked String Layout: '{maskedKey}' (Total length: {apiKey.Length} chars)");
            }

            if (string.IsNullOrEmpty(apiKey))
            {
                return false;
            }

            // Define the JSON payload layout expected by Brevo's v3 API
            var emailPayload = new
            {
                sender = new { name = fromName, email = fromEmail },
                to = new[] { new { email = recipientEmail, name = recipientName } },
                subject = "Your HotelBook Reservation is Confirmed! 🎉",
                htmlContent = $@"
                    <div style='font-family: sans-serif; max-width: 600px; margin: 0 auto; border: 1px solid #e2e8f0; border-radius: 24px; overflow: hidden; box-shadow: 0 4px 6px -1px rgba(0,0,0,0.05);'>
                        <div style='background: linear-gradient(135deg, #2563eb, #4f46e5); padding: 32px; text-align: center; color: white;'>
                            <h1 style='margin: 0; font-size: 28px; font-weight: 800;'>Booking Confirmed!</h1>
                            <p style='margin: 8px 0 0 0; opacity: 0.9;'>Thank you for choosing HotelBook</p>
                        </div>
                        <div style='padding: 32px; background-color: #ffffff;'>
                            <h3 style='margin-top: 0; color: #0f172a; font-size: 20px;'>Hi {recipientName},</h3>
                            <p style='color: #475569; line-height: 1.6;'>Your card payment cleared successfully via Stripe. Your room inventory is locked down and your itinerary details are ready below:</p>
                            
                            <div style='background-color: #f8fafc; border-radius: 16px; padding: 24px; margin: 24px 0;'>
                                <table style='width: 100%; border-collapse: collapse; font-size: 15px;'>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Booking Reference:</strong></td><td style='text-align: right; color: #0f172a; font-family: monospace; font-weight: bold;'>#{bookingId}</td></tr>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Check-In Date:</strong></td><td style='text-align: right; color: #0f172a;'>{checkIn}</td></tr>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Check-Out Date:</strong></td><td style='text-align: right; color: #0f172a;'>{checkOut}</td></tr>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Assigned Rooms:</strong></td><td style='text-align: right; color: #0f172a;'>{roomDetails}</td></tr>
                                    <tr style='border-top: 1px solid #e2e8f0;'><td style='padding: 12px 0 0 0; color: #0f172a; font-weight: bold; font-size: 18px;'>Total Paid:</td><td style='padding: 12px 0 0 0; text-align: right; color: #10b981; font-weight: 900; font-size: 20px;'>HKD {totalPaidHkd}</td></tr>
                                </table>
                            </div>

                            <p style='color: #475569; font-size: 14px;'>You can view, update, or cancel your itinerary rules anytime by logging into your account dashboard profile under the 'My Bookings' tab.</p>
                            <hr style='border: 0; border-top: 1px solid #f1f5f9; margin: 32px 0;' />
                            <p style='text-align: center; color: #94a3b8; font-size: 12px; margin: 0;'>&copy; 2026 HotelBook Inc. Hong Kong • Taipei • Singapore</p>
                        </div>
                    </div>"
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.brevo.com/v3/smtp/email");
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("api-key", apiKey);

            var jsonBody = JsonSerializer.Serialize(emailPayload);
            request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            // 📢 DIAGNOSTIC LOG BLOCKS: Print outbound dispatch payload metrics
            Console.WriteLine("📢 [BREVO DISPATCH] Contacting api.brevo.com socket endpoint...");

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("🟢 [BREVO SUCCESS] Brevo accepted request packet.");
                return true;
            }

            // 📢 DIAGNOSTIC LOG BLOCKS: Capture the exact raw reason Brevo rejected the transmission
            var errorContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"❌ [BREVO API ERROR] Server returned HTTP Status Code: {(int)response.StatusCode} {response.StatusCode}");
            Console.WriteLine($"❌ [BREVO REJECTION RAW BODY] Response payload from Brevo: {errorContent}");

            return false;
        }

    }
}
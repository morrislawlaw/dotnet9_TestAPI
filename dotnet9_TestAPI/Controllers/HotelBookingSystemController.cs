using Anderson_Road.Models;
using dotnet9_TestAPI.Models;
using dotnet9_TestAPI.Services;
using HotelBookingSystem.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingSystemController : ControllerBase
    {
        private readonly BookingService _bookingService;
        private readonly HotelBookingSystemDbContext _context; // For direct EF Core table access

        public HotelBookingSystemController(HotelBookingSystemDbContext context, BookingService bookingService)
        {
            _context = context;
            _bookingService = bookingService;
        }

        // Post: api/HotelBookingSystem/CreateBooking
        [Authorize]
        [HttpPost("CreateBooking")]
        public async Task<ActionResult<BookingCreationResultDto>> CreateBooking([FromBody] CreateBookingInputDto dto)   // ← Add ? here too
        {
            if (dto == null || string.IsNullOrEmpty(dto.RoomIDs))
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            if (dto.CheckInDate == default || dto.CheckOutDate == default)
                return BadRequest(ApiResponse<object>.Error(-1, "Check-in and Check-out dates are required."));

            if (dto.CheckOutDate <= dto.CheckInDate)
                return BadRequest(ApiResponse<object>.Error(-1, "Check-out date must be after check-in date."));

            //if (dto.CustomerID <= 0)
            //    return BadRequest(ApiResponse<object>.Error(-1, "Valid CustomerID is required."));

            try
            {
                // 1. Extract verified Email from token claims payload securely
                var userEmail = User.FindFirst(System.Security.Claims.ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(userEmail))
                {
                    return Unauthorized(new { message = "Expired session token identifier context." });
                }

                // 2. Fetch the corresponding CustomerID integer from your Customers profile table[cite: 27]
                var customer = await _context.Customers.FirstOrDefaultAsync(c => c.Email == userEmail);
                if (customer == null)
                {
                    return BadRequest(new { message = "No matching customer profile found for this account." });
                }

                // 4. Delegate stored procedure execution payload directly to your clean Service tier!
                var bookingResult = await _bookingService.CreateBookingAsync(
                    customer.CustomerId,
                    dto.CheckInDate,
                    dto.CheckOutDate,
                    dto.RoomIDs,
                    true
                    //dto.PaymentSuccess
                );

                if (bookingResult == null)
                {
                    return StatusCode(500, new { message = "Failed to compile reservation records from the database instance." });
                }

                return Ok(new
                {
                    success = true,
                    statusCode = 200,
                    message = "Booking created successfully.",
                    data = bookingResult
                });              
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    statusCode = 500,
                    message = "Transaction parsing failure.",
                    errorDetails = ex.Message
                });
            }
        }

        // Post: api/HotelBookingSystem/UpdateBooking
        [Authorize]
        [HttpPost("UpdateBooking")]
        public async Task<ActionResult<BookingDetailsDto>> UpdateBooking([FromBody] UpdateBookingInputDto dto)   // ← Add ? here too
        {
            if (dto == null)
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            if (dto.NewCheckInDate == default || dto.NewCheckOutDate == default)
                return BadRequest(ApiResponse<object>.Error(-1, "Check-in and Check-out dates are required."));

            if (dto.NewCheckOutDate <= dto.NewCheckInDate)
                return BadRequest(ApiResponse<object>.Error(-1, "Check-out date must be after check-in date."));


            bool isValidBookingID = await _bookingService.BookingIDExists(dto.BookingID);
            if (!isValidBookingID)
                return BadRequest(ApiResponse<object>.Error(-1, "Valid BookingID is required."));

            try
            {
                // Step A: Extract verified identity email context from token
                var userEmail = User.FindFirst(ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(userEmail))
                {
                    return Unauthorized(ApiResponse<object>.Error(-1, "Invalid or expired session token."));
                }

                // Step B: Fetch the target booking header, including customer profile context
                var booking = await _context.Bookings
                    .Include(b => b.Customer)
                    .FirstOrDefaultAsync(b => b.BookingId == dto.BookingID);

                if (booking == null)
                {
                    
                    return NotFound(ApiResponse<object>.Error(-1, "Booking record not found."));
                }

                // Step C: Security Ownership Validation Check
                if (booking.Customer?.Email != userEmail)
                {
                    
                    return BadRequest(ApiResponse<object>.Error(-1, "Access denied. You do not own this booking record."));
                }

                // Step E: Pass sanitized values to the service tier execution loop
                var data = await _bookingService.UpdateBookingAsync(
                    dto.BookingID,
                    dto.NewCheckInDate,
                    dto.NewCheckOutDate,
                    dto.NewRoomIDs
                    );

                return Ok(ApiResponse<BookingDetailsDto>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "BookingUpdateResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CancelBooking
        [Authorize]
        [HttpPost("CancelBooking")]
        public async Task<ActionResult<OperationResultDto>> CancelBooking([FromBody] CancelBookingInputDto dto)   // ← Add ? here too
        {
            if (dto == null)
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            bool isValidBookingID = await _bookingService.BookingIDExists(dto.BookingID);
            if (!isValidBookingID)
                return BadRequest(ApiResponse<object>.Error(-1, "Valid BookingID is required."));

            try
            {
                var userEmail = User.FindFirst(ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(userEmail))
                {                 
                    return Unauthorized(ApiResponse<object>.Error(-1, "Invalid session token."));
                }

                var booking = await _context.Bookings
                    .Include(b => b.Customer)
                    .FirstOrDefaultAsync(b => b.BookingId == dto.BookingID);

                if (booking == null)
                {
                    return NotFound(ApiResponse<object>.Error(-1, "Booking not found."));
                }

                // Prevent cross-user cancellation exploits
                if (booking.Customer?.Email != userEmail)
                {             
                    return BadRequest(ApiResponse<object>.Error(-1, "Access denied. You are not authorized to cancel this booking."));
                }

                var data = await _bookingService.CancelBookingAsync(
                    dto.BookingID,
                    dto.Reason
                    );

                if(data.Success)
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
                else
                    return Ok(ApiResponse<object>.Error(-1, "Cancel Booking Failed"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "BookingCreationResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CheckInBooking
        [Authorize]
        [HttpPost("CheckInBooking")]
        public async Task<ActionResult<OperationResultDto>> CheckInBooking([FromBody] CheckInOutInputDto dto)   // ← Add ? here too
        {
            if (dto == null)
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            bool isValidBookingID = await _bookingService.BookingIDExists(dto.BookingID);
            if (!isValidBookingID)
                return BadRequest(ApiResponse<object>.Error(-1, "Valid BookingID is required."));

            try
            {
                var data = await _bookingService.CheckInBookingAsync(
                    dto.BookingID
                    );

                if (data.Success)
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
                else
                    return Ok(ApiResponse<object>.Error(-1, "Check In Failed"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "CheckInBookingResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CheckOutBooking
        [Authorize]
        [HttpPost("CheckOutBooking")]
        public async Task<ActionResult<OperationResultDto>> CheckOutBooking([FromBody] CheckInOutInputDto dto)   // ← Add ? here too
        {
            if (dto == null)
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            bool isValidBookingID = await _bookingService.BookingIDExists(dto.BookingID);
            if (!isValidBookingID)
                return BadRequest(ApiResponse<object>.Error(-1, "Valid BookingID is required."));

            try
            {
                var data = await _bookingService.CheckOutBookingAsync(
                    dto.BookingID
                    );

                if (data.Success)
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
                else
                    return Ok(ApiResponse<object>.Error(-1, "Check out Failed"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "CheckOutBookingResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CheckRoomAvailability
        [AllowAnonymous]
        [HttpPost("CheckRoomAvailability")]
        public async Task<ActionResult<List<RoomAvailabilityDto>>> CheckRoomAvailability([FromBody] RoomAvailabilityInputDto? dto)   // ← Add ? here too
        {
            if (dto == null)
            {
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));
            }

            if (dto.CheckInDate == default || dto.CheckOutDate == default)
            {
                return BadRequest(ApiResponse<object>.Error(-1, "Check-in and Check-out dates are required."));
            }

            if (dto.CheckOutDate <= dto.CheckInDate)
            {
                return BadRequest(ApiResponse<object>.Error(-1, "Check-out date must be after check-in date."));
            }

            try
            {
                var data = await _bookingService.CheckRoomAvailabilityAsync(
                    dto.HotelID,
                    dto.CheckInDate,
                    dto.CheckOutDate,
                    dto.RoomTypeID);

                return Ok(ApiResponse<List<RoomAvailabilityDto>>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "Check Room Availability Error: " + ex.Message));
            }
        }

        [AllowAnonymous]
        [HttpPost("GetAvailableHotelsList")]
        public async Task<IActionResult> GetAvailableHotelsList([FromBody] HotelSearchInputDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.CheckInDate) || string.IsNullOrEmpty(dto.CheckOutDate))
            {
                return BadRequest(new { message = "Check-in and check-out dates are required query parameters." });
            }

            try
            {
                DateOnly checkIn = DateOnly.Parse(dto.CheckInDate);
                DateOnly checkOut = DateOnly.Parse(dto.CheckOutDate);

                var data = await _bookingService.GetAvailableHotelsListAsync(
                    checkIn,
                    checkOut,
                    dto.Guests);

                return Ok(ApiResponse<List<AvailableHotelQueryResultDto>>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Hotel aggregation routines failed.", errorDetails = ex.Message });
            }
        }

        // Post: api/HotelBookingSystem/GetBookingDetail
        [Authorize]
        [HttpPost("GetBookingDetail")]
        public async Task<ActionResult<BookingDetailsDto>> GetBookingDetail([FromBody] CheckInOutInputDto dto)   // ← Add ? here too
        {
            if (dto == null)
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            bool isValidBookingID = await _bookingService.BookingIDExists(dto.BookingID);
            if (!isValidBookingID)
                return BadRequest(ApiResponse<object>.Error(-1, "Valid BookingID is required."));

            try
            {
                var userEmail = User.FindFirst(ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(userEmail))
                {
                    return Unauthorized(ApiResponse<object>.Error(-1, "Invalid session token."));
                }

                var booking = await _context.Bookings
                    .Include(b => b.Customer)
                    .FirstOrDefaultAsync(b => b.BookingId == dto.BookingID);

                if (booking == null)
                {
                    return NotFound(ApiResponse<object>.Error(-1, "Booking record could not be found."));
                }

                // Ensure users can only look up details for their own bookings
                if (booking.Customer?.Email != userEmail)
                {
                    return BadRequest(ApiResponse<object>.Error(-1, "Access denied. You do not have permission to view this booking file."));
                }

                var data = await _bookingService.GetBookingDetailsAsync(
                    dto.BookingID
                    );

                return Ok(ApiResponse<BookingDetailsDto>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "BookingUpdateResult Error: " + ex.Message));
            }
        }

        [Authorize]
        [HttpPost("GetBookingReport")]   // You can change to [HttpGet] if you prefer
        public async Task<ActionResult<List<BookingReportDto>>> GetBookingReport([FromBody] BookingReportFilterDto? filter = null)
        {
            if (filter == null)
                filter = new BookingReportFilterDto();   // Use all records by default

            try
            {
                var userEmail = User.FindFirst(ClaimTypes.Name)?.Value;
                if (string.IsNullOrEmpty(userEmail))
                {
                    return Unauthorized(ApiResponse<object>.Error(-1, "Invalid session token."));
                }

                var data = await _bookingService.GetBookingReportListAsync(
                    statusFilter: filter.Status,
                    fromDate: filter.FromDate,
                    toDate: filter.ToDate
                );

                if (data == null || data.Count == 0)
                    return Ok(ApiResponse<List<BookingReportDto>>.Success(new List<BookingReportDto>(),
                        "No booking records found."));

                // Filter the view down specifically to the logged-in user email
                var userSpecificReport = data.Where(b => b.Email == userEmail).ToList();

                return Ok(ApiResponse<List<BookingReportDto>>.Success(userSpecificReport,
                    $"Retrieved {data.Count} booking record(s)."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1,
                    "BookingReport Error: " + ex.Message));
            }
        }
    }
}

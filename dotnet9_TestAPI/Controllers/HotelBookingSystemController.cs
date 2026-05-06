using Anderson_Road.Models;
using dotnet9_TestAPI.Models;
using dotnet9_TestAPI.Services;
using HotelBookingSystem.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingSystemController : ControllerBase
    {
        private readonly BookingService _bookingService;

        public HotelBookingSystemController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        // Post: api/HotelBookingSystem/CreateBooking
        [HttpPost("CreateBooking")]
        public async Task<ActionResult<BookingCreationResultDto>> CreateBooking([FromBody] CreateBookingInputDto dto)   // ← Add ? here too
        {
            if (dto == null)
                return BadRequest(ApiResponse<object>.Error(-1, "Request body is required."));

            if (dto.CheckInDate == default || dto.CheckOutDate == default)
                return BadRequest(ApiResponse<object>.Error(-1, "Check-in and Check-out dates are required."));

            if (dto.CheckOutDate <= dto.CheckInDate)
                return BadRequest(ApiResponse<object>.Error(-1, "Check-out date must be after check-in date."));

            if (dto.CustomerID <= 0)
                return BadRequest(ApiResponse<object>.Error(-1, "Valid CustomerID is required."));

            try
            {
                var data = await _bookingService.CreateBookingAsync(
                    dto.CustomerID,
                    dto.CheckInDate,
                    dto.CheckOutDate,
                    dto.RoomIDs,
                    true);

                return Ok(ApiResponse<BookingCreationResultDto>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "BookingCreationResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/UpdateBooking
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
                var data = await _bookingService.CancelBookingAsync(
                    dto.BookingID,
                    dto.Reason
                    );

                if(data.Success)
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
                else
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "BookingCreationResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CheckInBooking
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
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "CheckInBookingResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CheckOutBooking
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
                    return Ok(ApiResponse<OperationResultDto>.Success(data));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(-1, "CheckOutBookingResult Error: " + ex.Message));
            }
        }

        // Post: api/HotelBookingSystem/CheckRoomAvailability
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

        // Post: api/HotelBookingSystem/GetBookingDetail
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

        [HttpPost("GetBookingReport")]   // You can change to [HttpGet] if you prefer
        public async Task<ActionResult<List<BookingReportDto>>> GetBookingReport([FromBody] BookingReportFilterDto? filter = null)
        {
            if (filter == null)
                filter = new BookingReportFilterDto();   // Use all records by default

            try
            {
                var data = await _bookingService.GetBookingReportListAsync(
                    statusFilter: filter.Status,
                    fromDate: filter.FromDate,
                    toDate: filter.ToDate
                );

                if (data == null || data.Count == 0)
                    return Ok(ApiResponse<List<BookingReportDto>>.Success(new List<BookingReportDto>(),
                        "No booking records found."));

                return Ok(ApiResponse<List<BookingReportDto>>.Success(data,
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

namespace dotnet9_TestAPI.Models
{
    public class HotelSearchInputDto
    {
        public string CheckInDate { get; set; } = string.Empty;
        public string CheckOutDate { get; set; } = string.Empty;
        public int Guests { get; set; } = 2; // Default baseline value
    }

    public class AvailableHotelQueryResultDto
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public byte? StarRating { get; set; }
        public string? Address { get; set; }
        public decimal StartingPricePerNight { get; set; }
    }

    // Dtos/RoomAvailabilityDto.cs
    public class RoomAvailabilityDto
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; } = string.Empty;
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
        public decimal BasePricePerNight { get; set; }
        public byte? MaxOccupancy { get; set; }
    }

    // Dtos/BookingCreationResultDto.cs
    public class BookingCreationResultDto
    {
        public int NewBookingID { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    // Dtos/BookingCreationResultDto.cs
    public class BookingUpdateResultDto
    {
        public int NewBookingID { get; set; }
        public decimal TotalAmount { get; set; }
        public string NewStatus { get; set; } = string.Empty;
    }
    public class OperationResultDto
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    

    // Dtos/BookingDetailsDto.cs
    public class BookingDetailsDto
    {
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }

        public string HotelName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public byte? StarRating { get; set; }

        public string RoomsBooked { get; set; } = string.Empty;
        public int NumberOfRooms { get; set; }
        public int NumberOfNights { get; set; }
    }

    // Dtos/BookingReportDto.cs
    public class BookingReportDto
    {
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public int NumberOfNights { get; set; }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }

        public string Status { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public string TotalAmount_HKD { get; set; } = string.Empty;

        public string HotelName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public byte? HotelStars { get; set; }

        public string RoomsBooked { get; set; } = string.Empty;
        public int NumberOfRooms { get; set; }
        public string BookingCategory { get; set; } = string.Empty;
    }

    // Input DTOs
    public class RoomAvailabilityInputDto
    {
        public int? HotelID { get; set; }     // Must be nullable with ?
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public int? RoomTypeID { get; set; }   // Also nullable
    }

    public class CreateBookingInputDto
    {
        //public int CustomerID { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public string RoomIDs { get; set; } = string.Empty;   // comma separated e.g. "1,5,12"
        public bool PaymentSuccess { get; set; } = true;
    }
    public class UpdateBookingInputDto
    {
        public int BookingID { get; set; }
        public DateOnly NewCheckInDate { get; set; }
        public DateOnly NewCheckOutDate { get; set; }
        public string NewRoomIDs { get; set; } = string.Empty;   // comma separated e.g. "1,5,12"
    }
    public class CancelBookingInputDto
    {
        public int BookingID { get; set; }
        public string? Reason { get; set; } = string.Empty;
    }

    public class CheckInOutInputDto
    {
        public int BookingID { get; set; }
    }

    // Filter DTO (Optional but recommended)
    public class BookingReportFilterDto
    {
        public string? Status { get; set; }      // e.g. "Confirmed", "Cancelled"
        public DateOnly? FromDate { get; set; }
        public DateOnly? ToDate { get; set; }
    }
}

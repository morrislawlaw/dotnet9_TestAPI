namespace dotnet9_TestAPI.Models
{
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
}

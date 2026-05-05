namespace dotnet9_TestAPI.Models
{
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
        public string BookingDate_Friendly { get; set; } = string.Empty;
        public string CheckIn_Friendly { get; set; } = string.Empty;
        public string CheckOut_Friendly { get; set; } = string.Empty;
    }
}

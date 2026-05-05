namespace dotnet9_TestAPI.Models
{
    public class RoomAvailabilityDto
    {
        public string HotelName { get; set; } = string.Empty;
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
        public decimal BasePricePerNight { get; set; }
        public int MaxOccupancy { get; set; }
    }
}

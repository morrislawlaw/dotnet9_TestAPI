namespace dotnet9_TestAPI.Models
{
    public class BookingCreationResultDto
    {

        public int NewBookingID { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;

    }
}

namespace dotnet9_TestAPI.Entities.HotelBookingSystem
{
    public class UserLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign Key
        public string LoginProvider { get; set; } = string.Empty; // e.g., "Google", "Local"
        public string ProviderKey { get; set; } = string.Empty; // The external unique ID or email

        // Navigation property
        public virtual User? User { get; set; }
    }
}

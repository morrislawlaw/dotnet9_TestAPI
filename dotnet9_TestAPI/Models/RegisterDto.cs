namespace dotnet9_TestAPI.Models
{
    // Explicit DTO transport data frames
    public class RegisterDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}

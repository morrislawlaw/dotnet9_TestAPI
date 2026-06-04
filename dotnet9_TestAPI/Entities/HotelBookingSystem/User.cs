using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.HotelBookingSystem
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? PasswordHash { get; set; } // Nullable for social sign-ups
        public string Status { get; set; } = "Active"; // Active, Suspended
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }

        // Navigation property for linked identities
        public virtual ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();

    }
}

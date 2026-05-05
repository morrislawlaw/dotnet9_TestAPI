using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Entities;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string HotelName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public byte? StarRating { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}

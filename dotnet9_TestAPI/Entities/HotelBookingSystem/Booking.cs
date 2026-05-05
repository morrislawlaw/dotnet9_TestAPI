using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Entities;

public partial class Booking
{
    public int BookingId { get; set; }

    public int CustomerId { get; set; }

    public DateTime BookingDate { get; set; }

    public DateOnly CheckInDate { get; set; }

    public DateOnly CheckOutDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<BookingRoom> BookingRooms { get; set; } = new List<BookingRoom>();

    public virtual Customer Customer { get; set; } = null!;
}

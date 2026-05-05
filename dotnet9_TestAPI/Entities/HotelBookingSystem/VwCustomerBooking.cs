using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Entities;

public partial class VwCustomerBooking
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public int BookingId { get; set; }

    public DateOnly CheckInDate { get; set; }

    public DateOnly CheckOutDate { get; set; }

    public string HotelName { get; set; } = null!;
}

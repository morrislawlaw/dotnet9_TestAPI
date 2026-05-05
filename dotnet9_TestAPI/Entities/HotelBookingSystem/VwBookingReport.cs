using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Entities;

public partial class VwBookingReport
{
    public int BookingId { get; set; }

    public DateTime BookingDate { get; set; }

    public DateOnly CheckInDate { get; set; }

    public DateOnly CheckOutDate { get; set; }

    public int? NumberOfNights { get; set; }

    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string Status { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public string? TotalAmountHkd { get; set; }

    public string HotelName { get; set; } = null!;

    public string City { get; set; } = null!;

    public byte? HotelStars { get; set; }

    public string? RoomsBooked { get; set; }

    public int? NumberOfRooms { get; set; }

    public string BookingCategory { get; set; } = null!;

    public string? BookingDateFriendly { get; set; }

    public string? CheckInFriendly { get; set; }

    public string? CheckOutFriendly { get; set; }
}

using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class BookingDetail
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? RoomId { get; set; }

    public string? BookingId { get; set; }

    public DateOnly? EffectDay { get; set; }

    public string? TimeSlot { get; set; }

    public TimeOnly? From { get; set; }

    public TimeOnly? To { get; set; }

    public bool? Enable { get; set; }

    public DateTime? AddDt { get; set; }
}

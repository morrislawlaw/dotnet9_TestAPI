using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class BookingIndvSetting
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? RoomId { get; set; }

    public DateOnly? EffectDay { get; set; }

    public string? BookingPeriod { get; set; }

    public bool? Enable { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public DateTime? AddDt { get; set; }

    public TimeOnly? From { get; set; }

    public TimeOnly? To { get; set; }
}

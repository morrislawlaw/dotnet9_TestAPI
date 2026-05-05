using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class BookingIndvSetting1
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? RoomId { get; set; }

    public DateOnly? EffectDay { get; set; }

    public string? BookingPeriod { get; set; }

    public DateTime? AddDt { get; set; }

    public bool? ManualSet { get; set; }
}

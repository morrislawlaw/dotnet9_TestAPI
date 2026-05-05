using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class BookingGlobalSetting
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public DateOnly? EffectDay { get; set; }

    public string? BookingPeriod { get; set; }

    public DateTime? AddDt { get; set; }

    public TimeOnly? From { get; set; }

    public TimeOnly? To { get; set; }
}

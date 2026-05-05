using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class TblTmpSendVisitCommand
{
    public long Id { get; set; }

    public string? CardId { get; set; }

    public DateTime? BookingFrom { get; set; }

    public DateTime? BookingTo { get; set; }

    public short? AllowedTimes { get; set; }

    public bool? IsUpdate { get; set; }

    public string? DefaultFoor { get; set; }

    public string? TenantId { get; set; }

    public long? GuidId { get; set; }

    public DateTime AddDt { get; set; }

    public short? PassageType { get; set; }

    public string? MeetingRoom { get; set; }

    public string? Status { get; set; }

    public string? Tower { get; set; }

    public string? Floor { get; set; }

    public string? Unit { get; set; }

    public int? CardType { get; set; }

    public string? Name { get; set; }

    public long? SyncIndex { get; set; }

    public int? Gender { get; set; }

    public string? SystemVersion { get; set; }
}

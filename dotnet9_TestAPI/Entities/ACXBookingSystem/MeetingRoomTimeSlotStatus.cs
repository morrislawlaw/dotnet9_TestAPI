using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class MeetingRoomTimeSlotStatus
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? RoomId { get; set; }

    public int? GlobalSettingId { get; set; }

    public int? IndvSettingId { get; set; }

    public TimeOnly? From { get; set; }

    public TimeOnly? To { get; set; }

    public DateOnly? EffectDate { get; set; }

    public DateTime? AddDt { get; set; }

    public bool? Enable { get; set; }
}

using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Meeting
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? MeetingId { get; set; }

    public string? RoomId { get; set; }

    public DateTime? EntryAccessDatetime { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public DateTime? AccessExpiryDatetime { get; set; }

    public string? MeetingTitle { get; set; }

    public string? HostName { get; set; }

    public DateTime? AddDt { get; set; }

    public string? AddUser { get; set; }

    public string? BookingPeriod { get; set; }

    public string? BookingPeriodDetail { get; set; }
}

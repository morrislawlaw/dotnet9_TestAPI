using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class TenantVisitRecord
{
    public int Id { get; set; }

    public int HomeId { get; set; }

    public string? StaffId { get; set; }

    public string? VisitorName { get; set; }

    public byte[]? VisitorPhoto { get; set; }

    public string? TelNo { get; set; }

    public string? Company { get; set; }

    public string? EmailAddress { get; set; }

    public string? Purpose { get; set; }

    public DateTime? BookingDate { get; set; }

    public DateTime? BookingFromTime { get; set; }

    public DateTime? BookingToTime { get; set; }

    public string? Interviewer { get; set; }

    public string? InterviewerDepartment { get; set; }

    public string? InterviewerTelNo { get; set; }

    public string? InterviewerEmailAddress { get; set; }

    public string? TenantCompany { get; set; }

    public DateTime? VisitEnterTime { get; set; }

    public DateTime? VisitLeaveTime { get; set; }

    public DateTime? AddDt { get; set; }

    public string? CardId { get; set; }

    public string? Room { get; set; }

    public long? GuidId { get; set; }

    public short? PassageType { get; set; }

    public int? Reception { get; set; }

    public byte[]? Sigunature { get; set; }

    public string? QrCode { get; set; }

    public string? MeetingRoom { get; set; }

    public bool? IsUpdate { get; set; }

    public int? Status { get; set; }

    public string? Floor { get; set; }

    public string? Tower { get; set; }

    public string? Unit { get; set; }
}

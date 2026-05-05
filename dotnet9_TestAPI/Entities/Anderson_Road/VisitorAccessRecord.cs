using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class VisitorAccessRecord
{
    public int Id { get; set; }

    public string HomeId { get; set; } = null!;

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

    public long? SyncIndex { get; set; }

    public int? Gender { get; set; }

    public DateTime? EntryDt { get; set; }

    public short? IoStatus { get; set; }

    public short? ReaderId { get; set; }

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public short? DeviceType { get; set; }

    public string? DestFloor { get; set; }

    public string? RoomDesc { get; set; }

    public string? PersonalId { get; set; }

    public string? Remark { get; set; }

    public bool? IsMask { get; set; }
}

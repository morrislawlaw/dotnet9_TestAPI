using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AttendanceDayReport
{
    public DateTime AttnDate { get; set; }

    public string CardholderId { get; set; } = null!;

    public string? Shift { get; set; }

    public short? IsWorkDay { get; set; }

    public DateTime? BookOn { get; set; }

    public DateTime? LunchStart { get; set; }

    public DateTime? LunchEnd { get; set; }

    public DateTime? BookOff { get; set; }

    public DateTime? OtStart { get; set; }

    public DateTime? OtEnd { get; set; }

    public short? Late { get; set; }

    public short? Late1 { get; set; }

    public short? Late2 { get; set; }

    public short? Late3 { get; set; }

    public short? EarlyReach { get; set; }

    public short? EarlyLeave { get; set; }

    public short? OtHrs { get; set; }

    public short? Ot1Hrs { get; set; }

    public short? Ot2Hrs { get; set; }

    public short? OtType { get; set; }

    public short? LeaveHrs { get; set; }

    public string? LeaveType { get; set; }

    public DateTime? LeaveStart { get; set; }

    public DateTime? LeaveEnd { get; set; }

    public bool? AttnStatus0 { get; set; }

    public bool? AttnStatus1 { get; set; }

    public bool? AttnStatus2 { get; set; }

    public bool? AttnStatus3 { get; set; }

    public bool? AttnStatus4 { get; set; }

    public bool? AttnStatus5 { get; set; }

    public bool? AttnStatus6 { get; set; }

    public bool? AttnStatus7 { get; set; }

    public bool? AttnStatus8 { get; set; }

    public short? WorkHrs { get; set; }

    public string? AttnStatus { get; set; }

    public short? ShiftHrs { get; set; }
}

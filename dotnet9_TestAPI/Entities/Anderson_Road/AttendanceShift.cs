using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AttendanceShift
{
    public string Shift { get; set; } = null!;

    public short? ShiftType { get; set; }

    public DateTime? BookOn { get; set; }

    public DateTime? LunchStart { get; set; }

    public DateTime? LunchEnd { get; set; }

    public DateTime? BookOff { get; set; }

    public short? BookOnRange { get; set; }

    public short? BookOffRange { get; set; }

    public short? LunchStartRange { get; set; }

    public short? LunchEndRange { get; set; }

    public DateTime? LunchDiningTime { get; set; }

    public short? LateTolerance { get; set; }

    public bool? LateExcludeTolerance { get; set; }

    public short? OtStart { get; set; }

    public short? OtEnd { get; set; }

    public bool? OtEarly { get; set; }

    public DateTime? OtDiningTime { get; set; }

    public bool? OtIncludeBefore { get; set; }

    public bool? OtDeductLate { get; set; }

    public DateTime? WorkHrs { get; set; }

    public short? AfterBookoffTime { get; set; }

    public float? AfterOtUnit { get; set; }

    public float? OtherOtUnit { get; set; }

    public float? BeforeOtUnit { get; set; }

    public float? RestDayOtUnit { get; set; }

    public float? OtUnit { get; set; }

    public string? ShiftDesc { get; set; }
}

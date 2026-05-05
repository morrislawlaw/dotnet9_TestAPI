using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AttendanceEmailManager
{
    public int Recno { get; set; }

    public string? CardholderId { get; set; }

    public bool? DayAttnReport { get; set; }

    public bool? DayAccessRecords { get; set; }

    public bool? IndAttnReport { get; set; }

    public bool? IndWeekEnable { get; set; }

    public bool? IndMonthEnable { get; set; }

    public short? WeekCutOff { get; set; }

    public short? MonthCutOff { get; set; }
}

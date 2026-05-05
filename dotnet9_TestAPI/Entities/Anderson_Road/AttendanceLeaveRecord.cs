using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AttendanceLeaveRecord
{
    public int Recno { get; set; }

    public string? CardholderId { get; set; }

    public string? LeaveType { get; set; }

    public DateTime? StartDt { get; set; }

    public DateTime? EndDt { get; set; }

    public DateTime? AddDt { get; set; }
}

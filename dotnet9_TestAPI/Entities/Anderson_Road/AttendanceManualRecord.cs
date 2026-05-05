using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AttendanceManualRecord
{
    public string CardholderId { get; set; } = null!;

    public DateTime AttnDate { get; set; }

    public DateTime? BookOn { get; set; }

    public DateTime? LunchStart { get; set; }

    public DateTime? LunchEnd { get; set; }

    public DateTime? BookOff { get; set; }

    public string? Reason { get; set; }

    public DateTime? AddDt { get; set; }
}

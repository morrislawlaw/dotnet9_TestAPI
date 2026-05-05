using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class VisitCardInfo
{
    public long Id { get; set; }

    public string? CardId { get; set; }

    public string? VisitorName { get; set; }

    public string? Company { get; set; }

    public string? Purpose { get; set; }

    public string? Interviewer { get; set; }

    public string? InterviewerDepartment { get; set; }

    public bool? PsUsed { get; set; }

    public byte[]? PsData { get; set; }

    public byte[]? PsData2 { get; set; }

    public DateTime? AddDt { get; set; }
}

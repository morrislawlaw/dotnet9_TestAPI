using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ViewVisitorAccessReport
{
    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public string? CardId { get; set; }

    public string? EntryDt { get; set; }

    public string? VisitorName { get; set; }

    public string? VisitorTelephone { get; set; }

    public string? PersonalId { get; set; }

    public string? Purpose { get; set; }

    public string? Interviewer { get; set; }

    public string? InterviewerTelNo { get; set; }

    public string? TenantCompany { get; set; }

    public string? Doors { get; set; }

    public string? Floor { get; set; }

    public string? Unit { get; set; }
}

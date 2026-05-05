using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class VisionEntryReport
{
    public int Recno { get; set; }

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public string? CardInteNo { get; set; }

    public string? CardInteNoHex { get; set; }

    public string? CardExtNo { get; set; }

    public string? DepaDesc { get; set; }

    public DateTime? EntryDt { get; set; }

    public string? RecType { get; set; }

    public short? IoStatus { get; set; }

    public short? ReaderId { get; set; }

    public DateTime? AddDt { get; set; }

    public string? VisitorName { get; set; }

    public string? TelNo { get; set; }

    public string? Company { get; set; }

    public string? EmailAddress { get; set; }

    public string? Interviewer { get; set; }

    public string? InterviewerDepartment { get; set; }

    public string? TenantCompany { get; set; }

    public string? Unit { get; set; }

    public string? Tower { get; set; }

    public string? Floor { get; set; }
}

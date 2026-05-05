using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class SysEventLog
{
    public int Id { get; set; }

    public int? EventId { get; set; }

    public string? DeviceId { get; set; }

    public string? RefId { get; set; }

    public DateTime? OccurTime { get; set; }

    public DateTime? ResumeTime { get; set; }

    public DateTime? AddDt { get; set; }
}

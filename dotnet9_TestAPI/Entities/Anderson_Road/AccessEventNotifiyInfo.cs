using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessEventNotifiyInfo
{
    public string EventType { get; set; } = null!;

    public DateTime? EventTimeFrom { get; set; }

    public DateTime? EventTimeTo { get; set; }

    public string? DoorGroups { get; set; }

    public bool? IsSendMail { get; set; }

    public bool? IsCallPhone { get; set; }

    public bool? IsSendVideo { get; set; }
}

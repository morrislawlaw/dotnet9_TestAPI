using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IoeventDefinition
{
    public short EventType { get; set; }

    public string? EventDesc { get; set; }

    public bool? SendMilestone { get; set; }

    public bool? SendSiemens { get; set; }

    public bool? SendBroadcast { get; set; }

    public bool? VideoTrigger { get; set; }

    public bool? EventConfirm { get; set; }

    public bool? PlayMusic { get; set; }

    public bool? IsEnable { get; set; }
}

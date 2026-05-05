using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ModbusMap
{
    public string? DeviceId { get; set; }

    public int? PanelId { get; set; }

    public int? IoIndex { get; set; }

    public int? Address { get; set; }

    public int? RegisterValue { get; set; }
}

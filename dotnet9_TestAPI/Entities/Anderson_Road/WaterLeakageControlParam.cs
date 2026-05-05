using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class WaterLeakageControlParam
{
    public string DeviceId { get; set; } = null!;

    public string SensorId { get; set; } = null!;

    public string? SensorInput1 { get; set; }

    public string? SensorInput2 { get; set; }

    public string? LedAlarm { get; set; }

    public string? Buzzer { get; set; }
}

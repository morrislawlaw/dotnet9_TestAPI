using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class LilfControlParam
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public bool? EnableTimezone { get; set; }

    public short? WaitTime { get; set; }
}

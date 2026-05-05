using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessAntiBackGroupDetail
{
    public string AntiBackGroup { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }
}

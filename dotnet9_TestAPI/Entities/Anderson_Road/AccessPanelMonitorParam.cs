using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessPanelMonitorParam
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public string UserId { get; set; } = null!;
}

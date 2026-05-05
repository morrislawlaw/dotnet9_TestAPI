using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessIndEntryTimezone
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short TzIndex { get; set; }

    public string? TzDesc { get; set; }

    public bool? IndEnable { get; set; }
}

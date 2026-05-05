using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessPalmSecureDevice
{
    public int IpPort { get; set; }

    public string IpAddress { get; set; } = null!;

    public string PalmSecureDesc { get; set; } = null!;

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public short? CardFormat { get; set; }

    public short? Fccode { get; set; }
}

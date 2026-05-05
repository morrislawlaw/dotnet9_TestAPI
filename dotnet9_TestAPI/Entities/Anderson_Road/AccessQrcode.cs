using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessQrcode
{
    public int IpPort { get; set; }

    public string IpAddress { get; set; } = null!;

    public string QrCodeDesc { get; set; } = null!;

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public int? ReaderType { get; set; }

    public int? LimitType { get; set; }
}

using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IooutputParam
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short IoIndex { get; set; }

    public string? IoDesc { get; set; }

    public bool? IsEnable { get; set; }

    public string? IoCode { get; set; }

    public short? OutputType { get; set; }
}

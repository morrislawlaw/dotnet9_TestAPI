using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IoControllerView
{
    public string? IpAddress { get; set; }

    public int? IpPort { get; set; }

    public string MacAddress { get; set; } = null!;

    public short? DeviceType { get; set; }

    public string DeviceId { get; set; } = null!;
}

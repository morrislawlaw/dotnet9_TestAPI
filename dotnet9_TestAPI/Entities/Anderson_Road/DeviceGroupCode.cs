using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class DeviceGroupCode
{
    public string GroupCode { get; set; } = null!;

    public string? GroupDesc { get; set; }

    public string? ServerIp { get; set; }
}

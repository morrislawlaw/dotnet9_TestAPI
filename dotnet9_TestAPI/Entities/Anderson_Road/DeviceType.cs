using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class DeviceType
{
    public short DeviceType1 { get; set; }

    public string? TypeDesc { get; set; }

    public string? SimplifiedChinese { get; set; }

    public string? TraditionalChinese { get; set; }

    public string? English { get; set; }

    public string? Other { get; set; }

    public short? Subsystem { get; set; }
}

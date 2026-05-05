using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class SysInfo
{
    public string SysKey { get; set; } = null!;

    public string? SysValues { get; set; }

    public string? Remark { get; set; }
}

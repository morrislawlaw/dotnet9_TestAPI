using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessAntiBackGroup
{
    public string AntiBackGroup { get; set; } = null!;

    public string? AntiBackGroupDesc { get; set; }

    public bool? IsGlobal { get; set; }
}

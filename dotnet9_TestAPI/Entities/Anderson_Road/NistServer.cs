using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class NistServer
{
    public string ServerName { get; set; } = null!;

    public string? IpAddress { get; set; }

    public string? Note { get; set; }

    public string? Location { get; set; }

    public string? Remark { get; set; }
}

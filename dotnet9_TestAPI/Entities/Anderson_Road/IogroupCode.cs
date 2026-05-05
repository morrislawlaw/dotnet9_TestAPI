using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IogroupCode
{
    public short? IoCommand { get; set; }

    public short IoGroupNo { get; set; }

    public short IoZone { get; set; }

    public string GroupDesc { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public bool? IsEnable { get; set; }
}

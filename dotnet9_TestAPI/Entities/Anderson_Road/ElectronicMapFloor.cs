using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ElectronicMapFloor
{
    public string FloorName { get; set; } = null!;

    public string BuildingName { get; set; } = null!;

    public string SubFloorName { get; set; } = null!;

    public byte[]? FloorImage { get; set; }

    public float? ImageZoom { get; set; }

    public short? BgZoomValue { get; set; }
}

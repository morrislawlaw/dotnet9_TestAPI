using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class BuildingFloorsInfo
{
    public string BuildingCode { get; set; } = null!;

    public short FloorNumber { get; set; }

    public string? FloorDesc { get; set; }

    public short? VisitFloorNumber { get; set; }
}

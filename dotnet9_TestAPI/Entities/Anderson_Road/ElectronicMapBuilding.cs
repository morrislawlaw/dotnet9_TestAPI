using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ElectronicMapBuilding
{
    public string BuildingName { get; set; } = null!;

    public byte[]? BuildingImage { get; set; }
}

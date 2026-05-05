using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class BuildingInfo
{
    public string BuildingCode { get; set; } = null!;

    public string? BuildingName { get; set; }

    public short? BuildingNum { get; set; }

    public string? AccessDoorGroup { get; set; }
}

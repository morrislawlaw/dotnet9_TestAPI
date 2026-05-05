using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class BuildingFloorsAuthorityGroup
{
    public string FloorsGroup { get; set; } = null!;

    public string? BuildingCode { get; set; }

    public short? DefaultFloor { get; set; }

    public long SyncIndex { get; set; }
}

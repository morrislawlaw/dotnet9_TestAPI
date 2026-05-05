using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class BuildingFloorsUnitInfo
{
    public string BuildingCode { get; set; } = null!;

    public string FloorNumber { get; set; } = null!;

    public string RoomNumber { get; set; } = null!;

    public string? RoomDesc { get; set; }

    public long SyncIndex { get; set; }

    public string? DoorGroups { get; set; }
}

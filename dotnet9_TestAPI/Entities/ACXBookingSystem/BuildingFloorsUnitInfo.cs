using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class BuildingFloorsUnitInfo
{
    public string BuildingCode { get; set; } = null!;

    public short FloorNumber { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string? RoomDesc { get; set; }

    public long SyncIndex { get; set; }

    public string? DoorGroups { get; set; }
}

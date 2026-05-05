using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanCardholdersFloorInfo
{
    public string CardholderId { get; set; } = null!;

    public string? Name { get; set; }

    public string? BuildingCode { get; set; }

    public short? FloorNumber { get; set; }

    public string? RoomNumber { get; set; }

    public long SyncIndex { get; set; }
}

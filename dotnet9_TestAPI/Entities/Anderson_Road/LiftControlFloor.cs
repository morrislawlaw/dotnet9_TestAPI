using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class LiftControlFloor
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short PortId { get; set; }

    public string? BuildingCode { get; set; }

    public string? FloorNumber { get; set; }

    public string? FloorDesc { get; set; }

    public bool? IsEnable { get; set; }

    public short? WaitTimes { get; set; }

    public short? TzIndex { get; set; }

    public long SyncIndex { get; set; }
}

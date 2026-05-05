using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ElectronicMapFloorDevice
{
    public string BuildingName { get; set; } = null!;

    public string FloorName { get; set; } = null!;

    public string SubFloorName { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short DeviceType { get; set; }

    public short? LocationX { get; set; }

    public short? LocationY { get; set; }

    public string? CctvUrl { get; set; }
}

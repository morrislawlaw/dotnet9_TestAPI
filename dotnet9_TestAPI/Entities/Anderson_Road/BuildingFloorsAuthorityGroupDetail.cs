using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class BuildingFloorsAuthorityGroupDetail
{
    public string FloorsGroup { get; set; } = null!;

    public string BuildingCode { get; set; } = null!;

    public short FloorNumber { get; set; }

    public short? TzIndex { get; set; }

    public short? LiftDoorOpenType { get; set; }

    public long SyncIndex { get; set; }
}

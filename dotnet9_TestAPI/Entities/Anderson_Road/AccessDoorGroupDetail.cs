using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessDoorGroupDetail
{
    public string DoorGroup { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short? TzIndex { get; set; }

    public long SyncIndex { get; set; }

    public virtual AccessDoorGroup DoorGroupNavigation { get; set; } = null!;
}

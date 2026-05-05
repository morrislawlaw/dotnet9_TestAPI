using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessDoorGroup
{
    public string DoorGroup { get; set; } = null!;

    public string? DoorGroupDesc { get; set; }

    public int? GroupType { get; set; }

    public bool? UpdateData { get; set; }

    public string? UserId { get; set; }

    public long SyncIndex { get; set; }

    public virtual ICollection<AccessDoorGroupDetail> AccessDoorGroupDetails { get; set; } = new List<AccessDoorGroupDetail>();
}

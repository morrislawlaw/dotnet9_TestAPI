using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class UserCtrlGroup
{
    public string UserId { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public virtual User User { get; set; } = null!;
}

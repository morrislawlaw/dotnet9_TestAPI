using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IogroupAccessControl
{
    public string GroupCode { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }
}

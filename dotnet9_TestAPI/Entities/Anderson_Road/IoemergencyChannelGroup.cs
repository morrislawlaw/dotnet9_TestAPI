using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IoemergencyChannelGroup
{
    public string AcceptGroupCode { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short IoIndex { get; set; }
}

using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class MailboxControlParam
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short PortId { get; set; }

    public bool? IsEnable { get; set; }

    public short? WaitTimes { get; set; }

    public short? TzIndex { get; set; }

    public string? BuildingCode { get; set; }

    public short? FloorNumber { get; set; }

    public string? RoomNumber { get; set; }

    public string? VdpIpAddress { get; set; }
}

using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class IoinputParam
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short IoIndex { get; set; }

    public string? IoDesc { get; set; }

    public short? NormalStatus { get; set; }

    public short? InputEvent { get; set; }

    public bool? IsEnable { get; set; }

    public string? IoCode { get; set; }

    public string? BroadcastGroupCode { get; set; }

    public short? Output1 { get; set; }

    public short? Output2 { get; set; }

    public short? Action { get; set; }

    public short? TzIndex { get; set; }

    public bool? IsConfirm { get; set; }

    public DateTime? EventDt { get; set; }

    public short? EventType { get; set; }

    public string? CameraCode1 { get; set; }

    public string? CameraCode2 { get; set; }

    public short? ModbusPoint { get; set; }
}

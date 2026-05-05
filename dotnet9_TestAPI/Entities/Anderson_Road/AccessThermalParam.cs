using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessThermalParam
{
    public int? FaceIpPort { get; set; }

    public string? FaceIpAddress { get; set; }

    public short? FaceId { get; set; }

    public string DeviceId { get; set; } = null!;

    public short? PanelType { get; set; }

    public string PanelIpAddress { get; set; } = null!;

    public int PanelIpPort { get; set; }

    public int? InOut { get; set; }

    public string? Tower { get; set; }

    public short? TerminalId { get; set; }

    public bool? Relay1Enable { get; set; }

    public short? Relay1ReleaseTime { get; set; }

    public bool? Relay2Enable { get; set; }

    public short? Relay2ReleaseTime { get; set; }

    public bool? Relay3Enable { get; set; }

    public short? Relay3ReleaseTime { get; set; }

    public bool? Relay4Enable { get; set; }

    public short? Relay4ReleaseTime { get; set; }

    public double? TemperatureLow { get; set; }

    public double? TemperatureHigh { get; set; }

    public short? CheckTemperatureInterval { get; set; }

    public short? ReadyStatus { get; set; }

    public short? HighTemperatureStatus { get; set; }

    public short? NormalTemperatureStatus { get; set; }

    public short? HighTemperatureTimeout { get; set; }

    public short? NormalTemperatureTimeout { get; set; }

    public bool? AntiPassbackEnable { get; set; }

    public bool? BodyTemperatureEnable { get; set; }

    public bool? CheckMaskEnable { get; set; }

    public short? CheckMaskInterval { get; set; }

    public bool? EmergencyCancelBodyTemperatureEnable { get; set; }

    public short? LocalZone { get; set; }

    public string? LocalDirection { get; set; }

    public bool? IsAutoRestartFacialDevice { get; set; }

    public short? AutoRestartTimeout { get; set; }

    public bool? DeviceOk { get; set; }

    public short? AccessGrantedOutput { get; set; }

    public short? AccessGrantedOutputRelayTime { get; set; }

    public short? CardnoRetryTime { get; set; }

    public string? PcIpAddress { get; set; }

    public short? PcIpPort { get; set; }

    public bool? IsAutoRestartPc { get; set; }

    public short? PcautoRestartTimeout { get; set; }

    public bool? CheckMaskInput1 { get; set; }
}

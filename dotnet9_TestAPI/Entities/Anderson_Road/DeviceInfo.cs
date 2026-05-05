using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class DeviceInfo
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short? DeviceType { get; set; }

    public string? PanelDesc { get; set; }

    public bool? DeviceOk { get; set; }

    public string? Version { get; set; }

    public short? CommType { get; set; }

    public short? ComPort { get; set; }

    public int? IpPort { get; set; }

    public string? IpAddress { get; set; }

    public short? TimeDiff { get; set; }

    public short? Subsystem { get; set; }

    public bool? TakeAttandance { get; set; }

    public DateTime? Clock { get; set; }

    public int Recno { get; set; }

    public short? TcpIpmoduleRebotTime { get; set; }

    public string? CameraCode1 { get; set; }

    public string? CameraCode2 { get; set; }

    public string? CommunicationKey { get; set; }

    public string? GuidId { get; set; }

    public string? MacAddress { get; set; }

    public short? UsedType { get; set; }

    public short? LiftServerReaderNumber { get; set; }

    public bool? IsVisitDevice { get; set; }

    public bool? IsBmsdevice { get; set; }

    public string? VisitFloors { get; set; }

    public bool? IsVisitDeviceCommonDoor { get; set; }

    public string? RandomKey { get; set; }

    public int? AutoSyncDatetime { get; set; }

    public DateTime? SyncDatetime { get; set; }

    public short? TurnstileIoType { get; set; }

    public string? BuildingCode { get; set; }

    public string? GroupCode { get; set; }

    public string? CheckInReader { get; set; }

    public string? CheckOutReader { get; set; }

    public short? OrderIndex { get; set; }

    public string? WaterLeakageDeviceId { get; set; }

    public short? VersionType { get; set; }

    public short? LastInOut { get; set; }
}

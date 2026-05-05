using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessCtrlParament
{
    public int Recno { get; set; }

    public bool? OpenLongTzEnable { get; set; }

    public bool? OpenLongEnable { get; set; }

    public short? OpenLongTime { get; set; }

    public bool? TransferBreakinEnable { get; set; }

    public short? TransferBreakinTime { get; set; }

    public bool? ReleButtonTzEnable { get; set; }

    public bool? DoorBreakinEnable { get; set; }

    public bool? DoorBreakinTzEnable { get; set; }

    public bool? CtrlBoxBreakinEnable { get; set; }

    public bool? BreakinAutoResetEnable { get; set; }

    public short? BreakinAutoResetTime { get; set; }

    public bool? PasswordAccessInEnable { get; set; }

    public bool? PasswordAccessOutEnable { get; set; }

    public bool? PasswordRetryEnable { get; set; }

    public short? PasswordRetryTimes { get; set; }

    public short? ReleaseLockTime { get; set; }

    public bool? ElockTzEnable { get; set; }

    public bool? CoercionPasswordEnable { get; set; }

    public string? CoercionPassword { get; set; }

    public bool? CommonPasswordEnable { get; set; }

    public string? CommonPassword { get; set; }

    public short? LinkCardOpenTime { get; set; }

    public bool? LinkCardOpenEnable { get; set; }

    public bool? LinkCardOpenPasswordEnable { get; set; }

    public bool? LinkCardOpenOutPasswordEnable { get; set; }

    public bool? LinkCardOpenTzEnable { get; set; }

    public short? AntiEnable { get; set; }

    public bool? PasswordTzEnable { get; set; }

    public short? CtrllerOrReaderAnti { get; set; }

    public short? NormalCardTimeout { get; set; }

    public short? CardholderCapacity { get; set; }

    public bool? AcAlarmEnable { get; set; }

    public bool? DoorAjarBuzzerEnable { get; set; }

    public bool? DoorBreakinBuzzerEnable { get; set; }

    public bool? PanelTamperBreakinBuzzerEnable { get; set; }

    public bool? DoubleDoorLockEnable { get; set; }

    public bool? MagneticAlrmBuzzerEnable { get; set; }

    public bool? MoLineAlarmBuzzerEnable { get; set; }

    public bool? DcAlarmBuzzerEnable { get; set; }

    public bool? AcAlarmBuzzerEnable { get; set; }

    public bool? DcAlarmEnable { get; set; }

    public bool? MoLineAlarmEnable { get; set; }

    public bool? MagneticAlrmEnable { get; set; }

    public bool? FireAlarmEnable { get; set; }

    public short? FireAlarmOuput { get; set; }

    public short? FireAlarmDoorOpen { get; set; }

    public bool? ReaderAntidisassemblyEnable { get; set; }

    public bool? ReaderAntidisassemblyBuzzerEnable { get; set; }

    public bool? OutAccessTzEnable { get; set; }
}

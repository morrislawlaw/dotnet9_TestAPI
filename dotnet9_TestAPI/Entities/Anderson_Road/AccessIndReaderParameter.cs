using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessIndReaderParameter
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public bool? IndEnable { get; set; }

    public short? LcdContrast { get; set; }

    public string? InMsgLog { get; set; }

    public string? InMsgIdle { get; set; }

    public string? InMsgAccept { get; set; }

    public string? InMsgReject { get; set; }

    public string? OutMsgLog { get; set; }

    public string? OutMsgIdle { get; set; }

    public string? OutMsgAccept { get; set; }

    public string? OutMsgReject { get; set; }

    public short? MsgTimeout { get; set; }

    public short? NormalStatus { get; set; }

    public short? AccessGrantedStatus { get; set; }

    public short? AccessDeniedStatus { get; set; }

    public short? DisplayCardNoEnable { get; set; }

    public short? DisplayFcCodeEnable { get; set; }

    public short? DisplayFormatHex { get; set; }

    public short? LeadingZeroEnable { get; set; }

    public short? DisplayDateFormat { get; set; }

    public short? PasswordInputMode { get; set; }

    public short? Baudrate { get; set; }

    public short? LightingDelayTime { get; set; }

    public short? CloseTwinkleTime { get; set; }

    public short? GrantedTwinkleCount { get; set; }

    public short? DeniedTwinkleCount { get; set; }

    public short? BuzzerTime { get; set; }

    public short? CloseBuzzerTime { get; set; }

    public short? GrantedBuzzerCount { get; set; }

    public short? DeniedBuzzerCount { get; set; }

    public short? CardBits { get; set; }

    public bool? CardSiteEnable { get; set; }

    public short? SiteCode1 { get; set; }

    public short? SiteCode2 { get; set; }

    public short? SiteCode3 { get; set; }

    public short? SitePos { get; set; }

    public short? SiteLength { get; set; }

    public short? CardIdPos { get; set; }

    public short? CardIdLength { get; set; }

    public bool? OddEnable { get; set; }

    public short? OddPPos { get; set; }

    public short? OddPStart { get; set; }

    public short? OddPLength { get; set; }

    public bool? EvenEnable { get; set; }

    public short? EvenPPos { get; set; }

    public short? EvenPStart { get; set; }

    public short? EvenPLength { get; set; }

    public short? ReadCardType { get; set; }

    public bool? CsnReserve { get; set; }

    public short? CardNoPosStart { get; set; }

    public short? CardNoLength { get; set; }

    public short? CardNoSector { get; set; }

    public short? CardNoBlock { get; set; }

    public short? CardKeyType { get; set; }

    public short? CardType { get; set; }

    public string? CardKeyData { get; set; }

    public string? ReaderCommKey { get; set; }

    public bool? InReaderBluetoothEnable { get; set; }

    public bool? OutReaderBluetoothEnable1 { get; set; }
}

using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessHidreaderParameter
{
    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public short? ReaderType { get; set; }

    public short? LcdContrast { get; set; }

    public string? MsgLine1 { get; set; }

    public string? MsgLine4 { get; set; }

    public string? MsgAccept { get; set; }

    public string? MsgReject { get; set; }

    public short? MsgTimeout { get; set; }

    public short? DisplayCardNoEnable { get; set; }

    public short? DisplayFcCodeEnable { get; set; }

    public short? DisplayFormatHex { get; set; }

    public short? LeadingZeroEnable { get; set; }

    public short? DisplayDateFormat { get; set; }

    public short? CardType { get; set; }

    public short? CsnLangth { get; set; }

    public bool? CsnReversal { get; set; }

    public bool? CheckInOut { get; set; }

    public short? DoorInOut { get; set; }

    public bool? DisplaySystemMsg { get; set; }
}

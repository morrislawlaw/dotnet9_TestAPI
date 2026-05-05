using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class DeviceCardformat
{
    public short FormatType { get; set; }

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public bool? CsnReserve { get; set; }

    public bool? CsnParityEnable { get; set; }

    public short? CsnBits { get; set; }

    public bool? SectorFixCardnoEnable { get; set; }

    public short? SectorOutputBits { get; set; }

    public bool? SectorPraityEnable { get; set; }

    public bool? CardFormatEnable { get; set; }

    public short? CardBits { get; set; }

    public bool? CardSiteEnable { get; set; }

    public short? SiteCode1 { get; set; }

    public short? SiteCode2 { get; set; }

    public short? SiteCode3 { get; set; }

    public short? SitePos { get; set; }

    public short? SiteLength { get; set; }

    public short? CardIdPos { get; set; }

    public short? CardIdBitPer { get; set; }

    public short? CardIdLength { get; set; }

    public bool? OddEnable { get; set; }

    public short? OddPPos { get; set; }

    public short? OddPStart { get; set; }

    public short? OddPLength { get; set; }

    public bool? EvenEnable { get; set; }

    public short? EvenPPos { get; set; }

    public short? EvenPStart { get; set; }

    public short? EvenPLength { get; set; }
}

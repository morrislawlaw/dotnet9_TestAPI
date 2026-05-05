using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class CardInfo
{
    public string CardInteNo { get; set; } = null!;

    public string? CardExtNo { get; set; }

    public string? CardInteNoHex { get; set; }

    public short? CardStatus { get; set; }

    public string? CardholderId { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? IsEnableFingerprint { get; set; }

    public bool? IsEnablePalmSecure { get; set; }

    public bool? IsEnableVirtualCard { get; set; }

    public bool? IsEnableFace { get; set; }

    public bool? IsEnableMailBox { get; set; }

    public string? AntiBackGroup { get; set; }

    public string? VirtualCardActCode { get; set; }

    public string? ActCodePassword { get; set; }

    public long SyncIndex { get; set; }

    public bool? IsDeleteFrom8901X { get; set; }

    public bool? IsDeleteFrom8906 { get; set; }

    public short? LastInOut { get; set; }
}

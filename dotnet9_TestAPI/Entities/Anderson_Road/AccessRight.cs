using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessRight
{
    public string CardExtNo { get; set; } = null!;

    public string? CardInteNo { get; set; }

    public string? CardholderId { get; set; }

    public string? Password { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? DoorGroup { get; set; }

    public short? GroupType { get; set; }

    public DateTime? AddDt { get; set; }

    public string? GuidId { get; set; }

    public long SyncIndex { get; set; }

    public bool? IsUpdatedForExpiry { get; set; }
}

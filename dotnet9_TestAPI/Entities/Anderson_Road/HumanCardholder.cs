using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanCardholder
{
    public string CardholderId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Company { get; set; }

    public string? DepaCode { get; set; }

    public string? DiviCode { get; set; }

    public string? PositionDesc { get; set; }

    public string? Category { get; set; }

    public short? Sex { get; set; }

    public string? TelNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? LocalAddress { get; set; }

    public DateTime? AddDt { get; set; }

    public int? Id { get; set; }

    public long SyncIndex { get; set; }

    public DateTime? JoinDate { get; set; }

    public DateTime? QuitDate { get; set; }
}

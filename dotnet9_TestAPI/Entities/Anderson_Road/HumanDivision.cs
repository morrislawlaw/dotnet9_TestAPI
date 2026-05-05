using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanDivision
{
    public string DiviCode { get; set; } = null!;

    public string? DiviDesc { get; set; }

    public string? DepaCode { get; set; }

    public string? AccessDoorGroup { get; set; }

    public long SyncIndex { get; set; }
}

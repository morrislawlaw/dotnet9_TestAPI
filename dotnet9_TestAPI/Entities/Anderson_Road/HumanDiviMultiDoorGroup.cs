using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanDiviMultiDoorGroup
{
    public string DiviCode { get; set; } = null!;

    public string AccessDoorGroup { get; set; } = null!;

    public long SyncIndex { get; set; }
}

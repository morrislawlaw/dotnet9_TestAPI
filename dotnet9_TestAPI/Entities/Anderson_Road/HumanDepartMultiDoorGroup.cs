using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanDepartMultiDoorGroup
{
    public string DepaCode { get; set; } = null!;

    public string AccessDoorGroup { get; set; } = null!;

    public long SyncIndex { get; set; }
}

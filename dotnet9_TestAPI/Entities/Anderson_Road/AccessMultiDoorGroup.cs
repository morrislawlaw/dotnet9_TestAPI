using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessMultiDoorGroup
{
    public string CardInteNo { get; set; } = null!;

    public string DoorGroup { get; set; } = null!;

    public long SyncIndex { get; set; }
}

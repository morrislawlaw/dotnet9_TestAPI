using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessSpecialRightGroupDetail
{
    public string SpecialRightGroup { get; set; } = null!;

    public string EmpNo { get; set; } = null!;

    public bool? DoorAccess { get; set; }
}

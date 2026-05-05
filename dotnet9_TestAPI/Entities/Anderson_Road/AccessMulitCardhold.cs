using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessMulitCardhold
{
    public string CardExtNo1 { get; set; } = null!;

    public string CardExtNo2 { get; set; } = null!;

    public string? EmpNo1 { get; set; }

    public string? EmpNo2 { get; set; }

    public string? DoorGroup { get; set; }
}

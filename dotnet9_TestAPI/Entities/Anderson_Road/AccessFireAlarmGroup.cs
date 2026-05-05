using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessFireAlarmGroup
{
    public string FireAlarmGroup { get; set; } = null!;

    public bool? IsEnable { get; set; }
}

using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessAlarmDefinition
{
    public int AlarmType { get; set; }

    public int AlarmEnable { get; set; }

    public int? AlarmStatue { get; set; }

    public TimeOnly? AlarmTimeFrom { get; set; }

    public TimeOnly? AlarmTimeTo { get; set; }
}

using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ElectronicMapAlarmLog
{
    public int Recno { get; set; }

    public DateTime? AddDt { get; set; }

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public int? AlarmStatus { get; set; }
}

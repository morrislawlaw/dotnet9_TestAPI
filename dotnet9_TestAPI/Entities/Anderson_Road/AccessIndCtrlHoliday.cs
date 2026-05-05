using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessIndCtrlHoliday
{
    public short Id { get; set; }

    public bool? IndEnable { get; set; }

    public DateTime? Holiday { get; set; }

    public string? HolidayDesc { get; set; }

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }
}

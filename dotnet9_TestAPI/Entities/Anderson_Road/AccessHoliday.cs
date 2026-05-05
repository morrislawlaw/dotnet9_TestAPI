using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessHoliday
{
    public short Id { get; set; }

    public DateTime? Holiday { get; set; }

    public string? HolidayDesc { get; set; }
}

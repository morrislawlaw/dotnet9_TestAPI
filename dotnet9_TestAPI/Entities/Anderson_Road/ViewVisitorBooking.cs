using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ViewVisitorBooking
{
    public string? PersonalId { get; set; }

    public string? VisitorName { get; set; }

    public string? VisitorTelephone { get; set; }

    public string? Purpose { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? Floor { get; set; }

    public string? Unit { get; set; }
}

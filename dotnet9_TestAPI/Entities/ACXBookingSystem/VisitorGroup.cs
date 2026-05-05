using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class VisitorGroup
{
    public int Id { get; set; }

    public int? VisitorId { get; set; }

    public string? VisitorName { get; set; }

    public string? GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? CompanyId { get; set; }

    public string? UserId { get; set; }

    public DateTime AddDt { get; set; }
}

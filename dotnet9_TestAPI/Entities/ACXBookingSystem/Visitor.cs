using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Visitor
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? VisitorName { get; set; }

    public string? CompanyName { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? UserId { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpdDt { get; set; }
}

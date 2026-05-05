using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Template
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? Type { get; set; }

    public string? Template1 { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpdDt { get; set; }
}

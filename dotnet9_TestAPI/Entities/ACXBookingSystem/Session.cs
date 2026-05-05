using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Session
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? UserName { get; set; }

    public string? SeseionToken { get; set; }

    public DateTime? UpdDt { get; set; }

    public DateTime? AddDt { get; set; }
}

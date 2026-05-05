using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? CompanyId { get; set; }

    public string? Department { get; set; }

    public string? Phone { get; set; }

    public string? UserName { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? ExpiryDatetime { get; set; }

    public DateTime? AddDt { get; set; }

    public string? UserLevel { get; set; }
}

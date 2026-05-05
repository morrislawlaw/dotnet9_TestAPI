using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class CompanyProfile
{
    public int Id { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? EmailUser { get; set; }

    public string? EmailPassword { get; set; }

    public string? SmtpServer { get; set; }

    public int? SmtpPort { get; set; }

    public bool? SmtpEnableSsl { get; set; }

    public bool? SendEmail { get; set; }
}

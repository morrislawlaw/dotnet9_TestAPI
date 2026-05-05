using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ViewEMail
{
    public string EmailAddress { get; set; } = null!;

    public string DeviceId { get; set; } = null!;

    public short PanelId { get; set; }

    public bool? IsSendEmail { get; set; }

    public string Smtpserver { get; set; } = null!;

    public string? Password { get; set; }

    public string? EmailLoginName { get; set; }

    public string? SenderMail { get; set; }
}

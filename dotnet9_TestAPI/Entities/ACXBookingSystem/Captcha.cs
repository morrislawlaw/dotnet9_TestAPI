using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Captcha
{
    public string? Captcha1 { get; set; }

    public string? RemoteEndpoint { get; set; }

    public string Random { get; set; } = null!;

    public DateTime? AddDt { get; set; }
}

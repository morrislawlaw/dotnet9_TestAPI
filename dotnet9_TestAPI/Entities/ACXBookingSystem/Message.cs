using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Message
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? MessageContent { get; set; }

    public DateTime? AddDt { get; set; }
}

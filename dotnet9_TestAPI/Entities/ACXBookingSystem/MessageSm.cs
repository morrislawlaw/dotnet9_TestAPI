using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class MessageSm
{
    public int Id { get; set; }

    public string? Company { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Name { get; set; }

    public string? Content { get; set; }

    public string? CardNo { get; set; }

    public bool? Success { get; set; }

    public string? SendStatus { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpdDt { get; set; }
}

using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class ReaderKey
{
    public int Id { get; set; }

    public string? ReaderKey1 { get; set; }

    public string? ReaderKey2 { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpdDt { get; set; }
}

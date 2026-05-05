using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class SysDbprocessing
{
    public int Id { get; set; }

    public bool? Monthly { get; set; }

    public bool? Every { get; set; }

    public short? EveryDays { get; set; }

    public string? DbbackupPath { get; set; }

    public bool? DeleteEntryRec { get; set; }

    public short? DeleteEntryRecDays { get; set; }

    public bool? DeleteEventRec { get; set; }

    public short? DeleteEventRecDays { get; set; }
}

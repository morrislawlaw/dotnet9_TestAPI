using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class TblTmpSendLiftFinderCommand
{
    public int Id { get; set; }

    public string? DeviceId { get; set; }

    public short? DeviceType { get; set; }

    public string Command { get; set; } = null!;

    public bool SendSuccess { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpDt { get; set; }

    public bool? IsUpdate { get; set; }
}

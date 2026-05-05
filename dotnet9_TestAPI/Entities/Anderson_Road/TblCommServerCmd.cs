using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class TblCommServerCmd
{
    public int Id { get; set; }

    public string CommServerCmd { get; set; } = null!;

    public string? DeviceId { get; set; }

    public string? IpAdrss { get; set; }

    public string? LinkId { get; set; }

    public string? UserId { get; set; }

    public DateTime? AddDate { get; set; }

    public DateTime? UpDate { get; set; }

    public bool? IsExecute { get; set; }
}

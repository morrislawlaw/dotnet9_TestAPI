using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class NvrcameraDeviceInfo
{
    public string CameraCode { get; set; } = null!;

    public string? CameraDesc { get; set; }

    public string? IpAddress { get; set; }

    public int? IpPort { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public string? DvrCode { get; set; }

    public short? DvrChannel { get; set; }

    public string? MacAddress { get; set; }
}

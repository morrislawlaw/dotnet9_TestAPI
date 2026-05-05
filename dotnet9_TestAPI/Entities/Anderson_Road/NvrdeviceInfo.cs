using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class NvrdeviceInfo
{
    public string DvrCode { get; set; } = null!;

    public string DvrIpAddress { get; set; } = null!;

    public int? DvrIpPort { get; set; }

    public string? DvrUserId { get; set; }

    public string? DvrUserPassword { get; set; }

    public string? DvrDesc { get; set; }

    public short? DvrType { get; set; }
}

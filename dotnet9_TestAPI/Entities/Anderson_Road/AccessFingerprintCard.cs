using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessFingerprintCard
{
    public string FpDesc { get; set; } = null!;

    public string CardExtNo { get; set; } = null!;

    public short FpId { get; set; }
}

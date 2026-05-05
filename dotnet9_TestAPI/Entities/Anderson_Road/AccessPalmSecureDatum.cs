using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessPalmSecureDatum
{
    public string CardInteNo { get; set; } = null!;

    public byte[]? PsData { get; set; }
}

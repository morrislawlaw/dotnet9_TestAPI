using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessRecTypeDiction
{
    public int Recno { get; set; }

    public string? RecType { get; set; }

    public string? SimplifiedChinese { get; set; }

    public string? TraditionalChinese { get; set; }

    public string? English { get; set; }

    public string? Other { get; set; }
}

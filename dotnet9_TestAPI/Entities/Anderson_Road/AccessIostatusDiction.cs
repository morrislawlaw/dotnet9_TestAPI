using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessIostatusDiction
{
    public int Recno { get; set; }

    public short? IoStatus { get; set; }

    public string? SimplifiedChinese { get; set; }

    public string? TraditionalChinese { get; set; }

    public string? English { get; set; }

    public string? Others { get; set; }
}

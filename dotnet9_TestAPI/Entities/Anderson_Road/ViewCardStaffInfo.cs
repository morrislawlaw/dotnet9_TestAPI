using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ViewCardStaffInfo
{
    public string CardInteNo { get; set; } = null!;

    public string? CardExtNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? EmpNo { get; set; }

    public string? PositionDesc { get; set; }

    public string? Name { get; set; }

    public string? DepaDesc { get; set; }

    public byte[]? EmpPhoto { get; set; }

    public DateTime? AddDt { get; set; }
}

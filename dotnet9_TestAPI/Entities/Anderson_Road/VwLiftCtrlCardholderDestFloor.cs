using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class VwLiftCtrlCardholderDestFloor
{
    public short? CardId { get; set; }

    public string CardExtNo { get; set; } = null!;

    public string? CardInteNo { get; set; }

    public string? EmpNo { get; set; }

    public string? Password { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? DoorGroup { get; set; }

    public short? GroupType { get; set; }

    public DateTime? AddDt { get; set; }

    public short? Attribution { get; set; }

    public string FloorsGroup { get; set; } = null!;

    public string BuildingCode { get; set; } = null!;

    public short FloorNumber { get; set; }

    public short? TzIndex { get; set; }

    public short? DoorOpen { get; set; }
}

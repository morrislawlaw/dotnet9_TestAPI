using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AccessEventRecord
{
    public int Recno { get; set; }

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public DateTime? EventDt { get; set; }

    public short? EventType { get; set; }

    public DateTime? AddDt { get; set; }

    public bool? IsConfirm { get; set; }

    public string? Remark { get; set; }

    public string? ConfirmUser { get; set; }

    public DateTime? ConfirmDt { get; set; }

    public short? IoIndex { get; set; }
}

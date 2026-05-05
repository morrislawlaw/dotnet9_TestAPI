using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ViewVisitorAccessRecord
{
    public int Recno { get; set; }

    public string? DeviceId { get; set; }

    public short? PanelId { get; set; }

    public string? CardInteNo { get; set; }

    public string? CardInteNoHex { get; set; }

    public string? CardExtNo { get; set; }

    public string? CardholderId { get; set; }

    public string? Name { get; set; }

    public string? DepaDesc { get; set; }

    public DateTime? EntryDt { get; set; }

    public int RecType { get; set; }

    public short? IoStatus { get; set; }

    public short? ReaderId { get; set; }

    public short? DeviceType { get; set; }

    public DateTime? AddDt { get; set; }

    public string? Remark { get; set; }

    public bool? IsMask { get; set; }
}

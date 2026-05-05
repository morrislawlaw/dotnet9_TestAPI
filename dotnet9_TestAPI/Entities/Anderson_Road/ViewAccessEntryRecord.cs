using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class ViewAccessEntryRecord
{
    public string? Name { get; set; }

    public string? MemberCodeStaffCode { get; set; }

    public string? CardNo { get; set; }

    public string? DoorId { get; set; }

    public DateTime? AccessDateTime { get; set; }
}

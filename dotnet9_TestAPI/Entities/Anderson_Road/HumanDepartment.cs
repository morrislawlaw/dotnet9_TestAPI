using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanDepartment
{
    public string DepaCode { get; set; } = null!;

    public string? DepaDesc { get; set; }

    public string? AccessDoorGroup { get; set; }

    public long SyncIndex { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

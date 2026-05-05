using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? Transfer { get; set; }

    public virtual ICollection<UserCtrlGroup> UserCtrlGroups { get; set; } = new List<UserCtrlGroup>();

    public virtual ICollection<UserFunctionGroup> UserFunctionGroups { get; set; } = new List<UserFunctionGroup>();

    public virtual ICollection<HumanDepartment> DepaCodes { get; set; } = new List<HumanDepartment>();
}

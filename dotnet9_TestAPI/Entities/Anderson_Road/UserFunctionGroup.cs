using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class UserFunctionGroup
{
    public string UserId { get; set; } = null!;

    public string FunctionId { get; set; } = null!;

    public bool? AllowAccess { get; set; }

    public bool? AllowAdd { get; set; }

    public bool? AllowEdit { get; set; }

    public bool? AllowDelete { get; set; }

    public short? SubGroup { get; set; }

    public virtual User User { get; set; } = null!;
}

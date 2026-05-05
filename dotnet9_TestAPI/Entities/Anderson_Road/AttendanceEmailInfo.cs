using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class AttendanceEmailInfo
{
    public int Recno { get; set; }

    public string? EmailAddress { get; set; }

    public string? EmailLoginName { get; set; }

    public string? Password { get; set; }

    public string Smtpserver { get; set; } = null!;

    public bool? SendAttnRecord { get; set; }

    public bool? SendAttnIndividualReport { get; set; }
}

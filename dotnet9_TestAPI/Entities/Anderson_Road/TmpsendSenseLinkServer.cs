using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class TmpsendSenseLinkServer
{
    public int Id { get; set; }

    public string? CardholderId { get; set; }

    public string? OptType { get; set; }

    public DateTime? AddDt { get; set; }
}

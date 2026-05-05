using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class TblSyncCommandLog
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public string? Action { get; set; }

    public string? Content { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpdDt { get; set; }

    public int? IsUpdate { get; set; }
}

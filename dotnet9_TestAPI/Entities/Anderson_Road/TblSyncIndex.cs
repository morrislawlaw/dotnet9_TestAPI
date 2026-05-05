using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class TblSyncIndex
{
    public int Id { get; set; }

    public string? Slave { get; set; }

    public string? TableName { get; set; }

    public long? SyncIndex { get; set; }
}

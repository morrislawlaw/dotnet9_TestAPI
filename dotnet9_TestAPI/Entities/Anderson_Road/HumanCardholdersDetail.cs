using System;
using System.Collections.Generic;

namespace dotnet9_TestAPI.Entities.Anderson_Road;

public partial class HumanCardholdersDetail
{
    public string CardholderId { get; set; } = null!;

    public string? ChnName { get; set; }

    public byte[]? FpData1 { get; set; }

    public byte[]? FpData2 { get; set; }

    public byte[]? PsData1 { get; set; }

    public byte[]? PsData2 { get; set; }

    public byte[]? EmpPhoto1 { get; set; }

    public byte[]? EmpPhoto2 { get; set; }

    public bool? EnableSendMailForRecords { get; set; }

    public bool? EnableSendMailForAttendance { get; set; }

    public long SyncIndex { get; set; }
}

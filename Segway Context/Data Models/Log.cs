using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Log
{
    public int RecId { get; set; }

    public string? Logfilename { get; set; }

    public string? Logtype { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? UserName { get; set; }

    public string? Unitserial { get; set; }

    public string? LogBuild { get; set; }

    public long? Unit { get; set; }

    public string? Channel { get; set; }

    public long? Odometer { get; set; }

    public long? Operatingtime { get; set; }

    public string? Version { get; set; }

    public string? LogData { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class RuntimeLog
{
    public int Id { get; set; }

    public string ToolName { get; set; } = null!;

    public string? ToolVersion { get; set; }

    public string? UserName { get; set; }

    public string? MachineName { get; set; }

    public string? LogName { get; set; }

    public int Row { get; set; }

    public DateTime? Timestamp { get; set; }

    public int? Counter { get; set; }

    public string? LogLevel { get; set; }

    public int Thread { get; set; }

    public string MethodName { get; set; } = null!;

    public string Message { get; set; } = null!;
}

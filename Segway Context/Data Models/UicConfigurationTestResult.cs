using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class UicConfigurationTestResult
{
    public int Id { get; set; }

    public string UnitIdSerialNumber { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public string? ScannedUicsid { get; set; }

    public string? ScannedFobsid { get; set; }

    public string? DatabaseUicsid { get; set; }

    public string? DatabaseFobsid { get; set; }

    public string? Status { get; set; }

    public string? Operator { get; set; }
}

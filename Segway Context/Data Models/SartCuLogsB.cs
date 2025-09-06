using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartCuLogsB
{
    public int Id { get; set; }

    public string? CuSerialEpic { get; set; }

    public string? CuSerial { get; set; }

    public string? PtSerial { get; set; }

    public string? WorkOrder { get; set; }

    public string? UserName { get; set; }

    public int? AccountId { get; set; }

    public string? CustomerId { get; set; }

    public string? Side { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? SwBuild { get; set; }

    public string? SwVersion { get; set; }

    public string? SwPartNumber { get; set; }

    public int? Odometer { get; set; }

    public int? OperatingTime { get; set; }

    public int? IsPrimary { get; set; }

    public string? LogData { get; set; }

    public DateTime? DateTimeExtracted { get; set; }

    public string? SartExtraction { get; set; }
}

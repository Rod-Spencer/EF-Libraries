using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BatteryV8Flash
{
    public int RecId { get; set; }

    public string BatterySerial { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string? RevisionBefore { get; set; }

    public string? RevisionAfter { get; set; }

    public int? FlashStatus { get; set; }

    public string UserName { get; set; } = null!;

    public string MachineName { get; set; } = null!;

    public string? LevelBefore { get; set; }

    public string? LevelAfter { get; set; }
}

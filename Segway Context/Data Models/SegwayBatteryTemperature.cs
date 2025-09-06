using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayBatteryTemperature
{
    public int Id { get; set; }

    public string BatterySerial { get; set; } = null!;

    public Guid BatteryReadId { get; set; }

    public int BlockNumber { get; set; }

    public double? Temperature { get; set; }
}

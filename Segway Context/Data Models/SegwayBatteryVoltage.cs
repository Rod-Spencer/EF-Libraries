using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayBatteryVoltage
{
    public int Id { get; set; }

    public string BatterySerial { get; set; } = null!;

    public Guid BatteryReadId { get; set; }

    public int CellNumber { get; set; }

    public double Voltage { get; set; }
}

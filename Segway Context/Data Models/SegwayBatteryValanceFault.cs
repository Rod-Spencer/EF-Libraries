using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayBatteryValanceFault
{
    public int Id { get; set; }

    public string BatterySerial { get; set; } = null!;

    public Guid BatteryReadId { get; set; }

    public int LogNumber { get; set; }

    public int LogCode { get; set; }
}

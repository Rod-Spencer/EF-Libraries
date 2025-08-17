using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayBatteryValanceFault
{
    public int Id { get; set; }

    public string BatterySerial { get; set; } = null!;

    public Guid BatteryReadId { get; set; }

    public int LogNumber { get; set; }

    public int LogCode { get; set; }
}

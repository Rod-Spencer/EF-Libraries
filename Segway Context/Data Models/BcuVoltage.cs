using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class BcuVoltage
{
    public decimal Id { get; set; }

    public decimal BatteryRecId { get; set; }

    public decimal CellNumber { get; set; }

    public double Voltage { get; set; }
}

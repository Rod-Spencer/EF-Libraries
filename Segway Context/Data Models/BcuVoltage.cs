using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BcuVoltage
{
    public decimal Id { get; set; }

    public decimal BatteryRecId { get; set; }

    public decimal CellNumber { get; set; }

    public double Voltage { get; set; }
}

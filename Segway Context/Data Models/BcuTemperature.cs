using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BcuTemperature
{
    public decimal Id { get; set; }

    public decimal BatteryRecId { get; set; }

    public decimal BlockNumber { get; set; }

    public double Temperature { get; set; }
}

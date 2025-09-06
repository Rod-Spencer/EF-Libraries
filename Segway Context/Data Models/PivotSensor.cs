using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PivotSensor
{
    public int RecId { get; set; }

    public string? PivotBaseSerialNumber { get; set; }

    public double SensorReadingValue { get; set; }

    public string? EnteredBy { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

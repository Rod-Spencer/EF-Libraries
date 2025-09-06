using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PivotSensorTemp
{
    public decimal? RecId { get; set; }

    public string? PivotBaseSerialNumber { get; set; }

    public decimal? SensorReadingValue { get; set; }

    public string? EnteredBy { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

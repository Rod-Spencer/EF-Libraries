using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Se3ThrottleCalibrationValue
{
    public int PlaId { get; set; }

    public int ThrottleZeroValue { get; set; }

    public int ThrottleMaxValue { get; set; }
}

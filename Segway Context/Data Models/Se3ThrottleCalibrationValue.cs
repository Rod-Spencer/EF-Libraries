using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Se3ThrottleCalibrationValue
{
    public int PlaId { get; set; }

    public int ThrottleZeroValue { get; set; }

    public int ThrottleMaxValue { get; set; }
}

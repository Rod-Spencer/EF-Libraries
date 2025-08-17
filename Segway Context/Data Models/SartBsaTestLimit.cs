using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartBsaTestLimit
{
    public Guid? Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public double? Pitch { get; set; }

    public double? Pitchvariance { get; set; }

    public double? Pitchcalibration { get; set; }

    public double? FrontPitchCalibration { get; set; }

    public double? RearPitchCalibration { get; set; }

    public double? Roll { get; set; }

    public double? Rollvariance { get; set; }

    public double? Rollcalibration { get; set; }

    public double? FrontRollCalibration { get; set; }

    public double? RearRollCalibration { get; set; }

    public TimeSpan? TestTimeout { get; set; }

    public TimeSpan? AcceptTime { get; set; }
}

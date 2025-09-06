using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class MotorNormRatioTest
{
    public int Id { get; set; }

    public int? TestId { get; set; }

    public string? SerialNumber { get; set; }

    public string? MotorId { get; set; }

    public string? BaseTest { get; set; }

    public string? Lt1Test { get; set; }

    public string? Lt2Test { get; set; }

    public string? Lt1Delta { get; set; }

    public string? Lt2Delta { get; set; }

    public string? BaseCriteria { get; set; }

    public string? Lt1Criteria { get; set; }

    public string? Lt2Criteria { get; set; }

    public string? Lt1DeltaCriteria { get; set; }

    public string? Lt2DeltaCriteria { get; set; }

    public string? TestType { get; set; }

    public DateTime? TestTime { get; set; }

    public string? SoftwareVersion { get; set; }
}

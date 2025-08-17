using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class RideTest
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? ProblemCode { get; set; }

    public string? OverallPassFail { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Tester { get; set; }
}

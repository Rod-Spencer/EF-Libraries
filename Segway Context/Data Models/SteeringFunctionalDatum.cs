using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SteeringFunctionalDatum
{
    public decimal? RecId { get; set; }

    public string? PivotBaseSerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? YawACenter { get; set; }

    public string? YawBCenter { get; set; }

    public string? YawALeftMidCw { get; set; }

    public string? YawBLeftMidCw { get; set; }

    public string? YawALeftMaxCw { get; set; }

    public string? YawBLeftMaxCw { get; set; }

    public string? MaxCwTorque { get; set; }

    public string? YawALeftRtcTimeCw { get; set; }

    public string? YawBLeftRtcTimeCw { get; set; }

    public string? YawARightMidCcw { get; set; }

    public string? YawBRightMidCcw { get; set; }

    public string? YawARightMaxCcw { get; set; }

    public string? YawBRightMaxCcw { get; set; }

    public string? MaxCcwTorque { get; set; }

    public string? YawARightRtcTimeCcw { get; set; }

    public string? YawBRightRtcTimeCcw { get; set; }

    public string? OverallPassFail { get; set; }
}

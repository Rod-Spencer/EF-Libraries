using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class FailureTrackingHdr
{
    public decimal? RecId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? FailureStationId { get; set; }

    public string? FailureCategory { get; set; }

    public string? FailureMessage { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? AnalysisNotes { get; set; }
}

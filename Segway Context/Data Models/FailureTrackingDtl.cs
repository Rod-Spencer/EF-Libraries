using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class FailureTrackingDtl
{
    public decimal? RecId { get; set; }

    public decimal? FailureTrackingHdrId { get; set; }

    public string? FailureSubcategory { get; set; }

    public string? FailureMessage { get; set; }

    public string? ComponentPartNumber { get; set; }

    public string? ComponentSerialNumber { get; set; }

    public string? ComponentLotNumber { get; set; }

    public string? AnalysisNotes { get; set; }
}

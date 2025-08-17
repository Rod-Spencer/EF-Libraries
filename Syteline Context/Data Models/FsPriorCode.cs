using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsPriorCode
{
    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? Datefld { get; set; }

    public string? DaysFollowup { get; set; }

    public string? DaysLate { get; set; }

    public string? DaysUntilWarning { get; set; }

    public double? Decifld1 { get; set; }

    public double? Decifld2 { get; set; }

    public double? Decifld3 { get; set; }

    public string? Description { get; set; }

    public byte? Logifld { get; set; }

    public string PriorCode { get; set; } = null!;

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public double? HrsFollowup { get; set; }

    public double? HrsLate { get; set; }

    public double? HrsUntilWarning { get; set; }

    public string LateBasis { get; set; } = null!;

    public string WarningBasis { get; set; } = null!;

    public string FollowupBasis { get; set; } = null!;
}

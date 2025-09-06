using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class FsPriorCode
{
    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? Datefld { get; set; }

    public short? DaysFollowup { get; set; }

    public short? DaysLate { get; set; }

    public short? DaysUntilWarning { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Description { get; set; }

    public byte? Logifld { get; set; }

    public string PriorCode { get; set; } = null!;

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid? RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public decimal? HrsFollowup { get; set; }

    public decimal? HrsLate { get; set; }

    public decimal? HrsUntilWarning { get; set; }

    public string LateBasis { get; set; } = null!;

    public string WarningBasis { get; set; } = null!;

    public string FollowupBasis { get; set; } = null!;
}

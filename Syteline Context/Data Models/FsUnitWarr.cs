using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsUnitWarr
{
    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public int CompId { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EndMeterAmt { get; set; }

    public byte? Logifld { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartMeterAmt { get; set; }

    public string WarrCode { get; set; } = null!;

    public decimal? WarrLaborPct { get; set; }

    public decimal? WarrMatlPct { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid? RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public int? OrigCompId { get; set; }
}

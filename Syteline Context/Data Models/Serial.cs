using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class Serial
{
    public string SerNum { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string? InvNum { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public byte? Logifld { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? RsvdNum { get; set; }

    public decimal? TransNum { get; set; }

    public string? TrnNum { get; set; }

    public short? TrnLine { get; set; }

    public string? Lot { get; set; }

    public string? Loc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? PurgeDate { get; set; }

    public DateTime? ExpDate { get; set; }

    public string? Stat { get; set; }

    public string? CertNum { get; set; }

    public string Whse { get; set; } = null!;

    public string? RefType { get; set; }

    public string? RefNum { get; set; }

    public short? RefLine { get; set; }

    public short? RefRelease { get; set; }

    public DateTime? ShipDate { get; set; }

    public short? DateSeq { get; set; }

    public string? DoNum { get; set; }

    public int? DoLine { get; set; }

    public short? DoSeq { get; set; }

    public string? GrnNum { get; set; }

    public short? GrnLine { get; set; }

    public string? VendNum { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate1 { get; set; }

    public byte InWorkflow { get; set; }

    public string? ImportDocId { get; set; }

    public string? ContainerNum { get; set; }
}

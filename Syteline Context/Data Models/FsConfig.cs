using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsConfig
{
    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public int CompId { get; set; }

    public string? CustItem { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Description { get; set; }

    public DateTime? InstallDate { get; set; }

    public string? Item { get; set; }

    public byte? Logifld { get; set; }

    public string? Lot { get; set; }

    public int? ParentId { get; set; }

    public string? SerNum { get; set; }

    public decimal? Qty { get; set; }

    public string? Reason { get; set; }

    public DateTime? RemoveDate { get; set; }

    public string? Revision { get; set; }

    public string? UM { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid? RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? RemSroNum { get; set; }

    public int? RemSroLine { get; set; }

    public int? RemSroOper { get; set; }

    public int? RemTransNum { get; set; }

    public string? InsSroNum { get; set; }

    public int? InsSroLine { get; set; }

    public int? InsSroOper { get; set; }

    public int? InsTransNum { get; set; }
}

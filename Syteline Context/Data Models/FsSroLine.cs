using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsSroLine
{
    public byte? AccumWip { get; set; }

    public string? BillCode { get; set; }

    public string? BillStat { get; set; }

    public string BillType { get; set; } = null!;

    public string? CgsRevLocLabor { get; set; }

    public string? CgsRevLocMatl { get; set; }

    public string? CgsRevLocMisc { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public string? Contract { get; set; }

    public int? ContLine { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? ExchDate { get; set; }

    public byte? ExtendMatlTrans { get; set; }

    public byte? ExtendLbrTrans { get; set; }

    public byte? ExtendMiscTrans { get; set; }

    public string? IncNum { get; set; }

    public string? Item { get; set; }

    public string? LineType { get; set; }

    public byte? Logifld { get; set; }

    public int? MaintSeq { get; set; }

    public int? MeterAmt { get; set; }

    public string? PartnerId { get; set; }

    public string? Pricecode { get; set; }

    public string? ProductCode { get; set; }

    public decimal? Qty { get; set; }

    public decimal? QtyConv { get; set; }

    public decimal? QtyIssued { get; set; }

    public decimal? QtyIssuedConv { get; set; }

    public decimal? QtyPacked { get; set; }

    public decimal? QtyReturned { get; set; }

    public decimal? QtyReturnedConv { get; set; }

    public decimal? QtyShipped { get; set; }

    public decimal? QtyShippedConv { get; set; }

    public int? RefLineSuf { get; set; }

    public string? RefNum { get; set; }

    public int? RefRelease { get; set; }

    public string? RefType { get; set; }

    public string? SerNum { get; set; }

    public int SroLine { get; set; }

    public string SroNum { get; set; } = null!;

    public string? SroType { get; set; }

    public string? Stat { get; set; }

    public byte? ToSchedule { get; set; }

    public decimal? TotalBilled { get; set; }

    public decimal? TotalCostLbr { get; set; }

    public decimal? TotalCostMatl { get; set; }

    public decimal? TotalCostMisc { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalSalesTax1 { get; set; }

    public decimal? TotalSalesTax2 { get; set; }

    public string? UM { get; set; }

    public byte? UseEst { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? Dept { get; set; }

    public DateTime? MeterDate { get; set; }

    public byte AwaitingParts { get; set; }

    public string? CustItem { get; set; }

    public decimal ObalLineMatl { get; set; }

    public string? InspectType { get; set; }

    public string? UfSegFsRepairType { get; set; }

    public DateTime? UfSegFsStartDate { get; set; }
}

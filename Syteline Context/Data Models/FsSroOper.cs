using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsSroOper
{
    public byte? AccumWip { get; set; }

    public string? BillCode { get; set; }

    public byte? BillHold { get; set; }

    public string? BillStat { get; set; }

    public string BillType { get; set; } = null!;

    public string? CgsRevLocLabor { get; set; }

    public string? CgsRevLocMatl { get; set; }

    public string? CgsRevLocMisc { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? CustNum { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Description { get; set; }

    public DateTime? EndDate { get; set; }

    public byte? ExtendMatlTrans { get; set; }

    public byte? ExtendLbrTrans { get; set; }

    public byte? ExtendMiscTrans { get; set; }

    public byte? Logifld { get; set; }

    public DateTime? OpenDate { get; set; }

    public string? OperCode { get; set; }

    public string? PartnerId { get; set; }

    public byte? PlanReq { get; set; }

    public string? Pricecode { get; set; }

    public string? ProductCode { get; set; }

    public int SroLine { get; set; }

    public string SroNum { get; set; } = null!;

    public int SroOper { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Stat { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public byte? ToSchedule { get; set; }

    public decimal? TotalBilled { get; set; }

    public decimal? TotalCostLbr { get; set; }

    public decimal? TotalCostMatl { get; set; }

    public decimal? TotalCostMisc { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalSalesTax1 { get; set; }

    public decimal? TotalSalesTax2 { get; set; }

    public byte? UseEst { get; set; }

    public string? Wc { get; set; }

    public string? Whse { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid? RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? SignOff { get; set; }

    public DateTime? SignOffDate { get; set; }

    public string? Inspector { get; set; }

    public decimal? Duration { get; set; }

    public string? DurationUnits { get; set; }

    public decimal? EstimatedTimeRemaining { get; set; }

    public string? EstimatedTimeRemainingUnits { get; set; }

    public string? Dept { get; set; }

    public byte InvProcessed { get; set; }

    public byte AwaitingParts { get; set; }

    public decimal Obal { get; set; }

    public decimal EstSalesTax1 { get; set; }

    public decimal EstSalesTax2 { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class Coitem
{
    public string CoNum { get; set; } = null!;

    public short CoLine { get; set; }

    public short CoRelease { get; set; }

    public string Item { get; set; } = null!;

    public decimal QtyOrdered { get; set; }

    public decimal QtyReady { get; set; }

    public decimal QtyShipped { get; set; }

    public decimal QtyPacked { get; set; }

    public decimal Disc { get; set; }

    public decimal Cost { get; set; }

    public decimal Price { get; set; }

    public string? RefType { get; set; }

    public string? RefNum { get; set; }

    public short? RefLineSuf { get; set; }

    public short? RefRelease { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public decimal BrkQty1 { get; set; }

    public decimal BrkQty2 { get; set; }

    public decimal BrkQty3 { get; set; }

    public decimal BrkQty4 { get; set; }

    public decimal BrkQty5 { get; set; }

    public byte Reprice { get; set; }

    public string? CustItem { get; set; }

    public decimal QtyInvoiced { get; set; }

    public decimal QtyReturned { get; set; }

    public decimal CgsTotal { get; set; }

    public string? FeatStr { get; set; }

    public string? Stat { get; set; }

    public string? CustNum { get; set; }

    public int? CustSeq { get; set; }

    public decimal? PrgBillTot { get; set; }

    public decimal? PrgBillApp { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public DateTime? PromiseDate { get; set; }

    public string? Whse { get; set; }

    public string? WksBasis { get; set; }

    public decimal? WksValue { get; set; }

    public string? CommCode { get; set; }

    public string? TransNat { get; set; }

    public string? ProcessInd { get; set; }

    public string? Delterm { get; set; }

    public decimal? UnitWeight { get; set; }

    public string? Origin { get; set; }

    public int? ConsNum { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public decimal? ExportValue { get; set; }

    public string? EcCode { get; set; }

    public string? Transport { get; set; }

    public DateTime? PickDate { get; set; }

    public string? Pricecode { get; set; }

    public string UM { get; set; } = null!;

    public decimal QtyOrderedConv { get; set; }

    public decimal PriceConv { get; set; }

    public string? CoCustNum { get; set; }

    public byte? Packed { get; set; }

    public byte? Bol { get; set; }

    public decimal QtyRsvd { get; set; }

    public decimal MatlCost { get; set; }

    public decimal LbrCost { get; set; }

    public decimal FovhdCost { get; set; }

    public decimal VovhdCost { get; set; }

    public decimal OutCost { get; set; }

    public decimal CgsTotalMatl { get; set; }

    public decimal CgsTotalLbr { get; set; }

    public decimal CgsTotalFovhd { get; set; }

    public decimal CgsTotalVovhd { get; set; }

    public decimal CgsTotalOut { get; set; }

    public decimal CostConv { get; set; }

    public decimal MatlCostConv { get; set; }

    public decimal LbrCostConv { get; set; }

    public decimal FovhdCostConv { get; set; }

    public decimal VovhdCostConv { get; set; }

    public decimal OutCostConv { get; set; }

    public string? ShipSite { get; set; }

    public byte? SyncReqd { get; set; }

    public string? CoOrigSite { get; set; }

    public string? CustPo { get; set; }

    public string? RmaNum { get; set; }

    public short? RmaLine { get; set; }

    public DateTime? ProjectedDate { get; set; }

    public byte Consolidate { get; set; }

    public string? InvFreq { get; set; }

    public byte Summarize { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? Description { get; set; }

    public string? ConfigId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string RcptRqmt { get; set; } = null!;

    public string? TransNat2 { get; set; }

    public decimal SupplQtyConvFactor { get; set; }

    public byte PrintKitComponents { get; set; }

    public DateTime? DueDateDay { get; set; }

    public string? ExternalReservationRef { get; set; }

    public string? FsIncNum { get; set; }

    public string? NonInvAcct { get; set; }

    public string? NonInvAcctUnit1 { get; set; }

    public string? NonInvAcctUnit2 { get; set; }

    public string? NonInvAcctUnit3 { get; set; }

    public string? NonInvAcctUnit4 { get; set; }

    public short? DaysShippedBeforeDueDateTolerance { get; set; }

    public short? DaysShippedAfterDueDateTolerance { get; set; }

    public decimal? ShippedOverOrderedQtyTolerance { get; set; }

    public decimal? ShippedUnderOrderedQtyTolerance { get; set; }

    public string? ManufacturerId { get; set; }

    public string? ManufacturerItem { get; set; }

    public short? Priority { get; set; }

    public byte InvoiceHold { get; set; }

    public string? UfSegColCustCareStatus { get; set; }

    public string? UfSegColFinStatus { get; set; }

    public string? UfSegColLineType { get; set; }

    public string? UfTermsCode { get; set; }
}

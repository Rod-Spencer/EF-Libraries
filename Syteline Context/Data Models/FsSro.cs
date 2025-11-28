using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpenSoft.EF.Syteline;

public partial class FsSro
{
    public byte? AccumWip { get; set; }

    public byte? AllowPartial { get; set; }

    public byte? ApplyOpenDeposits { get; set; }

    public string? BillCode { get; set; }

    public string? BillCustNum { get; set; }

    public int? BillCustSeq { get; set; }

    public string? BillMgr { get; set; }

    public string? BillStat { get; set; }

    public string? BillType { get; set; }

    public string? CgsRevLocLabor { get; set; }

    public string? CgsRevLocMatl { get; set; }

    public string? CgsRevLocMisc { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? CloseDate { get; set; }

    public byte CreditHold { get; set; }

    public DateTime? CreditHoldDate { get; set; }

    public string? CreditHoldReason { get; set; }

    public string? CreditHoldUser { get; set; }

    public string? CustNum { get; set; }

    public string? CustPo { get; set; }

    public int? CustSeq { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Delterm { get; set; }

    public decimal? DepositApplied { get; set; }

    public DateTime? DepositExp { get; set; }

    public decimal? DepositReceived { get; set; }

    public byte? DepositReq { get; set; }

    public decimal? DepositTotal { get; set; }

    public string? Description { get; set; }

    public decimal? Disc { get; set; }

    public decimal? DiscT { get; set; }

    public DateTime? EndDate { get; set; }

    public string? EndUserType { get; set; }

    public decimal? ExchRate { get; set; }

    public byte? ExtendMatlTrans { get; set; }

    public byte? ExtendLbrTrans { get; set; }

    public byte? ExtendMiscTrans { get; set; }

    public byte? FixedRate { get; set; }

    public decimal? Freight { get; set; }

    public decimal? FreightT { get; set; }

    public string? FrtTaxCode1 { get; set; }

    public string? FrtTaxCode2 { get; set; }

    public string? IncNum { get; set; }

    public byte? InclDemand { get; set; }

    public string? Item { get; set; }

    public byte? Logifld { get; set; }

    public decimal? MChargesT { get; set; }

    public DateTime? MaintDate { get; set; }

    public decimal? MaintDuration { get; set; }

    public int? MeterAmt { get; set; }

    public decimal? MiscCharges { get; set; }

    public string? MscTaxCode1 { get; set; }

    public string? MscTaxCode2 { get; set; }

    public DateTime? OpenDate { get; set; }

    public string? PartnerId { get; set; }

    public byte? PlanReq { get; set; }

    public string? Pricecode { get; set; }

    public string? ProcessInd { get; set; }

    public string? ProductCode { get; set; }

    public decimal? Qty { get; set; }

    public decimal? QtyConv { get; set; }

    public decimal? QtyPacked { get; set; }

    public decimal? QtyShipped { get; set; }

    public decimal? QtyShippedConv { get; set; }

    public int? RefLineSuf { get; set; }

    public string? RefNum { get; set; }

    public int? RefRelease { get; set; }

    public string? RefType { get; set; }

    public string? Region { get; set; }

    public string? ReimbMethod { get; set; }

    public decimal? SalesTax { get; set; }

    public decimal? SalesTax2 { get; set; }

    public decimal? SalesTaxT { get; set; }

    public decimal? SalesTaxT2 { get; set; }

    public byte SchedDownTime { get; set; }

    public string? SerNum { get; set; }

    public string? ShipCode { get; set; }

    public string? Shiftid { get; set; }

    public string? Slsman { get; set; }

    public string SroNum { get; set; } = null!;

    public string? SroStat { get; set; }

    public string? SroType { get; set; }

    public DateTime? StartDate { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public string? TermsCode { get; set; }

    public byte? ToSchedule { get; set; }

    public decimal? TotalBilled { get; set; }

    public decimal? TotalCostLbr { get; set; }

    public decimal? TotalCostMatl { get; set; }

    public decimal? TotalCostMisc { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalReimb { get; set; }

    public decimal? TotalSalesTax1 { get; set; }

    public decimal? TotalSalesTax2 { get; set; }

    public decimal? TotalVouchered { get; set; }

    public string? TransNat { get; set; }

    public string? UM { get; set; }

    public byte? UseEst { get; set; }

    public string? UsrNum { get; set; }

    public int? UsrSeq { get; set; }

    public string? VendNum { get; set; }

    public byte? WebView { get; set; }

    public string? Whse { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? FaxNum { get; set; }

    public string? Phone2 { get; set; }

    public string? DriversLicense { get; set; }

    public string? Ssn { get; set; }

    public string? Dept { get; set; }

    public string? RemoteId { get; set; }

    public DateTime? ProjectedDate { get; set; }

    public byte InvClose { get; set; }

    public string? PriorCode { get; set; }

    public string? StatCode { get; set; }

    public string? TxtMsgAddr { get; set; }

    public string? PagerAddr { get; set; }

    public decimal DiscMatl { get; set; }

    public decimal DiscLabor { get; set; }

    public decimal DiscMisc { get; set; }

    public byte AwaitingParts { get; set; }

    public string DropType { get; set; } = null!;

    public string? DropNum { get; set; }

    public int? DropSeq { get; set; }

    public decimal ObalFrtMsc { get; set; }

    public decimal EstSalesTax1 { get; set; }

    public decimal EstSalesTax2 { get; set; }

    public DateTime? InspFinalized { get; set; }

    public byte UfLrmIntegrate { get; set; }

    public byte? SegIsWarr { get; set; }

    [NotMapped]
    public string? TechnicianName { get; set; }

}

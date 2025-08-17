using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsSroMatl
{
    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? BillCode { get; set; }

    public int? BoSrcTrans { get; set; }

    public byte BillHold { get; set; }

    public string? BillStat { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public decimal? Cost { get; set; }

    public decimal? CostConv { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Dept { get; set; }

    public string? Description { get; set; }

    public decimal Disc { get; set; }

    public DateTime? ExchDate { get; set; }

    public string? ExpFovAcct { get; set; }

    public string? ExpFovAcctUnit1 { get; set; }

    public string? ExpFovAcctUnit2 { get; set; }

    public string? ExpFovAcctUnit3 { get; set; }

    public string? ExpFovAcctUnit4 { get; set; }

    public string? ExpLbrAcct { get; set; }

    public string? ExpLbrAcctUnit1 { get; set; }

    public string? ExpLbrAcctUnit2 { get; set; }

    public string? ExpLbrAcctUnit3 { get; set; }

    public string? ExpLbrAcctUnit4 { get; set; }

    public string? ExpMatlAcct { get; set; }

    public string? ExpMatlAcctUnit1 { get; set; }

    public string? ExpMatlAcctUnit2 { get; set; }

    public string? ExpMatlAcctUnit3 { get; set; }

    public string? ExpMatlAcctUnit4 { get; set; }

    public string? ExpOutAcct { get; set; }

    public string? ExpOutAcctUnit1 { get; set; }

    public string? ExpOutAcctUnit2 { get; set; }

    public string? ExpOutAcctUnit3 { get; set; }

    public string? ExpOutAcctUnit4 { get; set; }

    public string? ExpVovAcct { get; set; }

    public string? ExpVovAcctUnit1 { get; set; }

    public string? ExpVovAcctUnit2 { get; set; }

    public string? ExpVovAcctUnit3 { get; set; }

    public string? ExpVovAcctUnit4 { get; set; }

    public decimal? Extcost { get; set; }

    public decimal? Extprice { get; set; }

    public decimal? FovhdCost { get; set; }

    public decimal? FovhdCostConv { get; set; }

    public int? InvLine { get; set; }

    public string? InvNum { get; set; }

    public string? Item { get; set; }

    public decimal? LbrCost { get; set; }

    public decimal? LbrCostConv { get; set; }

    public string? LoanerWhse { get; set; }

    public string? LoanerLoc { get; set; }

    public string? Loc { get; set; }

    public byte? Logifld { get; set; }

    public string? Lot { get; set; }

    public decimal? MatlCost { get; set; }

    public decimal? MatlCostConv { get; set; }

    public decimal? MatlQty { get; set; }

    public decimal? MatlQtyConv { get; set; }

    public decimal? OutCost { get; set; }

    public decimal? OutCostConv { get; set; }

    public int? PackNum { get; set; }

    public int? PackSeq { get; set; }

    public string? PartnerId { get; set; }

    public int? PlanTrans { get; set; }

    public DateTime? PostDate { get; set; }

    public byte? Posted { get; set; }

    public decimal? Price { get; set; }

    public decimal? PriceConv { get; set; }

    public string? Pricecode { get; set; }

    public decimal? QtyBackOrder { get; set; }

    public decimal? QtyBackOrderConv { get; set; }

    public decimal? QtyPacked { get; set; }

    public decimal? QtyShipped { get; set; }

    public decimal? QtyShippedConv { get; set; }

    public int? RefLineSuf { get; set; }

    public string? RefNum { get; set; }

    public int? RefRelease { get; set; }

    public string? RefType { get; set; }

    public string? ReimbAcct { get; set; }

    public string? ReimbAcctUnit1 { get; set; }

    public string? ReimbAcctUnit2 { get; set; }

    public string? ReimbAcctUnit3 { get; set; }

    public string? ReimbAcctUnit4 { get; set; }

    public string? ReimbBatchId { get; set; }

    public byte? ReimbPartner { get; set; }

    public string? ReimbStat { get; set; }

    public decimal ReimbSalesTax { get; set; }

    public decimal? ReimburseDue { get; set; }

    public decimal? ReimbursePaid { get; set; }

    public string? RevAcct { get; set; }

    public string? RevAcctUnit1 { get; set; }

    public string? RevAcctUnit2 { get; set; }

    public string? RevAcctUnit3 { get; set; }

    public string? RevAcctUnit4 { get; set; }

    public byte? RtnToStock { get; set; }

    public string? SaleDsAcct { get; set; }

    public string? SaleDsAcctUnit1 { get; set; }

    public string? SaleDsAcctUnit2 { get; set; }

    public string? SaleDsAcctUnit3 { get; set; }

    public string? SaleDsAcctUnit4 { get; set; }

    public int? SroLine { get; set; }

    public string? SroNum { get; set; }

    public int? SroOper { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public byte? Teardown { get; set; }

    public DateTime? TransDate { get; set; }

    public int? TransNum { get; set; }

    public string? TransType { get; set; }

    public string Type { get; set; } = null!;

    public string? UM { get; set; }

    public string? UsageType { get; set; }

    public decimal? VovhdCost { get; set; }

    public decimal? VovhdCostConv { get; set; }

    public string? Whse { get; set; }

    public decimal? WipMatl { get; set; }

    public decimal? WipLbr { get; set; }

    public decimal? WipFov { get; set; }

    public decimal? WipVov { get; set; }

    public decimal? WipOut { get; set; }

    public decimal? WipRelMatl { get; set; }

    public decimal? WipRelLbr { get; set; }

    public decimal? WipRelFov { get; set; }

    public decimal? WipRelVov { get; set; }

    public decimal? WipRelOut { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? WipFovAcct { get; set; }

    public string? WipFovAcctUnit1 { get; set; }

    public string? WipFovAcctUnit2 { get; set; }

    public string? WipFovAcctUnit3 { get; set; }

    public string? WipFovAcctUnit4 { get; set; }

    public string? WipLbrAcct { get; set; }

    public string? WipLbrAcctUnit1 { get; set; }

    public string? WipLbrAcctUnit2 { get; set; }

    public string? WipLbrAcctUnit3 { get; set; }

    public string? WipLbrAcctUnit4 { get; set; }

    public string? WipMatlAcct { get; set; }

    public string? WipMatlAcctUnit1 { get; set; }

    public string? WipMatlAcctUnit2 { get; set; }

    public string? WipMatlAcctUnit3 { get; set; }

    public string? WipMatlAcctUnit4 { get; set; }

    public string? WipOutAcct { get; set; }

    public string? WipOutAcctUnit1 { get; set; }

    public string? WipOutAcctUnit2 { get; set; }

    public string? WipOutAcctUnit3 { get; set; }

    public string? WipOutAcctUnit4 { get; set; }

    public string? WipVovAcct { get; set; }

    public string? WipVovAcctUnit1 { get; set; }

    public string? WipVovAcctUnit2 { get; set; }

    public string? WipVovAcctUnit3 { get; set; }

    public string? WipVovAcctUnit4 { get; set; }

    public decimal? AppliedFovhdCost { get; set; }

    public decimal? AppliedVovhdCost { get; set; }

    public decimal? MatltranTransNum { get; set; }

    public byte InWorkflow { get; set; }

    public string? SignOff { get; set; }

    public DateTime? SignOffDate { get; set; }

    public string? BillMgr { get; set; }

    public DateTime? ReimbDate { get; set; }

    public string? ReasonCode { get; set; }

    public decimal? ExportValue { get; set; }

    public decimal? UnitWeight { get; set; }

    public string? CommCode { get; set; }

    public string? TransNat { get; set; }

    public string? ProcessInd { get; set; }

    public string? Delterm { get; set; }

    public string? Origin { get; set; }

    public string? EcCode { get; set; }

    public decimal? SupplyQty { get; set; }

    public int? ConsNum { get; set; }

    public Guid? SsdRefRowPointer { get; set; }

    public DateTime? ProjectedDate { get; set; }

    public decimal ReimburseAmt { get; set; }

    public string? CustItem { get; set; }

    public string DropType { get; set; } = null!;

    public string? DropNum { get; set; }

    public int? DropSeq { get; set; }

    public decimal Obal { get; set; }

    public decimal EstSalesTax1 { get; set; }

    public decimal EstSalesTax2 { get; set; }

    public string? ReimbTaxCode1 { get; set; }

    public string? ReimbTaxCode2 { get; set; }

    public byte? UfSegFsApproved { get; set; }

    public byte? UfSegFsInstalled { get; set; }

    public string? UfSegFsNewSerial { get; set; }

    public string? UfSegFsOldSerial { get; set; }

    public byte? UfSegFsRequired { get; set; }

    public string? UfSegServiceAct { get; set; }
}

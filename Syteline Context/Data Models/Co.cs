using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class Co
{
    public string? Type { get; set; }

    public string CoNum { get; set; } = null!;

    public string? EstNum { get; set; }

    public string? CustNum { get; set; }

    public int? CustSeq { get; set; }

    public string? Contact { get; set; }

    public string? Phone { get; set; }

    public string? CustPo { get; set; }

    public DateTime OrderDate { get; set; }

    public string? TakenBy { get; set; }

    public string? TermsCode { get; set; }

    public string? ShipCode { get; set; }

    public decimal? Price { get; set; }

    public decimal? Weight { get; set; }

    public short? QtyPackages { get; set; }

    public decimal? Freight { get; set; }

    public decimal? MiscCharges { get; set; }

    public decimal? PrepaidAmt { get; set; }

    public decimal? SalesTax { get; set; }

    public string? Stat { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? CloseDate { get; set; }

    public decimal? FreightT { get; set; }

    public decimal? MChargesT { get; set; }

    public decimal? PrepaidT { get; set; }

    public decimal? SalesTaxT { get; set; }

    public string? Slsman { get; set; }

    public DateTime? EffDate { get; set; }

    public DateTime? ExpDate { get; set; }

    public string? Whse { get; set; }

    public decimal? SalesTax2 { get; set; }

    public decimal? SalesTaxT2 { get; set; }

    public byte? EdiOrder { get; set; }

    public string? TransNat { get; set; }

    public string? ProcessInd { get; set; }

    public string? Delterm { get; set; }

    public byte? UseExchRate { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public string? FrtTaxCode1 { get; set; }

    public string? FrtTaxCode2 { get; set; }

    public string? MscTaxCode1 { get; set; }

    public string? MscTaxCode2 { get; set; }

    public string? DiscountType { get; set; }

    public decimal? DiscAmount { get; set; }

    public decimal? Disc { get; set; }

    public string? Pricecode { get; set; }

    public byte? ShipPartial { get; set; }

    public byte? ShipEarly { get; set; }

    public decimal? MatlCostT { get; set; }

    public decimal? LbrCostT { get; set; }

    public decimal? FovhdCostT { get; set; }

    public decimal? VovhdCostT { get; set; }

    public decimal? OutCostT { get; set; }

    public string? EndUserType { get; set; }

    public decimal? ExchRate { get; set; }

    public byte? FixedRate { get; set; }

    public string? OrigSite { get; set; }

    public string? LcrNum { get; set; }

    public string? EdiType { get; set; }

    public byte? Invoiced { get; set; }

    public byte? CreditHold { get; set; }

    public DateTime? CreditHoldDate { get; set; }

    public string? CreditHoldReason { get; set; }

    public string? CreditHoldUser { get; set; }

    public byte? SyncReqd { get; set; }

    public DateTime? ProjectedDate { get; set; }

    public string? OrderSource { get; set; }

    public string? ConvertType { get; set; }

    public byte? ApsPullUp { get; set; }

    public byte? Consolidate { get; set; }

    public string? InvFreq { get; set; }

    public byte? Summarize { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte? Einvoice { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public byte? Logifld { get; set; }

    public string? AckStat { get; set; }

    public string? ConfigId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public byte? IncludeTaxInPrice { get; set; }

    public string? TransNat2 { get; set; }

    public string? ApplyToInvNum { get; set; }

    public string ExportType { get; set; } = null!;

    public string? ExternalConfirmationRef { get; set; }

    public byte IsExternal { get; set; }

    public string? ProspectId { get; set; }

    public string? OppId { get; set; }

    public string? LeadId { get; set; }

    public short? DaysShippedBeforeDueDateTolerance { get; set; }

    public short? DaysShippedAfterDueDateTolerance { get; set; }

    public decimal? ShippedOverOrderedQtyTolerance { get; set; }

    public decimal? ShippedUnderOrderedQtyTolerance { get; set; }

    public byte Consignment { get; set; }

    public short? Priority { get; set; }

    public string? UfSegCustOrdLangKitType { get; set; }

    public byte? UfSegCoDirectSale { get; set; }

    public string? UfSegDealerNum { get; set; }

    public int? UfSegDealerSeq { get; set; }

    public decimal? UfSegCoPrepayAmt { get; set; }

    public string? UfSegCoPrepayRef { get; set; }

    public string? UfSegCoShopifyOrdNum { get; set; }
}

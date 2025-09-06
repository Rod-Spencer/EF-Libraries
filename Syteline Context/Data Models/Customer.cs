namespace SpenSoft.EF.Syteline;

public partial class Customer
{
    public string CustNum { get; set; } = null!;

    public int CustSeq { get; set; }

    public string? Contact1 { get; set; }

    public string? Contact2 { get; set; }

    public string? Contact3 { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    public string? CustType { get; set; }

    public string? TermsCode { get; set; }

    public string? ShipCode { get; set; }

    public string? Slsman { get; set; }

    public string? StateCycle { get; set; }

    public byte? FinChg { get; set; }

    public DateTime? LastInv { get; set; }

    public DateTime? LastPaid { get; set; }

    public decimal? SalesYtd { get; set; }

    public decimal? SalesLstYr { get; set; }

    public decimal? DiscYtd { get; set; }

    public decimal? DiscLstYr { get; set; }

    public DateTime? LastFinChg { get; set; }

    public decimal? SalesPtd { get; set; }

    public DateTime? CalcDate { get; set; }

    public short? NumPeriods { get; set; }

    public short? AvgDaysOs { get; set; }

    public int? NumInvoices { get; set; }

    public int? HistDaysOs { get; set; }

    public int? LargDaysOs { get; set; }

    public short? LastDaysOs { get; set; }

    public decimal? AvgBalOs { get; set; }

    public decimal? LargeBalOs { get; set; }

    public decimal? LastBalOs { get; set; }

    public string? Whse { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public byte? Logifld { get; set; }

    public DateTime? Datefld { get; set; }

    public string? TaxRegNum1 { get; set; }

    public string? BankCode { get; set; }

    public string? TaxRegNum2 { get; set; }

    public string? PayType { get; set; }

    public byte? EdiCust { get; set; }

    public string? BranchId { get; set; }

    public string? TransNat { get; set; }

    public string? Delterm { get; set; }

    public string? ProcessInd { get; set; }

    public byte? UseExchRate { get; set; }

    public string? TaxCode1 { get; set; }

    public string? TaxCode2 { get; set; }

    public string? Pricecode { get; set; }

    public byte? ShipEarly { get; set; }

    public byte? ShipPartial { get; set; }

    public string? LangCode { get; set; }

    public string? EndUserType { get; set; }

    public string? ShipSite { get; set; }

    public byte? LcrReqd { get; set; }

    public string? CustBank { get; set; }

    public byte? DraftPrintFlag { get; set; }

    public byte? RcvInternalEmail { get; set; }

    public string? CustomerEmailAddr { get; set; }

    public byte? SendCustomerEmail { get; set; }

    public byte? ApsPullUp { get; set; }

    public string? DoInvoice { get; set; }

    public byte? Consolidate { get; set; }

    public string? InvFreq { get; set; }

    public byte? Summarize { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte? Einvoice { get; set; }

    public decimal? OrderBal { get; set; }

    public decimal? PostedBal { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public Guid? CrmGuid { get; set; }

    public byte InWorkflow { get; set; }

    public byte PrintPackInv { get; set; }

    public byte OnePackInv { get; set; }

    public string InvCategory { get; set; } = null!;

    public byte? IncludeTaxInPrice { get; set; }

    public string? TransNat2 { get; set; }

    public byte? UseRevisionPayDays { get; set; }

    public byte? RevisionDay { get; set; }

    public DateTime? RevisionDayStartTime1 { get; set; }

    public DateTime? RevisionDayStartTime2 { get; set; }

    public DateTime? RevisionDayEndTime1 { get; set; }

    public DateTime? RevisionDayEndTime2 { get; set; }

    public byte? PayDay { get; set; }

    public DateTime? PayDayStartTime1 { get; set; }

    public DateTime? PayDayStartTime2 { get; set; }

    public DateTime? PayDayEndTime1 { get; set; }

    public DateTime? PayDayEndTime2 { get; set; }

    public string ExportType { get; set; } = null!;

    public byte ActiveForDataIntegration { get; set; }

    public byte ShowInShipToDropDownList { get; set; }

    public byte ShowInDropDownList { get; set; }

    public string? SicCode { get; set; }

    public int? NumberOfEmployees { get; set; }

    public decimal? CompanyRevenue { get; set; }

    public string? TerritoryCode { get; set; }

    public string? SalesTeamId { get; set; }

    public short? DaysShippedBeforeDueDateTolerance { get; set; }

    public short? DaysShippedAfterDueDateTolerance { get; set; }

    public decimal? ShippedOverOrderedQtyTolerance { get; set; }

    public decimal? ShippedUnderOrderedQtyTolerance { get; set; }

    public int DefaultShipTo { get; set; }

    public string? UfSegCustLangKitType { get; set; }

    public string? VrtxGeocode { get; set; }

    public byte IncludeOrdersInTaxRpt { get; set; }

    public decimal? ConstructiveSalePricePct { get; set; }

    public void Update(Contact_Info? contact)
    {
        this.Contact1 = contact?.Contact;
        this.Phone1 = contact?.Phone;
    }
}

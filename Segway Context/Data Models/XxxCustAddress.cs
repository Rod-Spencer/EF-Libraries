using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class XxxCustAddress
{
    public int Id { get; set; }

    public decimal CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerNumber { get; set; } = null!;

    public string SiteNumber { get; set; } = null!;

    public decimal PartySiteId { get; set; }

    public decimal LocationId { get; set; }

    public decimal PartyId { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? AddressStatus { get; set; }

    public string? Usage { get; set; }

    public string? UsageStatus { get; set; }

    public string? PrimaryFlag { get; set; }

    public string? PaymentTermOnUsageTab { get; set; }

    public string? PaymentTermBillToTab { get; set; }

    public string? SiteUseCode { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxReference { get; set; }

    public string? PartyName { get; set; }

    public string? PrimaryPhoneExtension { get; set; }

    public string? PrimaryPhoneNumber { get; set; }

    public string? PartyType { get; set; }

    public string? EmailAddress { get; set; }

    public string? PersonFirstName { get; set; }

    public string? PersonMiddleName { get; set; }

    public string? PersonLastName { get; set; }

    public string? PersonTitle { get; set; }

    public string? AddressKey { get; set; }

    public string? Contact { get; set; }

    public string? CareOf { get; set; }

    public string? Instructions { get; set; }

    public string? Addressee { get; set; }
}

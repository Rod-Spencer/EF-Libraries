using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SupportTicketDatum
{
    public Guid Id { get; set; }

    public string? TicketNumber { get; set; }

    public DateTime? DateForService { get; set; }

    public string? ContactChannel { get; set; }

    public string? ContactInformation { get; set; }

    public string? NameOfUser { get; set; }

    public string? Address { get; set; }

    public string? ClientsRequestType { get; set; }

    public string? Recorder { get; set; }

    public string? UserCountry { get; set; }

    public string? ProductName { get; set; }

    public string? ProductSubCategory { get; set; }

    public string? Complain { get; set; }

    public string? ErrorPhenomenon { get; set; }

    public string? CauseOfTheIssue { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? WarrantyStartTime { get; set; }

    public string? ResolutionInDetails { get; set; }

    public string? ResolutionReplacementCategory { get; set; }

    public string? KeySparePartsSn { get; set; }

    public bool? InWarrantyOrNot { get; set; }

    public string? Note { get; set; }

    public string? ExpressCompany { get; set; }

    public string? UnitOrign { get; set; }

    public string? ExpressTrackingNumber { get; set; }

    public decimal? ExpressFee { get; set; }

    public string? ExpressFeeCurrency { get; set; }
}

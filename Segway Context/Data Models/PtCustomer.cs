using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PtCustomer
{
    public int Id { get; set; }

    public int RecId { get; set; }

    public string? CustomerName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int Favorite { get; set; }

    public int Type { get; set; }

    public string? Username { get; set; }

    public int CustAccountId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public decimal? BillToSiteUseId { get; set; }

    public decimal? ShipToSiteUseId { get; set; }

    public decimal? DeliverToSiteUseId { get; set; }

    public int DealerId { get; set; }
}

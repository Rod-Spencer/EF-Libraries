using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class FredDatum
{
    public Guid? Id { get; set; }

    public string Serial { get; set; } = null!;

    public DateTime? Shipped { get; set; }

    public DateTime? Registered { get; set; }

    public string? Dealer { get; set; }

    public string? AffiliatedDealer { get; set; }

    public string? RegionString { get; set; }

    public string? PartNumber { get; set; }

    public int? CustomertypeInt { get; set; }

    public string? DealerId { get; set; }

    public string? DealerName { get; set; }

    public int? SarAccountId { get; set; }

    public string? SarCustAcct { get; set; }

    public int? RegDealerId { get; set; }

    public int? RegCustRecId { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? ShipType { get; set; }

    public string? ModelString { get; set; }
}

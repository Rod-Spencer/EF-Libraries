using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PtRegistration
{
    public int Id { get; set; }

    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public int PtCustomerId { get; set; }

    public int InfokeyProgrammerCustId { get; set; }

    public DateTime? SaleDate { get; set; }

    public DateTime? ShipDate { get; set; }

    public string? Username { get; set; }

    public decimal? IbInstanceId { get; set; }

    public decimal? OrderHeaderId { get; set; }

    public decimal? DeliveryDetailId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? Note { get; set; }
}

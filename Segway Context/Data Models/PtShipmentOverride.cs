using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtShipmentOverride
{
    public int RecId { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? Shipped { get; set; }

    public string? Customer { get; set; }

    public string? AffiliatedDealer { get; set; }

    public string? Region { get; set; }

    public string? Model { get; set; }
}

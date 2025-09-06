using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtShippingDate
{
    public string? Serial { get; set; }

    public string? Item { get; set; }

    public string? Shipped { get; set; }

    public DateTime? ShipDate { get; set; }
}

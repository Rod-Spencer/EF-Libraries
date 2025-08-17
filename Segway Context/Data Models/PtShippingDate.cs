using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PtShippingDate
{
    public string? Serial { get; set; }

    public string? Item { get; set; }

    public string? Shipped { get; set; }

    public DateTime? ShipDate { get; set; }
}

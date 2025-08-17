using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Key
{
    public string? ModelCode { get; set; }

    public string? SerialNumber { get; set; }

    public string? UserKey1 { get; set; }

    public string? UserKey2 { get; set; }

    public string? FleetKey { get; set; }

    public string? ServiceKey { get; set; }

    public string? Flash1 { get; set; }

    public string? Flash2 { get; set; }

    public string? Flash3 { get; set; }

    public string? Flash4 { get; set; }

    public string? FlashCuA { get; set; }

    public string? FlashCuB { get; set; }

    public DateTime? DateEntered { get; set; }

    public DateTime? DateKeyed { get; set; }
}

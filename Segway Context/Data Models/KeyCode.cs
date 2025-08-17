using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class KeyCode
{
    public int RecId { get; set; }

    public string? ProductPartNumber { get; set; }

    public string? ProductSerialNumber { get; set; }

    public string? UserKey1 { get; set; }

    public string? UserKey2 { get; set; }

    public string? FleetKey { get; set; }

    public string? ServiceKey { get; set; }

    public string? FlashCuA { get; set; }

    public string? FlashCuB { get; set; }

    public DateTime? DateEntered { get; set; }

    public DateTime? DateRekeyed { get; set; }

    public string? Rmp { get; set; }
}

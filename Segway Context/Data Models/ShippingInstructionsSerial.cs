using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ShippingInstructionsSerial
{
    public Guid Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int Ordinal { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? EnteredBy { get; set; }

    public string? PtSerial { get; set; }

    public string? FrontBattery { get; set; }

    public string? RearBattery { get; set; }
}

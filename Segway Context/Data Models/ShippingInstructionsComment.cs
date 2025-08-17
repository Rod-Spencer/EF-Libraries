using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ShippingInstructionsComment
{
    public Guid Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public string? EnteredBy { get; set; }

    public string? Comment { get; set; }
}

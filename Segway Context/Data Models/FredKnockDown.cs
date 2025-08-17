using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class FredKnockDown
{
    public string Serial { get; set; } = null!;

    public string? Dealer { get; set; }

    public DateTime? Shipped { get; set; }

    public DateTime? Assembled { get; set; }

    public DateTime? Registered { get; set; }

    public DateTime? Ridetested { get; set; }

    public Guid? RowId { get; set; }
}

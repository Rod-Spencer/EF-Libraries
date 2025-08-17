using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ManufacturingReasonLocation
{
    public int Id { get; set; }

    public string? LocationName { get; set; }

    public string Operator { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

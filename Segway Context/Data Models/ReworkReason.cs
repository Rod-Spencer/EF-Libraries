using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ReworkReason
{
    public int Id { get; set; }

    public string Location { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? Specialty { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class MiniProTrackingCode
{
    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? Sequence { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public Guid RowPointer { get; set; }
}

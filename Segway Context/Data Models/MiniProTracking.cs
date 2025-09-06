using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class MiniProTracking
{
    public string Incident { get; set; } = null!;

    public string TrackingCode { get; set; } = null!;

    public string? Comment { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public Guid RowPointer { get; set; }
}

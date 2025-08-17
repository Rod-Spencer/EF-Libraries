using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartEventLogEntry
{
    public int Id { get; set; }

    public int ObjectId { get; set; }

    public string? WorkOrder { get; set; }

    public DateTime? TimestampStart { get; set; }

    public DateTime? TimestampEnd { get; set; }

    public int Status { get; set; }

    public string? Message { get; set; }

    public string? ErrorDescription { get; set; }
}

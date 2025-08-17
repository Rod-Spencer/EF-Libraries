using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayServiceMonitorDataArchive
{
    public int Id { get; set; }

    public Guid Monitorkey { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Category { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? DatabaseName { get; set; }
}

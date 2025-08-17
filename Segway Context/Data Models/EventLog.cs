using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class EventLog
{
    public decimal? RecId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? PtSerialNumber { get; set; }

    public string? HostFolder { get; set; }

    public string? Filename { get; set; }

    public DateTime? FileTimestamp { get; set; }

    public decimal? FileSize { get; set; }

    public string? LogContents { get; set; }
}

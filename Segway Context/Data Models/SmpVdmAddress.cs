using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVdmAddress
{
    public decimal SequenceNum { get; set; }

    public string? Username { get; set; }

    public string? AppName { get; set; }

    public decimal? EnhancedNotification { get; set; }

    public string? Proxy { get; set; }

    public DateTime? Slotretrievaltime { get; set; }
}

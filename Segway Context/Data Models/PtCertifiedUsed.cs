using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PtCertifiedUsed
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

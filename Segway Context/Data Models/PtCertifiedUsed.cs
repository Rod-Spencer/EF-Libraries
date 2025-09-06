using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtCertifiedUsed
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

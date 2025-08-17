using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage2Pivot
{
    public decimal? RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? PivotBaseSerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

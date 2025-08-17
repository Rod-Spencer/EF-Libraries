using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage2Cover
{
    public decimal? RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? CoverLotCode { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

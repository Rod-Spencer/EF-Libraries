using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage1PartNumber
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartnumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

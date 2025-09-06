using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayReplacementAddress
{
    public int Id { get; set; }

    public string? DealerNum { get; set; }

    public int? DealerSeq { get; set; }

    public string? CustNum { get; set; }

    public int? CustSeq { get; set; }

    public string? UseAddress { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

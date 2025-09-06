using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Segs4VetsUnit
{
    public string SerNum { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string? CustNum { get; set; }

    public int? CustSeq { get; set; }

    public string? Name { get; set; }

    public string? CustType { get; set; }

    public int? Count { get; set; }
}

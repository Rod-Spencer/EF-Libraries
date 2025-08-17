using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class TableSize
{
    public string Owner { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public decimal? NumRows { get; set; }

    public decimal? AvgRowLen { get; set; }

    public decimal? Tsize { get; set; }
}

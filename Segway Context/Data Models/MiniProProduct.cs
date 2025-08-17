using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class MiniProProduct
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;
}

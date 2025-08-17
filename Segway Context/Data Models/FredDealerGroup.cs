using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class FredDealerGroup
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string DealerName { get; set; } = null!;

    public DateTime DateTimeEntered { get; set; }
}

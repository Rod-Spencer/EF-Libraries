using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayBatteryUserDatum
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int LastListLength { get; set; }

    public int LastSelectedId { get; set; }
}

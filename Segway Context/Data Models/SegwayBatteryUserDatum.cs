using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayBatteryUserDatum
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int LastListLength { get; set; }

    public int LastSelectedId { get; set; }
}

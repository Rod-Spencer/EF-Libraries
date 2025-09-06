using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayWarehouseLocation
{
    public int Id { get; set; }

    public string Warehouse { get; set; } = null!;

    public string Location { get; set; } = null!;
}

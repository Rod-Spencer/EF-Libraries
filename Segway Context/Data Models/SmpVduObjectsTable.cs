using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVduObjectsTable
{
    public decimal ObjectId { get; set; }

    public string Type { get; set; } = null!;

    public string Owner { get; set; } = null!;

    public string ObjectName { get; set; } = null!;
}

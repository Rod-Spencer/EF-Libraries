using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class AllowedUnitStatus
{
    public int Id { get; set; }

    public string? UnitStatus { get; set; }

    public string Classification { get; set; } = null!;
}

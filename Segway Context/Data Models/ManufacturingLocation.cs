using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ManufacturingLocation
{
    public string Location { get; set; } = null!;

    public string? Description { get; set; }

    public string? Account { get; set; }
}

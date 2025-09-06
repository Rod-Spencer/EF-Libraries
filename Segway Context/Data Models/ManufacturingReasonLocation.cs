using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ManufacturingReasonLocation
{
    public int Id { get; set; }

    public string? LocationName { get; set; }

    public string Operator { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

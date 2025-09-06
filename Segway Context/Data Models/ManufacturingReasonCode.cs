using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ManufacturingReasonCode
{
    public int Id { get; set; }

    public string? LocationName { get; set; }

    public string? ComponentType { get; set; }

    public string ReasonType { get; set; } = null!;

    public Guid? ReasonCode { get; set; }

    public string? Reason { get; set; }

    public string Operator { get; set; } = null!;

    public DateTime DateTimeEntered { get; set; }
}

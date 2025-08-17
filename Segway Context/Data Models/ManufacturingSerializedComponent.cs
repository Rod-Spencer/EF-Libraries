using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ManufacturingSerializedComponent
{
    public Guid Id { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string? ModelName { get; set; }

    public string? PartNumber { get; set; }

    public string? PartType { get; set; }

    public DateTime DateTimeCreated { get; set; }

    public string? Status { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }
}

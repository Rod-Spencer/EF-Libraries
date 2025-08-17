using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class InfoKeyErrorCode
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Category { get; set; }

    public string? Origin { get; set; }

    public string? Message { get; set; }

    public string? Translation { get; set; }

    public string? ActionLevel1 { get; set; }

    public string? ActionLevel2 { get; set; }

    public string? ActionLevel3 { get; set; }

    public bool? ServiceImmediate { get; set; }

    public bool? ServicePersists { get; set; }

    public bool? Restart { get; set; }

    public bool? Charge { get; set; }

    public string? Notes { get; set; }
}

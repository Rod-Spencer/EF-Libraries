using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayPartTypeXref
{
    public int Id { get; set; }

    public string? ServicePartNumber { get; set; }

    public int IsConfiguration { get; set; }

    public int IgnoreValidation { get; set; }

    public string? AssemblyPartNumber { get; set; }

    public string? AssemblyPartType { get; set; }

    public string? AssemblyModel { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

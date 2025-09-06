using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayPartNumberProductionXref
{
    public string? PartNumber { get; set; }

    public string? ProductionPartNumber { get; set; }

    public string? Type { get; set; }

    public string? FredClassification { get; set; }

    public Guid? ID { get; set; }
}

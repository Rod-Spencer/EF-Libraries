using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class CkdConversion
{
    public int Id { get; set; }

    public string? Serial { get; set; }

    public string? TopLevelItem { get; set; }

    public string? ManufacturingItem { get; set; }

    public bool? LabelPrinted { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

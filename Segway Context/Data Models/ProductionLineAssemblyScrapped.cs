using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ProductionLineAssemblyScrapped
{
    public int Id { get; set; }

    public string? SerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? ScrappedBy { get; set; }
}

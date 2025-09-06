using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SerialNumbersGenerated
{
    public int Id { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime DateTimeEntered { get; set; }

    public string? EnteredBy { get; set; }

    public string? PartNumber { get; set; }
}

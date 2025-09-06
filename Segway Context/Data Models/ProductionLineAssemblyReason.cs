using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ProductionLineAssemblyReason
{
    public int Id { get; set; }

    public int ReasonId { get; set; }

    public int ComponentId { get; set; }

    public string Operator { get; set; } = null!;

    public DateTime DateTimeEntered { get; set; }

    public string? ComponentSerial { get; set; }
}

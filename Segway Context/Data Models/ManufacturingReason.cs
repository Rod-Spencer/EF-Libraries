using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ManufacturingReason
{
    public int Id { get; set; }

    public Guid ReasonCode { get; set; }

    public string OldAssemblySerial { get; set; } = null!;

    public string? NewAssemblySerial { get; set; }

    public string? Action { get; set; }

    public string Operator { get; set; } = null!;

    public DateTime DateTimeEntered { get; set; }
}

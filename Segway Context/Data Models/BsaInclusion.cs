using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BsaInclusion
{
    public int Id { get; set; }

    public string BsaSerialNumber { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

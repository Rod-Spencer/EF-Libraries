using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BsaExclusion
{
    public int Id { get; set; }

    public string BsaSerialNumber { get; set; } = null!;

    public string? Status { get; set; }
}

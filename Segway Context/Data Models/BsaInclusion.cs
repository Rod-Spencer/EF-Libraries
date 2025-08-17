using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class BsaInclusion
{
    public int Id { get; set; }

    public string BsaSerialNumber { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

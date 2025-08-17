using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage1CuSecurity
{
    public int RecId { get; set; }

    public string? CuSerialNumber { get; set; }

    public string? CuJtagLock { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

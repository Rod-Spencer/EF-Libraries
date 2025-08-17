using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage1BsaSecurity
{
    public int RecId { get; set; }

    public string? BsaSerialNumber { get; set; }

    public string? BsaJtagLock { get; set; }

    public string? UserKeyCode { get; set; }

    public string? ServiceKeyCode { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

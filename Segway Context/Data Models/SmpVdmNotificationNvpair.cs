using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVdmNotificationNvpair
{
    public decimal? SequenceNum { get; set; }

    public string? Name { get; set; }

    public decimal? ValueLength { get; set; }

    public byte[]? Value { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SerialNumber
{
    public string Type { get; set; } = null!;

    public int Count { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public Guid? Id { get; set; }
}

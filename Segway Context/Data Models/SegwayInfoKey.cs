using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayInfoKey
{
    public Guid? Id { get; set; }

    public string CustNum { get; set; } = null!;

    public int Allowed { get; set; }

    public string? Serial1 { get; set; }

    public string? Serial2 { get; set; }

    public string? Serial3 { get; set; }

    public string? Serial4 { get; set; }

    public DateTime? Expiration { get; set; }
}

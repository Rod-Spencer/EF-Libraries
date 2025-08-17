using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayBatteryUserViewedNew
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public Guid BatteryReadId { get; set; }

    public string BatterySerial { get; set; } = null!;

    public DateTime? LastViewed { get; set; }
}

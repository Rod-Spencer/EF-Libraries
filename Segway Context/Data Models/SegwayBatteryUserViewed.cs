using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayBatteryUserViewed
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? BatteryNumber { get; set; }

    public int BatteryId { get; set; }

    public string BatterySerial { get; set; } = null!;

    public DateTime LastViewed { get; set; }

    public Guid? BatteryReadId { get; set; }

    public string? UserName { get; set; }
}

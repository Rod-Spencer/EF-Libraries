using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayServiceMonitorNotification
{
    public int Id { get; set; }

    public Guid NotificationKey { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? UserName { get; set; }
}

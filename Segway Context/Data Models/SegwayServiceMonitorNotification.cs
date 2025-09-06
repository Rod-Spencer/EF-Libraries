using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayServiceMonitorNotification
{
    public int Id { get; set; }

    public Guid NotificationKey { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? UserName { get; set; }
}

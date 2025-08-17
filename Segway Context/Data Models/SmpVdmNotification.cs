using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVdmNotification
{
    public decimal SequenceNum { get; set; }

    public decimal? NotificationId { get; set; }

    public decimal? NotificationType { get; set; }

    public decimal? Subtype { get; set; }

    public string? NodeName { get; set; }

    public string? ServiceName { get; set; }

    public string? ServiceType { get; set; }

    public decimal? TimeStamp { get; set; }

    public decimal? TimeZone { get; set; }

    public decimal? Verbose { get; set; }

    public string? Domain { get; set; }

    public decimal? NumClients { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVdmNotificationDetail
{
    public string? Name { get; set; }

    public decimal? Type { get; set; }

    public string? Target { get; set; }

    public decimal? Execnum { get; set; }

    public string? Owner { get; set; }

    public DateTime? TimeStamp { get; set; }

    public decimal? TimeZone { get; set; }

    public string? Method { get; set; }

    public decimal? Status { get; set; }

    public string? Message { get; set; }

    public decimal? OperationStatus { get; set; }
}

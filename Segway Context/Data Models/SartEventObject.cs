using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartEventObject
{
    public int Id { get; set; }

    public string? WorkOrderId { get; set; }

    public int EventType { get; set; }

    public DateTime? TimestampStart { get; set; }

    public DateTime? TimestampEnd { get; set; }

    public int Status { get; set; }

    public string? UserName { get; set; }

    public string? Description { get; set; }

    public string? EventTypeString { get; set; }

    public string? StatusString { get; set; }
}

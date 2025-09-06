using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartEvent
{
    public int Id { get; set; }

    public string WorkOrderId { get; set; } = null!;

    public int ObjectId { get; set; }

    public int ObjectType { get; set; }

    public string? Event { get; set; }

    public DateTime? Timestamp { get; set; }

    public int Status { get; set; }

    public string? UserName { get; set; }

    public string? Message { get; set; }

    public string? StatusString { get; set; }
}

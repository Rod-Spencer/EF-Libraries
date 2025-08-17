using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ManufacturingSerializedComponentEvent
{
    public Guid Id { get; set; }

    public string ParentSerial { get; set; } = null!;

    public string? EventType { get; set; }

    public string? EventData { get; set; }

    public DateTime DateTimeCreated { get; set; }

    public DateTime? DateTimeRemoved { get; set; }

    public string? CreatedBy { get; set; }

    public string? RemovedBy { get; set; }

    public string? Site { get; set; }

    public string? WorkOrder { get; set; }
}

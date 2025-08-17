using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ManufacturingSerializedAssembly
{
    public Guid Id { get; set; }

    public string ParentSerial { get; set; } = null!;

    public string ChildSerial { get; set; } = null!;

    public string? PartType { get; set; }

    public string? Position { get; set; }

    public DateTime DateTimeCreated { get; set; }

    public DateTime? DateTimeRemoved { get; set; }

    public string? CreatedBy { get; set; }

    public string? RemovedBy { get; set; }

    public string? Site { get; set; }

    public string? WorkOrder { get; set; }
}

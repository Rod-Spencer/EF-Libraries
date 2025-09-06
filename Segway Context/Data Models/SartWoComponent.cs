using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartWoComponent
{
    public int Id { get; set; }

    public string? WorkOrderId { get; set; }

    public int Sequence { get; set; }

    public string? PartNumber { get; set; }

    public string? PartName { get; set; }

    public string? SerialNumberOld { get; set; }

    public string? SerialNumberNew { get; set; }

    public string? Quantity { get; set; }

    public string? Warranty { get; set; }

    public string? ChangeType { get; set; }

    public string? ChangeApproval { get; set; }

    public string? BillableCode { get; set; }

    public string? Installed { get; set; }

    public string? UnitOfMeasure { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public Guid Rowpointer { get; set; }

    public string? Location { get; set; }

    public string? ServiceCode { get; set; }
}

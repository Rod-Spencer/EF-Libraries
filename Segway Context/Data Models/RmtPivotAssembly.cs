using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class RmtPivotAssembly
{
    public int Id { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string PartNumber { get; set; } = null!;

    public string PartType { get; set; } = null!;

    public string? Status { get; set; }

    public string? Technician { get; set; }

    public string? OpenedBy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? Sensor { get; set; }

    public bool? BoardsAssigned { get; set; }

    public bool? StressTests { get; set; }
}

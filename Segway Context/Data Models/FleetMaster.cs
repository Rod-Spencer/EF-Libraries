using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class FleetMaster
{
    public decimal? RecId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? SerialNumber { get; set; }

    public string? FleetIdNumber { get; set; }

    public string? ModelNumber { get; set; }

    public string? Status { get; set; }

    public string? OwnerDepartment { get; set; }

    public string? UnitDescription { get; set; }

    public string? UnitLocation { get; set; }

    public string? ResponsiblePerson { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class FleetReservation
{
    public decimal? RecId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? ModelNumber { get; set; }

    public string? OwnerDepartment { get; set; }

    public DateTime? ReservationStartDate { get; set; }

    public DateTime? ReservationEndDate { get; set; }

    public string? ResponsibleDepartment { get; set; }

    public string? ResponsiblePerson { get; set; }

    public string? RequiredSetup { get; set; }

    public string? ReservationStatus { get; set; }

    public string? SerialNumber { get; set; }
}

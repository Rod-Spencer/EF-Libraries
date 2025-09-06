using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class FleetTransaction
{
    public decimal? RecId { get; set; }

    public decimal? HeaderId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? TransactionType { get; set; }

    public string? TransactionStatus { get; set; }

    public DateTime? ShippedDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? ExpectedReceiptDate { get; set; }

    public DateTime? ReservationStartDate { get; set; }

    public DateTime? ReservationEndDate { get; set; }

    public string? ResponsibleDepartment { get; set; }

    public string? ResponsiblePerson { get; set; }

    public string? CompanyName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? ContactName { get; set; }

    public string? ContactPhone { get; set; }

    public string? UsageNotes { get; set; }

    public string? AsShippedDescription { get; set; }

    public string? AsReceivedDescription { get; set; }
}

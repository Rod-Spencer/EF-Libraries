using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.SegwayProduction;

public partial class ValenceBatteryMaster
{
    public int RecId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public DateTime? ValenceManufactureDate { get; set; }

    public string? ValenceNumber { get; set; }

    public string? BatterySerialNumber { get; set; }

    public string? PartNumber { get; set; }

    public DateTime? ValenceShipDate { get; set; }

    public string? ValenceFileName { get; set; }

    public string? UnderWarrantyYn { get; set; }

    public string? CustomerName { get; set; }

    public DateTime? FailureNotificationDate { get; set; }

    public string? FailureReason { get; set; }

    public string? FailureNotes { get; set; }

    public string? ServiceRequestNumber { get; set; }

    public string? FailureUser { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? ReceiptLocation { get; set; }

    public string? ReceiptNotes { get; set; }

    public string? ReceiptUser { get; set; }

    public DateTime? RmaRequestDate { get; set; }

    public string? RmaRequestUser { get; set; }

    public DateTime? NcmDate { get; set; }

    public string? ValenceRmaNumber { get; set; }

    public DateTime? ValenceRmaDate { get; set; }

    public string? FailureBatteryLocation { get; set; }

    public DateTime? WarrantyEndDate { get; set; }

    public string? SegLotId { get; set; }

    public DateTime? SegShipDate { get; set; }

    public int SegWarrMonths { get; set; }

    public DateTime? SegWarrEndDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte NoteExistsFlag { get; set; }

    public byte InWorkflow { get; set; }
}

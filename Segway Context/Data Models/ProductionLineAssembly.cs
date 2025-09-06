using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ProductionLineAssembly
{
    public int Id { get; set; }

    public string? SerialNumber { get; set; }

    public string? Model { get; set; }

    public string? PartType { get; set; }

    public string? PartNumber { get; set; }

    public int? ParentId { get; set; }

    public string? ParentSerial { get; set; }

    public int? MasterId { get; set; }

    public string? MasterSerial { get; set; }

    public int? ReplacesId { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Location { get; set; }

    public int Stage1Id { get; set; }

    public int? OriginalId { get; set; }

    public int? OriginalParent { get; set; }

    public int? OriginalMaster { get; set; }

    public string? Site { get; set; }

    public string? Code { get; set; }

    public string? WorkOrder { get; set; }
}

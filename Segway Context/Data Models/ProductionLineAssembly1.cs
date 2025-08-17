using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ProductionLineAssembly1
{
    public decimal Id { get; set; }

    public string? SerialNumber { get; set; }

    public string? Model { get; set; }

    public string? PartType { get; set; }

    public string? PartNumber { get; set; }

    public decimal? ParentId { get; set; }

    public decimal? MasterId { get; set; }

    public decimal? ReplacesId { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Location { get; set; }

    public decimal Stage1Id { get; set; }

    public decimal? OriginalId { get; set; }

    public decimal? OriginalParent { get; set; }

    public decimal? OriginalMaster { get; set; }

    public string? ParentSerial { get; set; }

    public string? MasterSerial { get; set; }

    public string? Site { get; set; }

    public string? Code { get; set; }

    public string? WorkOrder { get; set; }
}

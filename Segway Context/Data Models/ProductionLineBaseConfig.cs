using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ProductionLineBaseConfig
{
    public decimal ProdlineRecId { get; set; }

    public string ParentSerialNumber { get; set; } = null!;

    public decimal ParentInventoryItemId { get; set; }

    public decimal ParentInvOrgId { get; set; }

    public string? ComponentSerialNumber { get; set; }

    public decimal ComponentInvItemId { get; set; }

    public decimal ComponentInvOrgId { get; set; }

    public string? ComponentStatus { get; set; }

    public DateTime? ActiveStartDate { get; set; }

    public DateTime? ActiveEndDate { get; set; }

    public string EnteredBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }
}

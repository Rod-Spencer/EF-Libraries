using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class MdtDetail
{
    public decimal? RecId { get; set; }

    public decimal? MdtId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public decimal? InventoryItemId { get; set; }

    public string? Revision { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ItemCost { get; set; }

    public string? SubinventoryCode { get; set; }

    public string? Comments { get; set; }
}

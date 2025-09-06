using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtOpenOrder
{
    public int RecId { get; set; }

    public DateTime? Today { get; set; }

    public string? Dealer { get; set; }

    public string? AffiliatedDealer { get; set; }

    public string? Region { get; set; }

    public int OrderNumber { get; set; }

    public int LineNumber { get; set; }

    public string? Model { get; set; }

    public int Count { get; set; }
}

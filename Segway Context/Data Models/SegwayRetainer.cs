using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayRetainer
{
    public Guid Id { get; set; }

    public DateTime DateTimeEntered { get; set; }

    public string Item { get; set; } = null!;

    public string? Description { get; set; }

    public string CustNum { get; set; } = null!;

    public double? Amount { get; set; }

    public string? Comment { get; set; }

    public string? TransactionId { get; set; }

    public string? SerialNumber { get; set; }
}

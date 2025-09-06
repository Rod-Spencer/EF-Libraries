using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVddOperationsTable
{
    public decimal RequestId { get; set; }

    public string RequestSubtype { get; set; } = null!;

    public string RequestType { get; set; } = null!;

    public string Target { get; set; } = null!;

    public string Node { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? Owner { get; set; }

    public string? Callback { get; set; }

    public decimal? Timestamp { get; set; }

    public string? Outgoing { get; set; }

    public decimal SequenceNum { get; set; }
}

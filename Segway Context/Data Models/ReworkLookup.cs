using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ReworkLookup
{
    public decimal? RecId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? LookupType { get; set; }

    public string? LookupValue { get; set; }

    public string? LookupDescription { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public string? Attribute3 { get; set; }

    public string? Attribute4 { get; set; }

    public string? Attribute5 { get; set; }
}

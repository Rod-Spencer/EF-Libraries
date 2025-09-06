using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayDealerAccountXref
{
    public int Id { get; set; }

    public string AccountId { get; set; } = null!;

    public string AlternateId { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

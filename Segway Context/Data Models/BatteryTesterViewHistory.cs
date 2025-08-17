using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class BatteryTesterViewHistory
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? PtSerialNumber { get; set; }

    public string? BatterySerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public Guid BatteryTestIdentifier { get; set; }
}

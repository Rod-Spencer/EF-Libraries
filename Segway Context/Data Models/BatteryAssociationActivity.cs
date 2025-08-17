using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class BatteryAssociationActivity
{
    public int Id { get; set; }

    public string VehicleSerial { get; set; } = null!;

    public string VehiclePartNumber { get; set; } = null!;

    public string? Battery1Serial { get; set; }

    public string? Battery2Serial { get; set; }

    public string Activity { get; set; } = null!;

    public DateTime DateTimeEntered { get; set; }

    public string CreatedBy { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class RmtPtAssembly
{
    public int Id { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string PartNumber { get; set; } = null!;

    public string PartType { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string? Status { get; set; }

    public string? Technician { get; set; }

    public string? OpenedBy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public bool? Engrave { get; set; }

    public bool? MotorsInstall { get; set; }

    public bool? GearboxInstall { get; set; }

    public bool? BsaInstall { get; set; }

    public bool? CuInstall { get; set; }

    public bool? CodeLoaded { get; set; }

    public bool? MotorTests { get; set; }

    public bool? BsaTest { get; set; }

    public bool? CoverPlate { get; set; }

    public bool? RiderDetectTest { get; set; }

    public bool? PivotInstall { get; set; }

    public bool? RadioProgrammed { get; set; }

    public bool? LedTest { get; set; }

    public bool? FobProgrammed { get; set; }

    public bool? FendersInstall { get; set; }

    public bool? WheelsInstall { get; set; }

    public bool? RideTest { get; set; }

    public bool? BatteryCharge { get; set; }

    public bool? Controller { get; set; }

    public bool? AvailableForSale { get; set; }

    public bool? Sold { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayBattery
{
    public int Id { get; set; }

    public Guid BatteryReadId { get; set; }

    public string BatteryManufacturer { get; set; } = null!;

    public string BatterySerialNumber { get; set; } = null!;

    public string BatteryPartNumber { get; set; } = null!;

    public string PackRevisionNumber { get; set; } = null!;

    public string MfgrLineNumber { get; set; } = null!;

    public string? MfgrSerialNumber { get; set; }

    public string? MfgrPartNumber { get; set; }

    public TimeSpan? MfgrTimestamp { get; set; }

    public string CellChemistry { get; set; } = null!;

    public int HazardFlags { get; set; }

    public double NominalCellVoltage { get; set; }

    public int FaultFlags { get; set; }

    public double PackCurrent { get; set; }

    public double PackVoltage { get; set; }

    public double CellDifferential { get; set; }

    public string ChargeProcessStatus { get; set; } = null!;

    public double PackTemperature { get; set; }

    public double StateOfEnergy { get; set; }

    public double StateOfCharge { get; set; }

    public double StateOfPower { get; set; }

    public int UndervoltageIndicator { get; set; }

    public int OvervoltageIndicator { get; set; }

    public int ManufacturedPackSize { get; set; }

    public int EffectivePackSize { get; set; }

    public string SoftwareRevisionNumber { get; set; } = null!;

    public string SoftwarePartNumber { get; set; } = null!;

    public string BootLoaderPartNumber { get; set; } = null!;

    public string BootLoaderRevisionNumber { get; set; } = null!;

    public string CalibrationPartNumber { get; set; } = null!;

    public string CalibrationRevisionNumber { get; set; } = null!;

    public string? FirmwarePartNumber { get; set; }

    public string? FirmwareRevisionNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? Location { get; set; }

    public string? Status { get; set; }

    public int Invalid { get; set; }

    public string? SessionName { get; set; }

    public string? WorkOrderId { get; set; }

    public string? UnitSerialNumber { get; set; }

    public string? UserName { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BatteryOperationalDatum
{
    public int Id { get; set; }

    public int RecId { get; set; }

    public string BcuSerialNumber { get; set; } = null!;

    public string? PartNumber { get; set; }

    public string? PackRevNumber { get; set; }

    public double PackCurrent { get; set; }

    public double PackVoltage { get; set; }

    public double PackTemperature { get; set; }

    public int UndervoltageIndicator { get; set; }

    public int OvervoltageIndicator { get; set; }

    public int ChargeProcessStatus { get; set; }

    public int StateOfEnergy { get; set; }

    public int StateOfCharge { get; set; }

    public int StateOfPower { get; set; }

    public int HazardFlags { get; set; }

    public int FaultFlags { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? Location { get; set; }

    public DateTime? ManufactureDate { get; set; }

    public string? Status { get; set; }

    public int Invalid { get; set; }

    public string? SoftwareRevNumber { get; set; }

    public string? SoftwarePartNumber { get; set; }

    public string? BootLoaderPartNumber { get; set; }

    public string? BootLoaderRevNumber { get; set; }

    public string? CalibrationPartNumber { get; set; }

    public string? CalibrationRevNumber { get; set; }

    public string? CellChemistry { get; set; }

    public string? SessionName { get; set; }

    public string? WorkOrderNumber { get; set; }
}

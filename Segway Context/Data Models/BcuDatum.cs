using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class BcuDatum
{
    public int Id { get; set; }

    public int RecId { get; set; }

    public string BcuSerialNumber { get; set; } = null!;

    public string? PartNumber { get; set; }

    public string? PackRevNumber { get; set; }

    public double CellVoltage0 { get; set; }

    public double CellVoltage1 { get; set; }

    public double CellVoltage2 { get; set; }

    public double CellVoltage3 { get; set; }

    public double CellVoltage4 { get; set; }

    public double CellVoltage5 { get; set; }

    public double CellVoltage6 { get; set; }

    public double CellVoltage7 { get; set; }

    public double CellVoltage8 { get; set; }

    public double CellVoltage9 { get; set; }

    public double CellVoltage10 { get; set; }

    public double CellVoltage11 { get; set; }

    public double CellVoltage12 { get; set; }

    public double CellVoltage13 { get; set; }

    public double CellVoltage14 { get; set; }

    public double CellVoltage15 { get; set; }

    public double CellVoltage16 { get; set; }

    public double CellVoltage17 { get; set; }

    public double CellVoltage18 { get; set; }

    public double CellVoltage19 { get; set; }

    public double CellVoltage20 { get; set; }

    public double CellVoltage21 { get; set; }

    public double CellVoltage22 { get; set; }

    public double CellTemperature0 { get; set; }

    public double CellTemperature1 { get; set; }

    public double CellTemperature2 { get; set; }

    public double CellTemperature3 { get; set; }

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
}

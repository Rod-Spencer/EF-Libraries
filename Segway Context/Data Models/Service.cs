using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Service
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeServiced { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Motor1SerialNumber { get; set; }

    public string? Motor2SerialNumber { get; set; }

    public string? Gearbox1SerialNumber { get; set; }

    public string? Gearbox2SerialNumber { get; set; }

    public string? PivotBaseSerialNumber { get; set; }

    public string? ConsolePsupplySerialNumber { get; set; }

    public string? ConsoleRadioSid { get; set; }

    public string? CuAPartNumber { get; set; }

    public string? CuASerialNumber { get; set; }

    public string? CuASwVersion { get; set; }

    public string? CuBPartNumber { get; set; }

    public string? CuBSerialNumber { get; set; }

    public string? CuBSwVersion { get; set; }

    public string? BsaAPartNumber { get; set; }

    public string? BsaASerialNumber { get; set; }

    public string? BsaASwVersion { get; set; }

    public string? BsaBPartNumber { get; set; }

    public string? BsaBSerialNumber { get; set; }

    public string? BsaBSwVersion { get; set; }

    public string? UiPartNumber { get; set; }

    public string? UiSerialNumber { get; set; }

    public string? UiSwVersion { get; set; }

    public string? OverallPassFail { get; set; }

    public string? PropulsionTestStatus { get; set; }

    public string? InertialTestStatus { get; set; }

    public string? BatteryChargeTestStatus { get; set; }

    public string? RiderDetectStatus { get; set; }

    public string? ConsoleLedTestStatus { get; set; }

    public string? MagneticOnOffTestStatus { get; set; }

    public string? UicCurrentDrainTestStatus { get; set; }
}

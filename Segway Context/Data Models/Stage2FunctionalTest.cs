using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage2FunctionalTest
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeTested { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? WirelessCommToConsole { get; set; }

    public string? ConsoleConfigValidation { get; set; }

    public string? RiderDetectOperation { get; set; }

    public string? LedOperation { get; set; }

    public string? SpeakerOperation { get; set; }

    public string? BatteryCharging { get; set; }

    public string? UnitIdStoredInConsole { get; set; }

    public string? UicRadioConfig { get; set; }

    public string? FobRadioConfig { get; set; }

    public string? UnitFobStartupAfterBinding { get; set; }

    public string? CuALogFormatted { get; set; }

    public string? CuBLogFormatted { get; set; }

    public string? BsaABlackBoxFormatted { get; set; }

    public string? BsaBBlackBoxFormatted { get; set; }

    public string? OverallPassFail { get; set; }

    public string? EmbeddedSoftwareFaultStatus { get; set; }

    public string? CurrentDrainSideA { get; set; }

    public string? CurrentDrainSideB { get; set; }

    public int? TestId { get; set; }

    public string? BatteryLedOperation { get; set; }
}

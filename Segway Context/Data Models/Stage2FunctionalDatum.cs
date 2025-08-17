using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage2FunctionalDatum
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeTested { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? NumRiderDetectSwitches { get; set; }

    public string? LLedGreenOnFdbk { get; set; }

    public string? LLedRedOnFdbk { get; set; }

    public string? LLedOffFdbk { get; set; }

    public string? RLedGreenOnFdbk { get; set; }

    public string? RLedRedOnFdbk { get; set; }

    public string? RLedOffFdbk { get; set; }

    public string? TopLedGreenOnFdbk { get; set; }

    public string? TopLedRedOnFdbk { get; set; }

    public string? TopLedOffFdbk { get; set; }

    public string? BotLedGreenOnFdbk { get; set; }

    public string? BotLedRedOnFdbk { get; set; }

    public string? BotLedOffFdbk { get; set; }

    public string? MidLedGreenOnFdbk { get; set; }

    public string? MidLedRedOnFdbk { get; set; }

    public string? MidLedOffFdbk { get; set; }

    public string? SpeakerOnFdbk { get; set; }

    public string? SpeakerOffFdbk { get; set; }

    public string? CuAEmbeddedFaultStat { get; set; }

    public string? CuBEmbeddedFaultStat { get; set; }

    public string? BatChrgCurrentSideA { get; set; }

    public string? BatChrgCurrentSideB { get; set; }

    public string? BatChrgVoltageSideA { get; set; }

    public string? BatChrgVoltageSideB { get; set; }

    public string? BatChrgTopLedGreenFdbk { get; set; }

    public string? BatChrgBotLedGreenFdbk { get; set; }

    public string? BatChrgTopLedRedFdbk { get; set; }

    public string? BatChrgBotLedRedFdbk { get; set; }

    public string? CurrentDrainSideA { get; set; }

    public string? CurrentDrainSideB { get; set; }

    public int? TestId { get; set; }
}

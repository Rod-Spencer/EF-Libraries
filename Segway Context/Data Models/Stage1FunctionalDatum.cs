using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage1FunctionalDatum
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeTested { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? TiltPosATiltX { get; set; }

    public string? TiltPosATiltY { get; set; }

    public string? TiltPosBTiltX { get; set; }

    public string? TiltPosBTiltY { get; set; }

    public string? OlAmp1OffSpeedA { get; set; }

    public string? OlAmp1OffSpeedB { get; set; }

    public string? OlAmp1OffCurrentA { get; set; }

    public string? OlAmp1OffCurrentB { get; set; }

    public string? OlAmp1LowSpeedA { get; set; }

    public string? OlAmp1LowSpeedB { get; set; }

    public string? OlAmp1LowCurrentA { get; set; }

    public string? OlAmp1LowCurrentB { get; set; }

    public string? OlAmp1HighSpeedA { get; set; }

    public string? OlAmp1HighSpeedB { get; set; }

    public string? OlAmp1HighCurrentA { get; set; }

    public string? OlAmp1HighCurrentB { get; set; }

    public string? OlAmp1NegLowSpeedA { get; set; }

    public string? OlAmp1NegLowSpeedB { get; set; }

    public string? OlAmp1NegLowCurrentA { get; set; }

    public string? OlAmp1NegLowCurrentB { get; set; }

    public string? OlAmp1NegHighSpeedA { get; set; }

    public string? OlAmp1NegHighSpeedB { get; set; }

    public string? OlAmp1NegHighCurrentA { get; set; }

    public string? OlAmp1NegHighCurrentB { get; set; }

    public string? OlAmp2OffSpeedA { get; set; }

    public string? OlAmp2OffSpeedB { get; set; }

    public string? OlAmp2OffCurrentA { get; set; }

    public string? OlAmp2OffCurrentB { get; set; }

    public string? OlAmp2LowSpeedA { get; set; }

    public string? OlAmp2LowSpeedB { get; set; }

    public string? OlAmp2LowCurrentA { get; set; }

    public string? OlAmp2LowCurrentB { get; set; }

    public string? OlAmp2HighSpeedA { get; set; }

    public string? OlAmp2HighSpeedB { get; set; }

    public string? OlAmp2HighCurrentA { get; set; }

    public string? OlAmp2HighCurrentB { get; set; }

    public string? OlAmp2NegLowSpeedA { get; set; }

    public string? OlAmp2NegLowSpeedB { get; set; }

    public string? OlAmp2NegLowCurrentA { get; set; }

    public string? OlAmp2NegLowCurrentB { get; set; }

    public string? OlAmp2NegHighSpeedA { get; set; }

    public string? OlAmp2NegHighSpeedB { get; set; }

    public string? OlAmp2NegHighCurrentA { get; set; }

    public string? OlAmp2NegHighCurrentB { get; set; }

    public string? ClMotorLOffSpeedA { get; set; }

    public string? ClMotorLOffSpeedB { get; set; }

    public string? ClMotorLOffVoltA { get; set; }

    public string? ClMotorLOffVoltB { get; set; }

    public string? ClMotorLLowSpeedA { get; set; }

    public string? ClMotorLLowSpeedB { get; set; }

    public string? ClMotorLLowVoltA { get; set; }

    public string? ClMotorLLowVoltB { get; set; }

    public string? ClMotorLHighSpeedA { get; set; }

    public string? ClMotorLHighSpeedB { get; set; }

    public string? ClMotorLHighVoltA { get; set; }

    public string? ClMotorLHighVoltB { get; set; }

    public string? ClMotorLNegLowSpeedA { get; set; }

    public string? ClMotorLNegLowSpeedB { get; set; }

    public string? ClMotorLNegLowVoltA { get; set; }

    public string? ClMotorLNegLowVoltB { get; set; }

    public string? ClMotorLNegHighSpeedA { get; set; }

    public string? ClMotorLNegHighSpeedB { get; set; }

    public string? ClMotorLNegHighVoltA { get; set; }

    public string? ClMotorLNegHighVoltB { get; set; }

    public string? ClMotorROffSpeedA { get; set; }

    public string? ClMotorROffSpeedB { get; set; }

    public string? ClMotorROffVoltA { get; set; }

    public string? ClMotorROffVoltB { get; set; }

    public string? ClMotorRLowSpeedA { get; set; }

    public string? ClMotorRLowSpeedB { get; set; }

    public string? ClMotorRLowVoltA { get; set; }

    public string? ClMotorRLowVoltB { get; set; }

    public string? ClMotorRHighSpeedA { get; set; }

    public string? ClMotorRHighSpeedB { get; set; }

    public string? ClMotorRHighVoltA { get; set; }

    public string? ClMotorRHighVoltB { get; set; }

    public string? ClMotorRNegLowSpeedA { get; set; }

    public string? ClMotorRNegLowSpeedB { get; set; }

    public string? ClMotorRNegLowVoltA { get; set; }

    public string? ClMotorRNegLowVoltB { get; set; }

    public string? ClMotorRNegHighSpeedA { get; set; }

    public string? ClMotorRNegHighSpeedB { get; set; }

    public string? ClMotorRNegHighVoltA { get; set; }

    public string? ClMotorRNegHighVoltB { get; set; }

    public string? OlAmp1LowNormRatioA { get; set; }

    public string? OlAmp1LowNormRatioB { get; set; }

    public string? OlAmp1NegLowNormRatioA { get; set; }

    public string? OlAmp1NegLowNormRatioB { get; set; }

    public string? OlAmp2LowNormRatioA { get; set; }

    public string? OlAmp2LowNormRatioB { get; set; }

    public string? OlAmp2NegLowNormRatioA { get; set; }

    public string? OlAmp2NegLowNormRatioB { get; set; }

    public string? CuAEmbeddedFaultStatus { get; set; }

    public string? CuBEmbeddedFaultStatus { get; set; }

    public decimal? TestId { get; set; }

    public string? ArsData1 { get; set; }

    public string? ArsData2 { get; set; }

    public string? ArsData3 { get; set; }

    public string? ArsData4 { get; set; }

    public string? ArsData5 { get; set; }

    public string? CuB72vMeas { get; set; }
}

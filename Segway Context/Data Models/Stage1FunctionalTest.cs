using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Stage1FunctionalTest
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeTested { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? CuACanCommunication { get; set; }

    public string? CuBCanCommunication { get; set; }

    public string? CuAConfigurationValidation { get; set; }

    public string? CuBConfigurationValidation { get; set; }

    public string? BsaConfigurationValidation { get; set; }

    public string? CuAProductCodeFlashed { get; set; }

    public string? CuBProductCodeFlashed { get; set; }

    public string? BsaProductCodeFlashed { get; set; }

    public string? BsaUserKeyFlashed { get; set; }

    public string? BsaJtagLockFlashed { get; set; }

    public string? TiltPosition { get; set; }

    public string? OlTestAmp1OffA { get; set; }

    public string? OlTestAmp1LowA { get; set; }

    public string? OlTestAmp1HighA { get; set; }

    public string? OlTestAmp1NegLowA { get; set; }

    public string? OlTestAmp1NegHighA { get; set; }

    public string? OlTestAmp2OffA { get; set; }

    public string? OlTestAmp2LowA { get; set; }

    public string? OlTestAmp2HighA { get; set; }

    public string? OlTestAmp2NegLowA { get; set; }

    public string? OlTestAmp2NegHighA { get; set; }

    public string? OlTestAmp1OffB { get; set; }

    public string? OlTestAmp1LowB { get; set; }

    public string? OlTestAmp1HighB { get; set; }

    public string? OlTestAmp1NegLowB { get; set; }

    public string? OlTestAmp1NegHighB { get; set; }

    public string? OlTestAmp2OffB { get; set; }

    public string? OlTestAmp2LowB { get; set; }

    public string? OlTestAmp2HighB { get; set; }

    public string? OlTestAmp2NegLowB { get; set; }

    public string? OlTestAmp2NegHighB { get; set; }

    public string? ClTestMotorLOff { get; set; }

    public string? ClTestMotorLLow { get; set; }

    public string? ClTestMotorLHigh { get; set; }

    public string? ClTestMotorLNegLow { get; set; }

    public string? ClTestMotorLNegHigh { get; set; }

    public string? ClTestMotorROff { get; set; }

    public string? ClTestMotorRLow { get; set; }

    public string? ClTestMotorRHigh { get; set; }

    public string? ClTestMotorRNegLow { get; set; }

    public string? ClTestMotorRNegHigh { get; set; }

    public string? Amp1NormRatioA { get; set; }

    public string? Amp1NegNormRatioA { get; set; }

    public string? Amp2NormRatioA { get; set; }

    public string? Amp2NegNormRatioA { get; set; }

    public string? Amp1NormRatioB { get; set; }

    public string? Amp1NegNormRatioB { get; set; }

    public string? Amp2NormRatioB { get; set; }

    public string? Amp2NegNormRatioB { get; set; }

    public string? EmbeddedSoftwareFaultStatus { get; set; }

    public string? OverallPassFail { get; set; }

    public decimal? TestId { get; set; }

    public string? ArsStableResult { get; set; }

    public string? CuB72v { get; set; }
}

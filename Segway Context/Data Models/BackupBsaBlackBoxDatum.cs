using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BackupBsaBlackBoxDatum
{
    public int Id { get; set; }

    public Guid HeaderKey { get; set; }

    public int Record { get; set; }

    public short? AdjustedFrameCount { get; set; }

    public short? FrameCount { get; set; }

    public short? StateBits { get; set; }

    public short? ControllerFlags { get; set; }

    public short? SkTestWord1 { get; set; }

    public short? SkTestWord2 { get; set; }

    public short? SkTestWord3 { get; set; }

    public short? PseInfoBits { get; set; }

    public short? PitchAngle { get; set; }

    public short? PitchRate { get; set; }

    public short? RollAngle { get; set; }

    public short? YawRate { get; set; }

    public short? LeftWheelSpeed { get; set; }

    public short? RightWheelSpeed { get; set; }

    public short? SteeringCommand { get; set; }

    public short? Vbus { get; set; }

    public short? BridgeCurrent { get; set; }

    public short? LeftMotorIq { get; set; }

    public short? RightMotorIq { get; set; }

    public short? LeftMotorVq { get; set; }

    public short? RightMotorVq { get; set; }

    public short? CurrentLimit { get; set; }

    public short? DesiredPitchOffset { get; set; }

    public short? SpeedLimit { get; set; }

    public short? SteeringReduction { get; set; }

    public short? DesiredYawCommand { get; set; }

    public short? PitchCommand { get; set; }

    public short? YawCommand { get; set; }

    public short? ShakeCommand { get; set; }

    public short? LeftTractionCommand { get; set; }

    public short? RightTractionCommand { get; set; }

    public short? Ars0 { get; set; }

    public short? Ars1 { get; set; }

    public short? Ars2 { get; set; }

    public short? Ars3 { get; set; }

    public short? Ars4 { get; set; }

    public short? LocalPitchAcc { get; set; }

    public short? LocalRollAcc { get; set; }

    public short? LocalSteeringSensor { get; set; }

    public short? AccTemperature { get; set; }

    public short? EntryCrc { get; set; }

    public short? CrcIsValid { get; set; }
}

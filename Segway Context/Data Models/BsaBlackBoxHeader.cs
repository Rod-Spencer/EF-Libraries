using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BsaBlackBoxHeader
{
    public int Id { get; set; }

    public Guid BlackboxKey { get; set; }

    public Guid HeaderKey { get; set; }

    public int Log { get; set; }

    public int? CuSoftwareVersion { get; set; }

    public int? BsaSoftwareVersion { get; set; }

    public int? OperationTime { get; set; }

    public short? DataLogVersion { get; set; }

    public short? RawVoc { get; set; }

    public short? RawRbat { get; set; }

    public short? FrameCount { get; set; }

    public short? FaultWord1 { get; set; }

    public short? FaultWord2 { get; set; }

    public short? FaultWord3 { get; set; }

    public short? FaultWord4 { get; set; }

    public short? PseStatusWord { get; set; }

    public short? BsaLocalCommFaults { get; set; }

    public short? BsaLocalSensorFaults { get; set; }

    public short? BsaLocalModuleFaults { get; set; }

    public short? BsaRemoteCommFaults { get; set; }

    public short? BsaRemoteSensorFaults { get; set; }

    public short? BsaRemoteModuleFaults { get; set; }

    public int? PsefAzeromean { get; set; }

    public int? PsefBzeromean { get; set; }

    public short? RecordIndex { get; set; }

    public short? Crc { get; set; }

    public bool IsCrcOk { get; set; }
}

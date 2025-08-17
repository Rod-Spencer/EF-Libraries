using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class InfoKeyConfigUsage
{
    public int RecId { get; set; }

    public string? UserName { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Action { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? FobWid { get; set; }

    public string? UicWid { get; set; }

    public string? FobSid { get; set; }

    public string? FobSidPrefix { get; set; }

    public string? CryptoKey { get; set; }

    public string? RiderKey { get; set; }

    public string? FobPartNumber { get; set; }

    public string? FobSerialNumber { get; set; }

    public DateTime? MfgDate { get; set; }

    public string? ChannelSelection { get; set; }

    public string? SoftwareVersion { get; set; }

    public string? SoftwarePartNumber { get; set; }

    public string? SpeedLimitBeginner { get; set; }

    public string? SpeedLimitExpert { get; set; }

    public string? ShutDownTimeout { get; set; }

    public string? FobConfigFlags { get; set; }

    public int? Checksum { get; set; }

    public bool? IsStolen { get; set; }

    public string? MachineName { get; set; }

    public int? FixtureSerialNumber { get; set; }

    public string? MachineLogin { get; set; }

    public bool? IsInternal { get; set; }

    public string? IkptVersionNumber { get; set; }

    public string? OperatingSystem { get; set; }

    public bool? Is64bit { get; set; }

    public string? IkptSerialNumber { get; set; }
}

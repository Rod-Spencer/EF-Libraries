using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class GenTestInfo
{
    public string? TestId { get; set; }

    public string? TestDate { get; set; }

    public string? ProductSerialNumber { get; set; }

    public string? ProductPartNumber { get; set; }

    public string? ConfigurationFileName { get; set; }

    public string? CuAPartNum { get; set; }

    public string? CuASerialNum { get; set; }

    public string? CuBPartNum { get; set; }

    public string? CuBSerialNum { get; set; }

    public string? UiPartNum { get; set; }

    public string? UiSerialNum { get; set; }

    public string? ImuPartNum { get; set; }

    public string? ImuSerialNum { get; set; }

    public string? BcuAPartNum { get; set; }

    public string? BcuADateCode { get; set; }

    public string? BcuBPartNum { get; set; }

    public string? BcuBDateCode { get; set; }

    public string? TesterDllVersion { get; set; }

    public string? TesterInterfaceVersion { get; set; }

    public string? LoginName { get; set; }

    public string? TotalTestDurationSec { get; set; }

    public string? OperatorTimeSec { get; set; }

    public string? ProgramTimeSec { get; set; }

    public string? CuASwRev { get; set; }

    public string? CuBSwRev { get; set; }

    public string? UiASwRev { get; set; }

    public string? UiBSwRev { get; set; }

    public string? ImuASwRev { get; set; }

    public string? ImuBSwRev { get; set; }

    public string? BcuASwRev { get; set; }

    public string? BcuBSwRev { get; set; }

    public string? DutATestSwRev { get; set; }

    public string? DutBTestSwRev { get; set; }

    public DateTime? DateEntered { get; set; }

    public string? FirstTest { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Stage2FunctionalInfo
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeTested { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? TestConfigurationFileName { get; set; }

    public string? UiPartNumber { get; set; }

    public string? UiSerialNumber { get; set; }

    public string? UiSwVersion { get; set; }

    public string? G2iDllSwVersion { get; set; }

    public string? MutSwVersion { get; set; }

    public string? G2iDbDllSwVersion { get; set; }

    public string? CimioDllSwVersion { get; set; }

    public string? OperatorLoginName { get; set; }

    public string? TotalTestDurationSeconds { get; set; }

    public string? FirstTest { get; set; }

    public int? TestId { get; set; }

    public string? G2stSwVersion { get; set; }
}

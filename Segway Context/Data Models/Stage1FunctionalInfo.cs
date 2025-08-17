using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Stage1FunctionalInfo
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeTested { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? TestConfigurationFileName { get; set; }

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

    public string? G2iDllSwVersion { get; set; }

    public string? MutSwVersion { get; set; }

    public string? G2iDbDllSwVersion { get; set; }

    public string? CimioDllSwVersion { get; set; }

    public string? OperatorLoginName { get; set; }

    public string? TotalTestDurationSeconds { get; set; }

    public string? FirstTest { get; set; }

    public decimal? TestId { get; set; }

    public string? G2stSwVersion { get; set; }
}

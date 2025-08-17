using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Rework
{
    public decimal? RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public DateTime? DateTimeServiced { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Motor1SerialNumber { get; set; }

    public string? Motor2SerialNumber { get; set; }

    public string? Gearbox1SerialNumber { get; set; }

    public string? Gearbox2SerialNumber { get; set; }

    public string? ConsolePsupplySerialNumber { get; set; }

    public string? PivotBaseSerialNumber { get; set; }

    public string? ConsoleRadioSid { get; set; }

    public string? CuASerialNumber { get; set; }

    public string? CuBSerialNumber { get; set; }

    public string? BsaASerialNumber { get; set; }

    public string? BsaBSerialNumber { get; set; }

    public string? CoverLotCode { get; set; }
}

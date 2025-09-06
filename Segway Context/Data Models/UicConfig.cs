using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class UicConfig
{
    public int RecId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? PtSerialNumber { get; set; }

    public string? UicSerialNumber { get; set; }

    public string? UicSid { get; set; }

    public string? FobSerialNumber { get; set; }

    public string? PivotSerialNumber { get; set; }

    public string? RadioBoardSerialNumber { get; set; }
}

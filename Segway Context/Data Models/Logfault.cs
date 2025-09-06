using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Logfault
{
    public decimal? RecId { get; set; }

    public decimal? LogId { get; set; }

    public decimal? Lognumber { get; set; }

    public decimal? Islinked { get; set; }

    public decimal? Timeafterpower { get; set; }

    public decimal? Operatingtime { get; set; }

    public decimal? Odometer { get; set; }

    public decimal? Hazards { get; set; }

    public decimal? Comm { get; set; }

    public decimal? Sensorlocal { get; set; }

    public decimal? Sensorremote { get; set; }

    public decimal? Actuatorlocal { get; set; }

    public decimal? Actuatorremote { get; set; }

    public decimal? Tsw1 { get; set; }

    public decimal? Tsw2 { get; set; }

    public decimal? Tsw3 { get; set; }

    public decimal? GpStatus1 { get; set; }

    public decimal? GpStatus2 { get; set; }

    public decimal? GpStatus3 { get; set; }

    public decimal? GpStatus4 { get; set; }

    public string? LogData { get; set; }
}

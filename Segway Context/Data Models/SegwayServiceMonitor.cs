using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayServiceMonitor
{
    public int Id { get; set; }

    public Guid Monitorkey { get; set; }

    public DateTime Timestamp { get; set; }

    public int? ServerDown { get; set; }

    public int? ServiceDown { get; set; }

    public int? WebserviceDown { get; set; }

    public int? DatabaseDown { get; set; }
}

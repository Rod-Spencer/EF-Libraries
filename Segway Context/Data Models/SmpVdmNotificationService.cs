using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVdmNotificationService
{
    public string ServiceType { get; set; } = null!;

    public string Nodename { get; set; } = null!;

    public string? Ior { get; set; }

    public DateTime? TimeStamp { get; set; }
}

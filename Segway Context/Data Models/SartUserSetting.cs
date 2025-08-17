using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartUserSetting
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public int? DefaultDisclaimer { get; set; }

    public int? BackgroundBase { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public int DelayWakeStart { get; set; }

    public int TimeoutStartApplet { get; set; }

    public int TimeoutStartAppletResponse { get; set; }

    public string? SartSettingsName { get; set; }
}

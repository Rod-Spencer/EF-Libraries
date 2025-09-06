using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartSetting
{
    public string? Name { get; set; }

    public Guid Id { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public int DelayDiagnosticWakeup { get; set; }

    public int DelayFullStop { get; set; }

    public int DelayLedtestWakeup { get; set; }

    public int DelayWakeStart { get; set; }

    public int? DelayWakeStartWireless { get; set; }

    public int TimeoutBsaSpiEnterBoot { get; set; }

    public int TimeoutEnterDiagnosticMode { get; set; }

    public int TimeoutHeartbeat { get; set; }

    public int TimeoutRamp { get; set; }

    public int TimeoutStartApplet { get; set; }

    public int TimeoutStartAppletResponse { get; set; }

    public int TimeoutWatchVariables { get; set; }

    public int TimeoutAppletReady { get; set; }

    public int MotorRampIncrement { get; set; }
}

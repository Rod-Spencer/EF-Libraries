using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartRideTest
{
    public int Id { get; set; }

    public string WorkOrder { get; set; } = null!;

    public string PtSerial { get; set; } = null!;

    public bool PowerOn { get; set; }

    public bool BalanceOn { get; set; }

    public bool Stationary { get; set; }

    public bool AxisRight { get; set; }

    public bool AxisLeft { get; set; }

    public bool Accelerate { get; set; }

    public bool Decelerate { get; set; }

    public bool BalanceOff { get; set; }

    public bool PowerOff { get; set; }

    public DateTime DateTimeEntered { get; set; }

    public DateTime DateTimeUpdated { get; set; }
}

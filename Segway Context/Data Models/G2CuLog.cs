using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class G2CuLog
{
    public int Id { get; set; }

    public string LogFileName { get; set; } = null!;

    public string LogType { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public string UserName { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public string LogBuild { get; set; } = null!;

    public int Unit { get; set; }

    public string Channel { get; set; } = null!;

    public int Odometer { get; set; }

    public int OperatingTime { get; set; }

    public string Version { get; set; } = null!;

    public bool PrimaryLog { get; set; }

    public string LogData { get; set; } = null!;
}

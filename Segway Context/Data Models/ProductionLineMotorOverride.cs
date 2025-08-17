using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ProductionLineMotorOverride
{
    public string SerialNumber { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string MessageType { get; set; } = null!;
}

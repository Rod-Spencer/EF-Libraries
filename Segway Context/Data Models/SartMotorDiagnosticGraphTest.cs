using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartMotorDiagnosticGraphTest
{
    public int Id { get; set; }

    public Guid TestKey { get; set; }

    public string CustomerId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string WorkOrder { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public string RunId { get; set; } = null!;
}

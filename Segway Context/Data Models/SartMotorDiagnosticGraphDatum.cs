using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartMotorDiagnosticGraphDatum
{
    public int Id { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? CustomerId { get; set; }

    public string? UserName { get; set; }

    public string? WorkOrder { get; set; }

    public string? SerialNumber { get; set; }

    public string? RunId { get; set; }

    public string? TestName { get; set; }

    public string? TestComponent { get; set; }

    public int? TestRun { get; set; }

    public Guid? GraphKey { get; set; }

    public Guid? TestKey { get; set; }
}

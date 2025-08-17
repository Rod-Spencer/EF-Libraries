using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartMotorDiagnosticDatum
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

    public string? CuaLeft { get; set; }

    public string? CubLeft { get; set; }

    public string? CuaRight { get; set; }

    public string? CubRight { get; set; }

    public string? MaxLimit { get; set; }

    public string? MinLimit { get; set; }

    public Guid? DataKey { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class EpicSerialValidation
{
    public int Id { get; set; }

    public string? SerialNumber { get; set; }

    public string? Status { get; set; }

    public string? Comments { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? Station { get; set; }

    public string? Location { get; set; }

    public string? Fixture { get; set; }

    public string? Firstfail { get; set; }

    public string? Testbench { get; set; }

    public string? Epicstatus { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Microsoftdtproperty
{
    public decimal Id { get; set; }

    public decimal? Objectid { get; set; }

    public string Property { get; set; } = null!;

    public string? Value { get; set; }

    public byte[]? Lvalue { get; set; }

    public decimal Version { get; set; }
}

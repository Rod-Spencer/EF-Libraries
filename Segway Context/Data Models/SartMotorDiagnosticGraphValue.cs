using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartMotorDiagnosticGraphValue
{
    public int Id { get; set; }

    public Guid GraphKey { get; set; }

    public int Xvalue { get; set; }

    public double? CuALeft { get; set; }

    public double? CuBLeft { get; set; }

    public double? CuARight { get; set; }

    public double? CuBRight { get; set; }

    public double? MaxLimit { get; set; }

    public double? MinLimit { get; set; }
}

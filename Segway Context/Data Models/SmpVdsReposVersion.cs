using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVdsReposVersion
{
    public string AppName { get; set; } = null!;

    public decimal Version { get; set; }

    public decimal UpdInProgress { get; set; }

    public decimal? Standalone { get; set; }
}

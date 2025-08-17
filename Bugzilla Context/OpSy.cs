using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class OpSy
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public int SortKey { get; set; }

    public bool IsActive { get; set; }
}

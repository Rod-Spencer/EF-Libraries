using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class Priority
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public int SortKey { get; set; }

    public bool IsActive { get; set; }
}

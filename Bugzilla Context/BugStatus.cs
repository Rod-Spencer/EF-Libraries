using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class BugStatus
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public short SortKey { get; set; }

    public bool IsActive { get; set; }
}

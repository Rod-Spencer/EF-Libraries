using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class BugDistribution
{
    public int Id { get; set; }

    public int BugId { get; set; }

    public int Who { get; set; }

    public string? Name { get; set; }
}

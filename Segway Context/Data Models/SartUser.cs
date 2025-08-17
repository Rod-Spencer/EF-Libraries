using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartUser
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Level { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class Version
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public int ProductId { get; set; }
}

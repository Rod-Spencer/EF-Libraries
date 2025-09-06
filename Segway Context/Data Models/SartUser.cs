using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartUser
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Level { get; set; } = null!;
}

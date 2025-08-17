using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class Duplicate
{
    public int Id { get; set; }

    public int DupeOf { get; set; }

    public int Dupe { get; set; }
}

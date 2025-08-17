using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class AttachDatum
{
    public int Id { get; set; }

    public byte[] Thedata { get; set; } = null!;
}

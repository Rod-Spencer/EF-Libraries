using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class AttachDatum
{
    public int Id { get; set; }

    public byte[] Thedata { get; set; } = null!;
}

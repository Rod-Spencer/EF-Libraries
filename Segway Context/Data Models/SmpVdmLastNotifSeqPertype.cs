using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVdmLastNotifSeqPertype
{
    public decimal NotificationType { get; set; }

    public decimal? LastNotifSequence { get; set; }
}

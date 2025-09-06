using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVdmSessionNotiftypePair
{
    public decimal SessionId { get; set; }

    public decimal NotificationType { get; set; }

    public decimal? LastNotifSequence { get; set; }
}

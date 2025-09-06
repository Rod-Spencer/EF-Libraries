using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BcuLogDatum
{
    public int RecId { get; set; }

    public int BcuRecId { get; set; }

    public int LogNumber { get; set; }

    public int LogCode { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

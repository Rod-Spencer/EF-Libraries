using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BsaBlackBox
{
    public int Id { get; set; }

    public string? WorkOrder { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? BsaSerialNumber { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Side { get; set; }

    public string? UserName { get; set; }

    public Guid BlackboxKey { get; set; }
}

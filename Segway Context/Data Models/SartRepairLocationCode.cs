using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartRepairLocationCode
{
    public int Id { get; set; }

    public Guid? RowPointer { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

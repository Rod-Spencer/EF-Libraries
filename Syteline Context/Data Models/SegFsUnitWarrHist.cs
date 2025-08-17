using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class SegFsUnitWarrHist
{
    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public int CompId { get; set; }

    public string WarrCode { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? StartMeter { get; set; }

    public int? EndMeter { get; set; }

    public int? OrgCompId { get; set; }

    public string Action { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwaySaRSecondaryReturnStatus
{
    public string PrimaryCode { get; set; } = null!;

    public string SecondaryCode { get; set; } = null!;

    public string? Description { get; set; }

    public byte NoteExistsFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte InWorkflow { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class UM
{
    public string UM1 { get; set; } = null!;

    public string? Description { get; set; }

    public byte? Precision { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? IsoUM { get; set; }
}

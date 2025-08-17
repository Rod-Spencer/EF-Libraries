using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class SpecificNote
{
    public decimal SpecificNoteToken { get; set; }

    public string NoteContent { get; set; } = null!;

    public string NoteDesc { get; set; } = null!;

    public byte NoteExistsFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte InWorkflow { get; set; }
}

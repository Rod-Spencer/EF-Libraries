using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class ObjectNote
{
    public decimal ObjectNoteToken { get; set; }

    public decimal NoteHeaderToken { get; set; }

    public Guid RefRowPointer { get; set; }

    public int? NoteType { get; set; }

    public decimal? SystemNoteToken { get; set; }

    public decimal? UserNoteToken { get; set; }

    public decimal? SpecificNoteToken { get; set; }

    public byte NoteExistsFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte InWorkflow { get; set; }
}

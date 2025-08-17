using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class SegSartPicture
{
    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte NoteExistsFlag { get; set; }

    public byte InWorkflow { get; set; }

    public string SroNum { get; set; } = null!;

    public int SroLine { get; set; }

    public string Name { get; set; } = null!;

    public string UniqueName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public byte[] PictureData { get; set; } = null!;
}

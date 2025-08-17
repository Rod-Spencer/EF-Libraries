using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class ObjectType
{
    public int ObjectType1 { get; set; }

    public string ObjectCode { get; set; } = null!;

    public string ObjectDesc { get; set; } = null!;

    public byte NoteExistsFlag { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte InWorkflow { get; set; }
}

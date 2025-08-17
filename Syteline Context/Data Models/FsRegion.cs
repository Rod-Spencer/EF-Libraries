using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsRegion
{
    public string Region { get; set; } = null!;

    public string? Description { get; set; }

    public byte? Noteexistsflag { get; set; }

    public DateTime? Recorddate { get; set; }

    public Guid Rowpointer { get; set; }

    public string? Createdby { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? Createdate { get; set; }

    public byte Inworkflow { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class SegEndUserChannel
{
    public string Createdby { get; set; } = null!;

    public string Updatedby { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public DateTime Recorddate { get; set; }

    public Guid Rowpointer { get; set; }

    public byte Noteexistsflag { get; set; }

    public byte Inworkflow { get; set; }

    public string EndUserType { get; set; } = null!;

    public string Channel { get; set; } = null!;
}

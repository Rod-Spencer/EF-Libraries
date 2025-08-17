using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class Pricecode
{
    public string Pricecode1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? CustItem { get; set; }

    public byte Noteexistsflag { get; set; }

    public DateTime Recorddate { get; set; }

    public Guid Rowpointer { get; set; }

    public string Createdby { get; set; } = null!;

    public string Updatedby { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public byte Inworkflow { get; set; }
}

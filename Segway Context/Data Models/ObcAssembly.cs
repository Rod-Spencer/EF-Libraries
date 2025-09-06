using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ObcAssembly
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public string PartNumber { get; set; } = null!;

    public string InternalUicSerial { get; set; } = null!;

    public string ObcSerial { get; set; } = null!;
}

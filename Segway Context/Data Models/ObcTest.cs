using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ObcTest
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public string ObcSerial { get; set; } = null!;

    public bool TestPassed { get; set; }
}

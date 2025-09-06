using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayLogin
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string ToolName { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }
}

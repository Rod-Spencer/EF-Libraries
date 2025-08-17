using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegwayLogin
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string ToolName { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }
}

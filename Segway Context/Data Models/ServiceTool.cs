using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ServiceTool
{
    public int Id { get; set; }

    public string? ToolName { get; set; }

    public string? ToolCategory { get; set; }

    public int ToolType { get; set; }
}

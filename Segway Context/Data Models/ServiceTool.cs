using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ServiceTool
{
    public int Id { get; set; }

    public string? ToolName { get; set; }

    public string? ToolCategory { get; set; }

    public int ToolType { get; set; }
}

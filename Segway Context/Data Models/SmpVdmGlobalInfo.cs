using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVdmGlobalInfo
{
    public string ServiceType { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    public string PropertyName { get; set; } = null!;

    public string? PropertyValue { get; set; }
}

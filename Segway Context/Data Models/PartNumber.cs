using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PartNumber
{
    public string PartNumber1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string SerialType { get; set; } = null!;
}

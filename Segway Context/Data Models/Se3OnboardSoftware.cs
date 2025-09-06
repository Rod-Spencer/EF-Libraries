using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Se3OnboardSoftware
{
    public int Id { get; set; }

    public string Component { get; set; } = null!;

    public int VersionNumber { get; set; }

    public string? FilePath { get; set; }

    public byte[] Data { get; set; } = null!;

    public string? Model { get; set; }
}

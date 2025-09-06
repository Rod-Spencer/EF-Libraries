using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartCoffFile
{
    public int Id { get; set; }

    public string? Generation { get; set; }

    public string? Component { get; set; }

    public string? Model { get; set; }

    public string? Type { get; set; }

    public string? BuildDate { get; set; }

    public string? BuildNumber { get; set; }

    public string? FilePath { get; set; }

    public byte[]? Data { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ManufacturingComponentComment
{
    public int Id { get; set; }

    public string SerialNumber { get; set; } = null!;

    public string? Category { get; set; }

    public DateTime DateTimeEntered { get; set; }

    public string UserName { get; set; } = null!;

    public string? Comment { get; set; }
}

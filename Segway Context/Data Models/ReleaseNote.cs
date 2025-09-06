using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ReleaseNote
{
    public int Id { get; set; }

    public string Application { get; set; } = null!;

    public string Version { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? Summary { get; set; }

    public string? Description { get; set; }

    public int? Bug { get; set; }
}

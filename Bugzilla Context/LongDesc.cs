using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class LongDesc
{
    public int Id { get; set; }

    public int BugId { get; set; }

    public int Who { get; set; }

    public DateTime BugWhen { get; set; }

    public float WorkTime { get; set; }

    public string? TheText { get; set; }

    public bool IsPrivate { get; set; }

    public bool AlreadyWrapped { get; set; }
}

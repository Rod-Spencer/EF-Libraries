using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class BugsActivity
{
    public int Id { get; set; }

    public int BugId { get; set; }

    public int? AttachId { get; set; }

    public int Who { get; set; }

    public DateTime BugWhen { get; set; }

    public int Fieldid { get; set; }

    public string? Added { get; set; }

    public string? Removed { get; set; }
}

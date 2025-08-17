using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class Profile
{
    public int UserId { get; set; }

    public string LoginName { get; set; } = null!;

    public string? CryptPassword { get; set; }

    public string? RealName { get; set; }

    public string DisabledText { get; set; } = null!;

    public bool MybugsLink { get; set; }

    public DateTime RefreshedWhen { get; set; }

    public string? ExternId { get; set; }
}

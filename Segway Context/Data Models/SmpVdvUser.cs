using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVdvUser
{
    public decimal UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? DisplayName { get; set; }
}

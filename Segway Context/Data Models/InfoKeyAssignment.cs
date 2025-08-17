using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class InfoKeyAssignment
{
    public int Id { get; set; }

    public int? InstanceId { get; set; }

    public int? ElprotronicId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

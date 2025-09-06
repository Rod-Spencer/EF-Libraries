using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class InfoKeyAssignment
{
    public int Id { get; set; }

    public int? InstanceId { get; set; }

    public int? ElprotronicId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

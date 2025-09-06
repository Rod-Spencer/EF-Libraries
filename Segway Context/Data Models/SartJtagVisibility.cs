using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartJtagVisibility
{
    public int Id { get; set; }

    public string WorkOrderNumber { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime? DateTimeStart { get; set; }

    public DateTime? DateTimeEnd { get; set; }

    public string AuthorityName { get; set; } = null!;

    public DateTime? DateTimeEntered { get; set; }
}

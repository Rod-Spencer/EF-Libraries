using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartDisclaimer
{
    public int Id { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string UserName { get; set; } = null!;

    public string WorkOrderId { get; set; } = null!;

    public int Status { get; set; }
}

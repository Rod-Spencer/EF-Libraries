using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class InfoKeyManufacture
{
    public int RecId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string SerialNumber { get; set; } = null!;

    public int SuccessRead { get; set; }

    public int SuccessWrite { get; set; }

    public int FailureRead { get; set; }

    public int FailureWrite { get; set; }

    public int Status { get; set; }

    public int? ElprotronicId { get; set; }
}

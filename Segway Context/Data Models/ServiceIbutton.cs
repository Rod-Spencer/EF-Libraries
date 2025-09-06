using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ServiceIbutton
{
    public decimal RecId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? Code { get; set; }

    public string? Confirmation { get; set; }

    public string? Email { get; set; }

    public string? Representative { get; set; }

    public string? Requestor { get; set; }

    public string? Customer { get; set; }
}

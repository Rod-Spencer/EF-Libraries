using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtBatteriesHistory
{
    public int HistRecId { get; set; }

    public string? Action { get; set; }

    public string? Username { get; set; }

    public int RecId { get; set; }

    public int? RegistrationId { get; set; }

    public string? BatterySerialNumber { get; set; }

    public string? BatteryLocation { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public int? Id { get; set; }
}

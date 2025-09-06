using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtBattery
{
    public int Id { get; set; }

    public int RecId { get; set; }

    public int RegistrationId { get; set; }

    public string? BatterySerialNumber { get; set; }

    public string? BatteryLocation { get; set; }

    public string? Username { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

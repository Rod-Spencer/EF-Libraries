using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ManufacturingComponentGearBoxLot
{
    public Guid? Id { get; set; }

    public Guid LotKey { get; set; }

    public DateTime LotDate { get; set; }

    public string? ShaftIntmPn { get; set; }

    public string? ShaftInputPn { get; set; }

    public string? OutputGearPn { get; set; }

    public string? GearIntmPn { get; set; }

    public string? ShaftIntmLot { get; set; }

    public string? ShaftInputLot { get; set; }

    public string? OutputGearLot { get; set; }

    public string? GearIntmLot { get; set; }

    public DateTime? DateTimeEntered { get; set; }
}

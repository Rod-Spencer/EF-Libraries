using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ShippingInstructionsDatum
{
    public Guid Id { get; set; }

    public string OrderNumber { get; set; } = null!;

    public bool Register { get; set; }

    public bool Batteries { get; set; }

    public bool NoBatteries { get; set; }

    public bool Other { get; set; }

    public string? DealerId { get; set; }

    public int? DealerShipto { get; set; }

    public string? ConsumerId { get; set; }

    public int? ConsumerShipto { get; set; }

    public string? Comments { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? EnteredBy { get; set; }

    public string? UpdatedBy { get; set; }
}

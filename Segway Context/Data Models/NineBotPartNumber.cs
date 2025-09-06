using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class NineBotPartNumber
{
    public int Id { get; set; }

    public string SegwayPartNumber { get; set; } = null!;

    public string? NinebotPartNumber1 { get; set; }

    public string? Description { get; set; }

    public string? Upc { get; set; }

    public DateTime DateTimeEntered { get; set; }
}

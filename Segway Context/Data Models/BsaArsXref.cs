using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class BsaArsXref
{
    public int Id { get; set; }

    public string BsaSerialNumber { get; set; } = null!;

    public string ArsSerialNumber { get; set; } = null!;

    public DateTime? DateTimeTested { get; set; }
}

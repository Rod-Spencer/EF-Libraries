using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVduPrincipalsTable
{
    public decimal PrincipalId { get; set; }

    public string Type { get; set; } = null!;

    public string PrincipalName { get; set; } = null!;

    public byte[] Password { get; set; } = null!;
}

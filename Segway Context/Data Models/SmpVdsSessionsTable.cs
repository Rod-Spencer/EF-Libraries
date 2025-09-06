using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SmpVdsSessionsTable
{
    public decimal SessionId { get; set; }

    public string PrincipalName { get; set; } = null!;

    public string PrincipalType { get; set; } = null!;

    public string? PrincipalIor { get; set; }

    public DateTime? LoginTime { get; set; }

    public string Oms { get; set; } = null!;
}

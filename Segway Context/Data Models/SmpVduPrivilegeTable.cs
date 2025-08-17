using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVduPrivilegeTable
{
    public decimal PrincipalOid { get; set; }

    public string PrivilegeString { get; set; } = null!;

    public decimal ObjectOid { get; set; }
}

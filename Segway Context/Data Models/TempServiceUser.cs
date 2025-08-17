using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class TempServiceUser
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserPassword { get; set; }

    public string? UserEmail { get; set; }

    public string? SytelineAccountId { get; set; }

    public int CustAccountId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public string? UserStatus { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ServiceUser
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserDisplay { get; set; }

    public string? UserPassword { get; set; }

    public string? UserEmail { get; set; }

    public string? SytelineAccountId { get; set; }

    public string? SytelinePartnerId { get; set; }

    public string? SytelineEmployeeId { get; set; }

    public int CustAccountId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public int? UserStatus { get; set; }

    public string? RealName { get; set; }

    public string? UserPasswordSalt { get; set; }

    public string? UserPasswordHash { get; set; }

    public string? UserReplacementPasswordHash { get; set; }

    public DateTime? UserReplacementPasswordHashExpires { get; set; }

    public bool Active { get; set; }
}

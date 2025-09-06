using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class ServiceUserAccess
{
    public int Id { get; set; }

    public int UserAccessId { get; set; }

    public int UserId { get; set; }

    public int? NewUserId { get; set; }

    public int? Ordinal { get; set; }

    public string? ToolName { get; set; }

    public string? AccessLevel { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? CurrentVersion { get; set; }

    public int LoginCount { get; set; }

    public string? UpdateVersion { get; set; }

    public DateTime? MandatoryUpdate { get; set; }

    public DateTime? InstallDate { get; set; }

    public string? UserDefaultLevel { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

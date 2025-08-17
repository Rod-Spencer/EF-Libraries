using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Bug
{
    public int BugId { get; set; }

    public int AssignedTo { get; set; }

    public string? BugFileLoc { get; set; }

    public string BugSeverity { get; set; } = null!;

    public string BugStatus { get; set; } = null!;

    public DateTime? CreationTs { get; set; }

    public DateTime DeltaTs { get; set; }

    public string ShortDesc { get; set; } = null!;

    public string OpSys { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public int ProductId { get; set; }

    public string RepPlatform { get; set; } = null!;

    public int Reporter { get; set; }

    public string Version { get; set; } = null!;

    public int ComponentId { get; set; }

    public string Resolution { get; set; } = null!;

    public string TargetMilestone { get; set; } = null!;

    public int? QaContact { get; set; }

    public string? StatusWhiteboard { get; set; }

    public int Votes { get; set; }

    public string KeyWords { get; set; } = null!;

    public DateTime? Lastdiffed { get; set; }

    public bool? Everconfirmed { get; set; }

    public bool? ReporterAccessible { get; set; }

    public bool? CclistAccessible { get; set; }

    public double EstimatedTime { get; set; }

    public double RemainingTime { get; set; }

    public DateTime? Deadline { get; set; }

    public string? Alias { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ImplVersion { get; set; }

    public int? Revision { get; set; }

    public bool? IsHidden { get; set; }

    public bool? LogsLoaded { get; set; }

    public string? WorkOrder { get; set; }

    public string? Frequency { get; set; }

    public DateTime? OccurranceTimestamp { get; set; }

    public string? BugType { get; set; }
}

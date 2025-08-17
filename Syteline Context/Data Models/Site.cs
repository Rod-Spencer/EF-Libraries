using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class Site
{
    public string Site1 { get; set; } = null!;

    public string? SiteName { get; set; }

    public string? LangCode { get; set; }

    public string? Type { get; set; }

    public string? ReportsToSite { get; set; }

    public DateTime? LastConsolidated { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? IntranetName { get; set; }

    public string? SystemType { get; set; }

    public string? Description { get; set; }

    public string? AppDbName { get; set; }

    public string? TimeZone { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? StringsTable { get; set; }

    public byte InWorkflow { get; set; }

    public string? MessageBusLogicalId { get; set; }

    public byte Intranetlicensing { get; set; }
}

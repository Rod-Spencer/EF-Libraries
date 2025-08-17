using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsSroType
{
    public bool? AccumWip { get; set; }

    public string? BillCode { get; set; }

    public string BillType { get; set; } = null!;

    public string? CgsRevLocLabor { get; set; }

    public string? CgsRevLocMatl { get; set; }

    public string? CgsRevLocMisc { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? Datefld { get; set; }

    public double? Decifld1 { get; set; }

    public double? Decifld2 { get; set; }

    public double? Decifld3 { get; set; }

    public string? Description { get; set; }

    public double? Disc { get; set; }

    public short? ExchangeDays { get; set; }

    public byte? InclDemand { get; set; }

    public byte? Logifld { get; set; }

    public string? ProductCode { get; set; }

    public string SroType { get; set; } = null!;

    public string? Whse { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public int LeadTime { get; set; }

    public string LeadType { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsSroStat
{
    public string SroNum { get; set; } = null!;

    public int Seq { get; set; }

    public string? StatCode { get; set; }

    public DateTime StatDate { get; set; }

    public string? PartnerId { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public byte GpsOnline { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public DateTime? GpsLocDate { get; set; }
}

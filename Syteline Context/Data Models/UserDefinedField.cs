using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class UserDefinedField
{
    public string TableName { get; set; } = null!;

    public Guid RowId { get; set; }

    public string? Udfvcsd1 { get; set; }

    public string? Udfvcsd2 { get; set; }

    public string? Udfvcsd3 { get; set; }

    public string? Udfvcsd4 { get; set; }

    public string? Udfvcsd5 { get; set; }

    public string? Udfvcsd6 { get; set; }

    public string? Udfvcsd7 { get; set; }

    public string? Udfvcmd1 { get; set; }

    public string? Udfvcmd2 { get; set; }

    public string? Udfvcmd3 { get; set; }

    public string? Udfvcmd4 { get; set; }

    public string? Udfvcmd5 { get; set; }

    public string? Udfvcmd6 { get; set; }

    public string? Udfvcld1 { get; set; }

    public string? Udfvcld2 { get; set; }

    public DateTime? Udfdt1 { get; set; }

    public DateTime? Udfdt2 { get; set; }

    public DateTime? Udfdt3 { get; set; }

    public DateTime? Udfdt4 { get; set; }

    public DateTime? Udfdt5 { get; set; }

    public DateTime? Udfdt6 { get; set; }

    public int? Udfint1 { get; set; }

    public int? Udfint2 { get; set; }

    public int? Udfint3 { get; set; }

    public int? Udfint4 { get; set; }

    public int? Udfint5 { get; set; }

    public int? Udfint6 { get; set; }

    public decimal? Udfnum1 { get; set; }

    public decimal? Udfnum2 { get; set; }

    public decimal? Udfnum3 { get; set; }

    public decimal? Udfnum4 { get; set; }

    public decimal? Udfnum5 { get; set; }

    public decimal? Udfnum6 { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte InWorkflow { get; set; }
}

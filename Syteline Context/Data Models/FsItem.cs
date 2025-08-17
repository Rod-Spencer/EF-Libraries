using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsItem
{
    public int? CalibDays { get; set; }

    public int? CalibFirst { get; set; }

    public byte? CalibFlag { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public byte? FsTrackable { get; set; }

    public byte? InclForecast { get; set; }

    public byte? InclInCfg { get; set; }

    public int? InsDays { get; set; }

    public int? InsFirst { get; set; }

    public byte? InsFlag { get; set; }

    public string Item { get; set; } = null!;

    public byte? Logifld { get; set; }

    public string? MeterLabel { get; set; }

    public int? PmDays { get; set; }

    public int? PmFirst { get; set; }

    public byte? PmFlag { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid? RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public byte InclWaiverCharge { get; set; }

    public string? ContPriceBasis { get; set; }

    public int DurationDays { get; set; }

    public int DurationHrs { get; set; }

    public string? UnitOfRate { get; set; }

    public byte ExcludeFromCtp { get; set; }

    public string? FsPMTCode { get; set; }

    public string? FsSupplyWhse { get; set; }

    public string? FsVendNum { get; set; }

    public decimal? FsOrderMin { get; set; }

    public decimal? FsOrderMax { get; set; }

    public decimal? FsOrderMult { get; set; }

    public short? FsDaysSupply { get; set; }

    public byte FsConsumable { get; set; }

    public byte DrpItem { get; set; }

    public string? PriorCode { get; set; }
}

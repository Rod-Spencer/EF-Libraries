using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsPartner
{
    public bool? Active { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public double? Cost { get; set; }

    public string? CurrCode { get; set; }

    public string? CustNum { get; set; }

    public DateTime? Datefld { get; set; }

    public double? Decifld1 { get; set; }

    public double? Decifld2 { get; set; }

    public double? Decifld3 { get; set; }

    public string? Dept { get; set; }

    public string? Email { get; set; }

    public double? Hrs1 { get; set; }

    public double? Hrs2 { get; set; }

    public double? Hrs3 { get; set; }

    public double? Hrs4 { get; set; }

    public double? Hrs5 { get; set; }

    public double? Hrs6 { get; set; }

    public double? Hrs7 { get; set; }

    public bool? Logifld { get; set; }

    public string? MiscCode { get; set; }

    public string? Name { get; set; }

    public string PartnerId { get; set; } = null!;

    public string? Password { get; set; }

    public double? Rate { get; set; }

    public string? RefNum { get; set; }

    public int? RefSeq { get; set; }

    public string RefType { get; set; } = null!;

    public bool ReimbLabor { get; set; }

    public bool ReimbMatl { get; set; }

    public string? ReimbMethod { get; set; }

    public string? Username { get; set; }

    public string? VendNum { get; set; }

    public string? Whse { get; set; }

    public string? WorkCode { get; set; }

    public byte? Noteexistsflag { get; set; }

    public DateTime? Recorddate { get; set; }

    public Guid Rowpointer { get; set; }

    public string? Createdby { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? Createdate { get; set; }

    public byte Inworkflow { get; set; }

    public bool? DisplayOnScheduleBoard { get; set; }

    public string? SupId { get; set; }

    public string? TxtMsgAddr { get; set; }

    public string? PagerAddr { get; set; }

    public DateTime? GpsLastTimestamp { get; set; }

    public double? GpsLastLatitude { get; set; }

    public double? GpsLastLongitude { get; set; }

    public bool ExchangeSync { get; set; }

    public string? ExchangeScheduleFolder { get; set; }

    public string? UfSegLogin { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsConsumer
{
    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? Addr4 { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public string? City { get; set; }

    public string? Contact1 { get; set; }

    public string? Contact2 { get; set; }

    public string? Contact3 { get; set; }

    public string? Country { get; set; }

    public string? County { get; set; }

    public string? CustNum { get; set; }

    public int? CustSeq { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public string? Email3 { get; set; }

    public string? FaxNum { get; set; }

    public byte? Logifld { get; set; }

    public string? Name { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Phone3 { get; set; }

    public string? State { get; set; }

    public string UsrNum { get; set; } = null!;

    public int UsrSeq { get; set; }

    public string? Zip { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? DriversLicense { get; set; }

    public string? Ssn { get; set; }

    public int? UfSegConsumerType { get; set; }

    public byte? UfSegIsFavorite { get; set; }
}

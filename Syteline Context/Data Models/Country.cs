namespace SpenSoft.EF.Syteline;

public partial class Country
{
    public string Country1 { get; set; } = null!;

    public string? EcCode { get; set; }

    public string? SsdEcCode { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public byte? ExpDocReqd { get; set; }

    public string? IsoCountryCode { get; set; }

    public string? SegRegion { get; set; }
}

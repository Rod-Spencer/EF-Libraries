namespace Segway.EF.SegwayCntxt;

public partial class BatteryCharge
{
    public string? SerialNumber { get; set; }

    public string? Recorder { get; set; }

    public string? PalletNumber { get; set; }

    public DateTime? DateRecorded { get; set; }

    public decimal? RecordNumber { get; set; }
}

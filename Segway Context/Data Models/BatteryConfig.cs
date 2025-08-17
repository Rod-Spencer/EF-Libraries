namespace Segway.EF.SegwayCntxt;

public partial class BatteryConfig
{
    public int RecId { get; set; }

    public string? ProductSerialNumber { get; set; }

    public string? BcuASwRev { get; set; }

    public string? BcuBSwRev { get; set; }

    public string? BcuAPartnumRev { get; set; }

    public string? BcuBPartnumRev { get; set; }

    public string? BcuASerialnumRev { get; set; }

    public string? BcuBSerialnumRev { get; set; }

    public DateTime? DateEntered { get; set; }

    public string? Model { get; set; }
}

namespace SpenSoft.EF.Segway;

public partial class AllowedUnitStatus
{
    public int Id { get; set; }

    public string? UnitStatus { get; set; }

    public string Classification { get; set; } = null!;
}

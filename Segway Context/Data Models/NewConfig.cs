using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class NewConfig
{
    public Guid? Id { get; set; }

    public string? Model { get; set; }

    public string? SerialNumber { get; set; }

    public string? CuAModelNum { get; set; }

    public string? CuASerialNum { get; set; }

    public string? CuBModelNum { get; set; }

    public string? CuBSerialNum { get; set; }

    public string? UiModelNum { get; set; }

    public string? UiSerialNum { get; set; }

    public string? BcuAModelNum { get; set; }

    public string? BcuASerialNum { get; set; }

    public string? BcuBModelNum { get; set; }

    public string? BcuBSerialNum { get; set; }

    public string? DllVersion { get; set; }

    public DateTime? DateEntered { get; set; }

    public string? GearBox1 { get; set; }

    public string? GearBox2 { get; set; }

    public string? TireWheel1 { get; set; }

    public string? TireWheel2 { get; set; }

    public string? Motor1 { get; set; }

    public string? Motor2 { get; set; }

    public string? Mat { get; set; }

    public string? ServiceNumber { get; set; }

    public string? Status { get; set; }

    public string? CuASwRev { get; set; }

    public string? CuBSwRev { get; set; }

    public string? UiSwRev { get; set; }

    public string? ImuSwRev { get; set; }

    public string? BcuASwRev { get; set; }

    public string? BcuBSwRev { get; set; }

    public string? ImuSerialNum { get; set; }

    public string? PowerSupplySerialNumber { get; set; }

    public string? ServiceTech { get; set; }

    public string? ImuPartNumber { get; set; }

    public string? ImuSwRevA { get; set; }

    public string? ImuSwRevB { get; set; }

    public string? ImuAModelNum { get; set; }

    public string? ImuBModelNum { get; set; }

    public string? ImuASerialNum { get; set; }

    public string? ImuBSerialNum { get; set; }
}

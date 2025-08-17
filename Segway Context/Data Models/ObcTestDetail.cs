using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ObcTestDetail
{
    public int Id { get; set; }

    public int TestId { get; set; }

    public double InputVoltage { get; set; }

    public double LoadSetting { get; set; }

    public double Side1Voltage { get; set; }

    public double Side1Current { get; set; }

    public double Side2Voltage { get; set; }

    public double Side2Current { get; set; }

    public bool LevelPassed { get; set; }
}

using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class UiConfig
{
    public string? ProductSerialNumber { get; set; }

    public string? UiASoftwareRev { get; set; }

    public string? UiBSoftwareRev { get; set; }

    public string? UiAPartnumRev { get; set; }

    public string? UiBPartnumRev { get; set; }

    public string? UiASerialnumRev { get; set; }

    public string? UiBSerialnumRev { get; set; }

    public DateTime? DateEntered { get; set; }

    public string? Model { get; set; }
}

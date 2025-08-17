using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class FieldDef
{
    public int FieldId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool MailHead { get; set; }

    public int SortKey { get; set; }

    public bool Obsolete { get; set; }
}

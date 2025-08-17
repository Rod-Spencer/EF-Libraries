using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class Component
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ProductId { get; set; }

    public int InitialOwner { get; set; }

    public int? InitialQaContact { get; set; }

    public string Description { get; set; } = null!;
}

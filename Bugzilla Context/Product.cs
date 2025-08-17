using System;
using System.Collections.Generic;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ClassificationId { get; set; }

    public string? Description { get; set; }

    public string Milestoneurl { get; set; } = null!;

    public bool Disallownew { get; set; }

    public int Votesperuser { get; set; }

    public int Maxvotesperbug { get; set; }

    public int Votestoconfirm { get; set; }

    public string Defaultmilestone { get; set; } = null!;
}

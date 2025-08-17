using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Attachment
{
    public int AttachId { get; set; }

    public int BugId { get; set; }

    public DateTime CreationTs { get; set; }

    public string Description { get; set; } = null!;

    public string Mimetype { get; set; } = null!;

    public bool? Ispatch { get; set; }

    public string Filename { get; set; } = null!;

    public string SubmitterId { get; set; } = null!;

    public bool? Isobsolete { get; set; }

    public bool? Isprivate { get; set; }

    public bool? Isurl { get; set; }
}

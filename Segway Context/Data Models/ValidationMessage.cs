using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ValidationMessage
{
    public int Id { get; set; }

    public int MessageId { get; set; }

    public string? ApplicationType { get; set; }

    public string? MessageType { get; set; }

    public string? StatusMessage { get; set; }
}

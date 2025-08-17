using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class ServiceToolsAuthenticationToken
{
    public int Id { get; set; }

    public string Token { get; set; } = null!;

    public int ServiceToolId { get; set; }

    public int ServiceUserId { get; set; }

    public DateTime Expires { get; set; }
}

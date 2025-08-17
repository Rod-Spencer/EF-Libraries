using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SartPicture
{
    public int Id { get; set; }

    public string WorkOrderId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string UniqueName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string UserName { get; set; } = null!;

    public byte[] PictureData { get; set; } = null!;
}

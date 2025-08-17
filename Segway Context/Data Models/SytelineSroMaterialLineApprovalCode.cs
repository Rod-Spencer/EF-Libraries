using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SytelineSroMaterialLineApprovalCode
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public Guid? RowPointer { get; set; }
}

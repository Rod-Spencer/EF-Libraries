using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class MdtMaster
{
    public decimal? MdtId { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public decimal? DispositionId { get; set; }

    public string? Status { get; set; }

    public string? Justification { get; set; }

    public string? Originator { get; set; }

    public string? RecipientDepartment { get; set; }

    public string? Approver { get; set; }

    public DateTime? ApprovalDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class ConnectionInformation
{
    public Guid ConnectionId { get; set; }

    public string UserName { get; set; } = null!;

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public string? CreationContext { get; set; }

    public string? ImpersonatingUserName { get; set; }

    public short SessionType { get; set; }

    public string? SessionSpec { get; set; }
}

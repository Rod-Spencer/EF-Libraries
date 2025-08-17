using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsIncident
{
    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? Contact { get; set; }

    public string? CustNum { get; set; }

    public int? CustSeq { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Email { get; set; }

    public string? FaxNum { get; set; }

    public DateTime? FollowupDate { get; set; }

    public DateTime IncDate { get; set; }

    public string IncNum { get; set; } = null!;

    public string? Item { get; set; }

    public int? KnowNum { get; set; }

    public byte? Logifld { get; set; }

    public decimal? MatlQty { get; set; }

    public decimal? MatlQtyConv { get; set; }

    public int? MeterAmt { get; set; }

    public DateTime? MeterDate { get; set; }

    public string? Owner { get; set; }

    public string? Phone { get; set; }

    public string PriorCode { get; set; } = null!;

    public string? PriorInc { get; set; }

    public int? RefLineSuf { get; set; }

    public string? RefNum { get; set; }

    public int? RefRelease { get; set; }

    public string? RefSite { get; set; }

    public string? RefType { get; set; }

    public string? SerNum { get; set; }

    public string? Site { get; set; }

    public string Ssr { get; set; } = null!;

    public string StatCode { get; set; } = null!;

    public string? UM { get; set; }

    public string? UsrNum { get; set; }

    public int? UsrSeq { get; set; }

    public byte? WebEntered { get; set; }

    public byte? WebView { get; set; }

    public string? WorkSite { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte? ToSchedule { get; set; }

    public byte InWorkflow { get; set; }

    public string? Dept { get; set; }

    public byte IncClosed { get; set; }

    public string? Phone2 { get; set; }

    public string? DriversLicense { get; set; }

    public string? Ssn { get; set; }

    public string? RemoteId { get; set; }

    public decimal? Duration { get; set; }

    public string? DurationUnits { get; set; }

    public decimal? EstimatedTimeRemaining { get; set; }

    public string? EstimatedTimeRemainingUnits { get; set; }

    public string? Region { get; set; }

    public DateTime? LastEscal { get; set; }

    public byte FollowupComplete { get; set; }

    public string? TxtMsgAddr { get; set; }

    public string? PagerAddr { get; set; }

    public DateTime? WarningDate { get; set; }

    public decimal? UfMsmDeci1 { get; set; }

    public decimal? UfMsmDeci2 { get; set; }

    public string? UfMsmStr1 { get; set; }

    public string? UfMsmStr2 { get; set; }

    public int? UfMsmInt1 { get; set; }

    public int? UfMsmInt2 { get; set; }

    public byte? UfMsmBool2 { get; set; }

    public DateTime? UfMsmDt1 { get; set; }

    public DateTime? UfMsmDt2 { get; set; }

    public byte? UfMsmBool1 { get; set; }

    public byte AwaitingParts { get; set; }

    public string? CustItem { get; set; }
}

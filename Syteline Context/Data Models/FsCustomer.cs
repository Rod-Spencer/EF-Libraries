using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class FsCustomer
{
    public byte? ApplyOpenDeposits { get; set; }

    public string? BillMgr { get; set; }

    public string? Charfld1 { get; set; }

    public string? Charfld2 { get; set; }

    public string? Charfld3 { get; set; }

    public string CustNum { get; set; } = null!;

    public int CustSeq { get; set; }

    public DateTime? Datefld { get; set; }

    public decimal? Decifld1 { get; set; }

    public decimal? Decifld2 { get; set; }

    public decimal? Decifld3 { get; set; }

    public decimal? DepositApplied { get; set; }

    public decimal? DepositReceived { get; set; }

    public byte? DepositReq { get; set; }

    public decimal? DepositSroRec { get; set; }

    public decimal? DepositSroTotal { get; set; }

    public string? Directions { get; set; }

    public byte? Logifld { get; set; }

    public string? Password { get; set; }

    public string? Pricecode { get; set; }

    public string? ReimbMethod { get; set; }

    public string? TermsCode { get; set; }

    public string? VendNum { get; set; }

    public byte? NoteExistsFlag { get; set; }

    public DateTime? RecordDate { get; set; }

    public Guid? RowPointer { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public byte PosOnAcct { get; set; }

    public byte PosCash { get; set; }

    public byte PosCreditCard { get; set; }

    public byte PosCheck { get; set; }

    public byte ExclWaiverCharge { get; set; }

    public DateTime? WaiverExpiration { get; set; }

    public string? ServType { get; set; }

    public string? ShipCode { get; set; }

    public string? PartnerId { get; set; }

    public string? Region { get; set; }

    public string? PriorCode { get; set; }
}

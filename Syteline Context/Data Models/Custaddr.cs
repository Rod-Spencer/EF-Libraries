namespace SpenSoft.EF.Syteline;

public partial class Custaddr
{
    public string CustNum { get; set; } = null!;

    public int CustSeq { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? County { get; set; }

    public string? Country { get; set; }

    public string? FaxNum { get; set; }

    public string? TelexNum { get; set; }

    public string? BalMethod { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? Addr4 { get; set; }

    public byte? CreditHold { get; set; }

    public string? CreditHoldUser { get; set; }

    public DateTime? CreditHoldDate { get; set; }

    public string? CreditHoldReason { get; set; }

    public decimal? CreditLimit { get; set; }

    public string? CurrCode { get; set; }

    public string? CorpCust { get; set; }

    public byte? CorpCred { get; set; }

    public byte? CorpAddress { get; set; }

    public decimal? AmtOverInvAmt { get; set; }

    public short? DaysOverInvDueDate { get; set; }

    public string? ShipToEmail { get; set; }

    public string? BillToEmail { get; set; }

    public string? InternetUrl { get; set; }

    public string? InternalEmailAddr { get; set; }

    public string? ExternalEmailAddr { get; set; }

    public byte NoteExistsFlag { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public byte InWorkflow { get; set; }

    public void Update(Contact_Info? ci)
    {
        Name = ci?.Name;
        this.Addr1 = ci?.Address1;
        this.Addr2 = ci?.Address2;
        this.City = ci?.City;
        this.State = ci?.State;
        this.County = ci?.County;
        this.Zip = ci?.Zip;
        this.Country = ci?.Country;
        this.ExternalEmailAddr = ci?.Email;
    }
}

using System.ComponentModel;

namespace SpenSoft.EF.Syteline;

public class Contact_Info: INotifyPropertyChanged
{
    public Contact_Info() { }
    public Contact_Info(FsConsumer ci)
    {
        this.RefNum = ci.CustNum;
        this.RefSeq = ci.CustSeq;
        this.Name = ci.Name;
        this.Contact = String.IsNullOrEmpty(ci.Contact1) == false ? ci.Contact1 :
            String.IsNullOrEmpty(ci.Contact2) == false ? ci.Contact2 :
            String.IsNullOrEmpty(ci.Contact3) == false ? ci.Contact3 :
            null;
        this.Address1 = ci.Addr1;
        this.Address2 = ci.Addr2;
        this.City = ci.City;
        this.State = ci.State;
        this.County = ci.County;
        this.Zip = ci.Zip;
        this.Country = ci.Country;
        this.Email = String.IsNullOrEmpty(ci.Email1) == false ? ci.Email1 :
            String.IsNullOrEmpty(ci.Email2) == false ? ci.Email2 :
            String.IsNullOrEmpty(ci.Email3) == false ? ci.Email3 :
            null;
        this.Phone = String.IsNullOrEmpty(ci.Phone1) == false ? ci.Phone1 :
            String.IsNullOrEmpty(ci.Phone2) == false ? ci.Phone2 :
            String.IsNullOrEmpty(ci.Phone3) == false ? ci.Phone3 :
            null;
    }

    public Contact_Info(Customer c, Custaddr ca)
    {
        this.RefNum = c.CustNum;
        this.RefSeq = c.CustSeq;
        this.Name = ca.Name;
        this.Contact = String.IsNullOrEmpty(c.Contact1) == false ? c.Contact1 :
            String.IsNullOrEmpty(c.Contact2) == false ? c.Contact2 :
            String.IsNullOrEmpty(c.Contact3) == false ? c.Contact3 :
            null;
        this.Address1 = ca.Addr1;
        this.Address2 = ca.Addr2;
        this.City = ca.City;
        this.State = ca.State;
        this.County = ca.County;
        this.Zip = ca.Zip;
        this.Country = ca.Country;
        this.Email = String.IsNullOrEmpty(ca.ExternalEmailAddr) == false ? ca.ExternalEmailAddr :
            String.IsNullOrEmpty(ca.BillToEmail) == false ? ca.BillToEmail :
            String.IsNullOrEmpty(ca.ShipToEmail) == false ? ca.ShipToEmail :
            String.IsNullOrEmpty(ca.InternalEmailAddr) == false ? ca.InternalEmailAddr :
            null;
        this.Phone = String.IsNullOrEmpty(c.Phone1) == false ? c.Phone1 :
            String.IsNullOrEmpty(c.Phone2) == false ? c.Phone2 :
            String.IsNullOrEmpty(c.Phone3) == false ? c.Phone3 :
            null;
    }

    public String? RefNum { get; set; }
    public int? RefSeq { get; set; }
    public String? Name { get; set; }
    public String? Contact { get; set; }
    public String? Address1 { get; set; }
    public String? Address2 { get; set; }
    public String? City { get; set; }
    public String? State { get; set; }
    public String? Zip { get; set; }
    public String? County { get; set; }
    public String? Country { get; set; }
    public String? Phone { get; set; }
    public String? Email { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    public override String ToString()
    {
        return $"N: {Name}, C: {Contact}, A1: {Address1}, C: {City}, S: {State}";
    }
}

namespace SpenSoft.EF.Syteline;

public class Contact_Info
{
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

    public override String ToString()
    {
        return $"N: {Name}, C: {Contact}, A1: {Address1}, C: {City}, S: {State}";
    }
}

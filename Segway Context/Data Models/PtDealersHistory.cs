using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PtDealersHistory
{
    public int HistRecId { get; set; }

    public string? Action { get; set; }

    public string? Username { get; set; }

    public int RecId { get; set; }

    public int CustomerId { get; set; }

    public string? ContactName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public int Id { get; set; }
}

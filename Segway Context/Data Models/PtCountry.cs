using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PtCountry
{
    public int Id { get; set; }

    public string? RowId { get; set; }

    public string? EuCode { get; set; }

    public string? TerritoryCode { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? IsoNumericCode { get; set; }

    public string? AlternateTerritoryCode { get; set; }

    public int? LastUpdateLogin { get; set; }

    public string? NlsTerritory { get; set; }

    public string? AddressStyle { get; set; }

    public string? AddressValidation { get; set; }

    public string? BankInfoStyle { get; set; }

    public string? BankInfoValidation { get; set; }

    public string? ObsoleteFlag { get; set; }

    public string? TerritoryShortName { get; set; }

    public string? Description { get; set; }

    public string? IsoTerritoryCode { get; set; }
}

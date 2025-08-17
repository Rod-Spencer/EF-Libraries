using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SmpVdmPagingCarrierInfo
{
    public string? PagingServerName { get; set; }

    public decimal PagingCarrierId { get; set; }

    public string PagingCarrierName { get; set; } = null!;

    public decimal PagingCarrierType { get; set; }

    public decimal PagingCarrierTimeout { get; set; }

    public decimal PagingCarrierConnDelay { get; set; }

    public string? PagingCarrierProtocol { get; set; }

    public decimal PhoneCountryCode { get; set; }

    public decimal PhoneAreaCode { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? PhoneNumberSuffix { get; set; }
}

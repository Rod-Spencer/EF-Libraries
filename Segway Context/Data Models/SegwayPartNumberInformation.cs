using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SegwayPartNumberInformation
{
    public Guid Id { get; set; }

    public string? Category { get; set; }

    public string? PartNumber { get; set; }

    public string? PartType { get; set; }

    public string? Model { get; set; }

    public string? Status { get; set; }

    public string? TravelerColor { get; set; }

    public string? TravelerWatermark { get; set; }

    public string? TravelerCode { get; set; }

    public string? SerialType { get; set; }

    public string? SerialCode { get; set; }

    public string? LabelCode { get; set; }

    public string? Code { get; set; }

    public string? ItemRevision { get; set; }

    public string? BarTenderFileName { get; set; }

    public byte? IsDisplay { get; set; }

    public int Sitecode { get; set; }

    public string? SytelineItem { get; set; }
}

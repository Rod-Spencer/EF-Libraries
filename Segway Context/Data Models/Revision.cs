using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class Revision
{
    public int Id { get; set; }

    public string? PtSerialNumber { get; set; }

    public string? ManCuaSerialNumber { get; set; }

    public string? ManCuaPartNumber { get; set; }

    public string? ManCuaSwRevision { get; set; }

    public string? ManCubSerialNumber { get; set; }

    public string? ManCubPartNumber { get; set; }

    public string? ManCubSwRevision { get; set; }

    public DateTime? ManufacturedDate { get; set; }

    public string? UpdCuaSerialNumber { get; set; }

    public string? UpdCuaPartNumber { get; set; }

    public string? UpdCuaSwRevision { get; set; }

    public string? UpdCubSerialNumber { get; set; }

    public string? UpdCubPartNumber { get; set; }

    public string? UpdCubSwRevision { get; set; }

    public DateTime? ServiceDate { get; set; }

    public string? Region { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}

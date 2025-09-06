using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartPtConfiguration
{
    public int Id { get; set; }

    public string? SerialNumber { get; set; }

    public string? WorkOrder { get; set; }

    public string? Type { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? CuaSerial { get; set; }

    public string? CuaPartNumber { get; set; }

    public string? CuaSwVersion { get; set; }

    public DateTime? CuaDate { get; set; }

    public string? CuaUser { get; set; }

    public string? CubSerial { get; set; }

    public string? CubPartNumber { get; set; }

    public string? CubSwVersion { get; set; }

    public DateTime? CubDate { get; set; }

    public string? CubUser { get; set; }

    public string? BsaASerial { get; set; }

    public string? BsaAPartNumber { get; set; }

    public string? BsaASwVersion { get; set; }

    public DateTime? BsaADate { get; set; }

    public string? BsaAUser { get; set; }

    public string? BsaBSerial { get; set; }

    public string? BsaBPartNumber { get; set; }

    public string? BsaBSwVersion { get; set; }

    public DateTime? BsaBDate { get; set; }

    public string? BsaBUser { get; set; }

    public string? MotorrSerial { get; set; }

    public string? MotorrPartNumber { get; set; }

    public DateTime? MotorrDate { get; set; }

    public string? MotorrUser { get; set; }

    public string? MotorrType { get; set; }

    public string? MotorlSerial { get; set; }

    public string? MotorlPartNumber { get; set; }

    public DateTime? MotorlDate { get; set; }

    public string? MotorlUser { get; set; }

    public string? MotorlType { get; set; }

    public string? UicSerial { get; set; }

    public string? UicSid { get; set; }

    public string? UicPartNumber { get; set; }

    public string? UicSwVersion { get; set; }

    public DateTime? UicDate { get; set; }

    public string? UicUser { get; set; }

    public string? UicType { get; set; }

    public string? PivotSerial { get; set; }

    public string? PivotPartNumber { get; set; }

    public DateTime? PivotDate { get; set; }

    public string? PivotUser { get; set; }

    public string? Status { get; set; }
}

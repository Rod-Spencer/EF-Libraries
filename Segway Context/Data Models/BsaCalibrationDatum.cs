using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class BsaCalibrationDatum
{
    public int Id { get; set; }

    public string? BsaSerialNumber { get; set; }

    public string? Side { get; set; }

    public string? PtSerialNumber { get; set; }

    public int? CalStructureVersionId { get; set; }

    public int? CalStructureLength { get; set; }

    public int? BsaSerialNumberCal { get; set; }

    public string? ArsTempOffsetAtRefTemp { get; set; }

    public string? ArsTempGain { get; set; }

    public int? CalRefTemperature { get; set; }

    public string? RsOffsetAtRefTemp { get; set; }

    public string? RsOffsetTempco { get; set; }

    public string? RsScaleFactorCorrRefTemp { get; set; }

    public string? RsScaleFactorCorrTempco { get; set; }

    public string? AAccOffsetsAtRefTemp { get; set; }

    public string? BAccOffsetsAtRefTemp { get; set; }

    public string? AAccOffsetsTempco { get; set; }

    public string? BAccOffsetsTempco { get; set; }

    public string? AAccRotMatrixRefTemp { get; set; }

    public string? BAccRotMatrixRefTemp { get; set; }

    public string? AAccRotMatrixTempco { get; set; }

    public string? BAccRotMatrixTempco { get; set; }

    public int? ASteeringOneOverVrefQ16 { get; set; }

    public int? ASteeringOneOverMQ23 { get; set; }

    public int? ASteeringOffsetB { get; set; }

    public int? ASteeringAlphaOffset { get; set; }

    public int? BSteeringOneOverVrefQ16 { get; set; }

    public int? BSteeringOneOverMQ23 { get; set; }

    public int? BSteeringOffsetB { get; set; }

    public int? BSteeringAlphaOffset { get; set; }

    public int? BScaleFactor { get; set; }

    public string? TransformMartrix { get; set; }

    public string? VectorC { get; set; }

    public string? VectorD { get; set; }

    public int? CalDataCrc { get; set; }

    public string? BsaPartNumber { get; set; }

    public string? DateCode { get; set; }

    public string? BsaSerialNumberLabel { get; set; }

    public DateTime? TimeDateEntered { get; set; }
}

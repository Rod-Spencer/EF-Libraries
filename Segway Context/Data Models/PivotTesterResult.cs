using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class PivotTesterResult
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Serial { get; set; } = null!;

    public string Nest { get; set; } = null!;

    public string Status { get; set; } = null!;

    public double? VerifysuppliesMeasureps { get; set; }

    public double? VerifysuppliesMeasurepsA { get; set; }

    public double? VerifysuppliesMeasurepsB { get; set; }

    public double? D45CcwMeasurea45Ccw { get; set; }

    public double? D45CcwMeasureb45Ccw { get; set; }

    public double? D45CcwMeasuretorque45Ccw { get; set; }

    public int? D45CcwReportcount45Ccw { get; set; }

    public double? TimetozerofromccwTimetozeroFromccw { get; set; }

    public double? D45CwMeasurea45Cw { get; set; }

    public double? D45CwMeasureb45Cw { get; set; }

    public double? D45CwMeasuretorque45Cw { get; set; }

    public int? D45CwReportcount45Cw { get; set; }

    public double? TimetozerofromcwTimetozeroFromcw { get; set; }

    public double? D22p5CcwMeasurea22p5Ccw { get; set; }

    public double? D22p5CcwMeasureb22p5Ccw { get; set; }

    public double? D22p5CcwMeasuretorque22p5Ccw { get; set; }

    public int? D22p5CcwReportcount22p5Ccw { get; set; }

    public double? D22p5CwMeasurea22p5Cw { get; set; }

    public double? D22p5CwMeasureb22p5Cw { get; set; }

    public double? D22p5CwMeasuretorque22p5Cw { get; set; }

    public int? D22p5CwReportcount22p5Cw { get; set; }

    public double? Cyclepivot45CwTimetozeroFromcw { get; set; }

    public double? Cyclepivot45CcwTimetozeroFromccw { get; set; }

    public double? VerifyzeroMeasuredifferentialVerify { get; set; }

    public double? VerifyzeroMeasureaVerify { get; set; }

    public double? VerifyzeroMeasurebVerify { get; set; }

    public double? VerifyzeroReportnumzeroingattempts { get; set; }

    public double? UnloaddutMeasuredifferentialFinish { get; set; }

    public double? SensorzeroingGotozeroposition { get; set; }

    public double? SensorzeroingMeasuredifferentialZero { get; set; }

    public double? FastensensorMeasuredifferentialFastened { get; set; }

    public double? D10CcwMeasuretorque10Ccw { get; set; }

    public double? D20CcwMeasuretorque20Ccw { get; set; }

    public double? D30CcwMeasuretorque30Ccw { get; set; }

    public double? D40CcwMeasuretorque40Ccw { get; set; }

    public double? D50CcwMeasuretorque50Ccw { get; set; }

    public double? D10CwMeasuretorque10Cw { get; set; }

    public double? D20CwMeasuretorque20Cw { get; set; }

    public double? D30CwMeasuretorque30Cw { get; set; }

    public double? D40CwMeasuretorque40Cw { get; set; }

    public double? D50CwMeasuretorque50Cw { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public Guid? Key { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class PowerSupplyTesterDatum
{
    public int TestId { get; set; }

    public string? PivotSerialNumber { get; set; }

    public string? AcInputSerialNumber { get; set; }

    public string? ChargerBoardSerialNumber { get; set; }

    public string? InterConnectBoardSerialNumber { get; set; }

    public double? Asct110Current { get; set; }

    public int? AsctStatus { get; set; }

    public double? Nlt12vA { get; set; }

    public double? Nlt12vB { get; set; }

    public int? NltStatus { get; set; }

    public double? Lt110Pwm000V110V220Current { get; set; }

    public double? Lt110Pwm000ALoadbnkVolt { get; set; }

    public double? Lt110Pwm000ALoadbnkCurr { get; set; }

    public double? Lt110Pwm000BLoadbnkVolt { get; set; }

    public double? Lt110Pwm000BLoadbnkCurr { get; set; }

    public double? Lt110Pwm025V110V220Current { get; set; }

    public double? Lt110Pwm025ALoadbnkVolt { get; set; }

    public double? Lt110Pwm025ALoadbnkCurr { get; set; }

    public double? Lt110Pwm025BLoadbnkVolt { get; set; }

    public double? Lt110Pwm025BLoadbnkCurr { get; set; }

    public double? Lt110Pwm050V110V220Current { get; set; }

    public double? Lt110Pwm050ALoadbnkVolt { get; set; }

    public double? Lt110Pwm050ALoadbnkCurr { get; set; }

    public double? Lt110Pwm050BLoadbnkVolt { get; set; }

    public double? Lt110Pwm050BLoadbnkCurr { get; set; }

    public double? Lt110Pwm075V110V220Current { get; set; }

    public double? Lt110Pwm075ALoadbnkVolt { get; set; }

    public double? Lt110Pwm075ALoadbnkCurr { get; set; }

    public double? Lt110Pwm075BLoadbnkVolt { get; set; }

    public double? Lt110Pwm075BLoadbnkCurr { get; set; }

    public double? Lt110Pwm100V110V220Current { get; set; }

    public double? Lt110Pwm100ALoadbnkVolt { get; set; }

    public double? Lt110Pwm100ALoadbnkCurr { get; set; }

    public double? Lt110Pwm100BLoadbnkVolt { get; set; }

    public double? Lt110Pwm100BLoadbnkCurr { get; set; }

    public int? Lt110Status { get; set; }

    public double? Lt220Pwm000V110V220Current { get; set; }

    public double? Lt220Pwm000ALoadbnkVolt { get; set; }

    public double? Lt220Pwm000ALoadbnkCurr { get; set; }

    public double? Lt220Pwm000BLoadbnkVolt { get; set; }

    public double? Lt220Pwm000BLoadbnkCurr { get; set; }

    public double? Lt220Pwm025V110V220Current { get; set; }

    public double? Lt220Pwm025ALoadbnkVolt { get; set; }

    public double? Lt220Pwm025ALoadbnkCurr { get; set; }

    public double? Lt220Pwm025BLoadbnkVolt { get; set; }

    public double? Lt220Pwm025BLoadbnkCurr { get; set; }

    public double? Lt220Pwm050V110V220Current { get; set; }

    public double? Lt220Pwm050ALoadbnkVolt { get; set; }

    public double? Lt220Pwm050ALoadbnkCurr { get; set; }

    public double? Lt220Pwm050BLoadbnkVolt { get; set; }

    public double? Lt220Pwm050BLoadbnkCurr { get; set; }

    public double? Lt220Pwm075V110V220Current { get; set; }

    public double? Lt220Pwm075ALoadbnkVolt { get; set; }

    public double? Lt220Pwm075ALoadbnkCurr { get; set; }

    public double? Lt220Pwm075BLoadbnkVolt { get; set; }

    public double? Lt220Pwm075BLoadbnkCurr { get; set; }

    public double? Lt220Pwm100V110V220Current { get; set; }

    public double? Lt220Pwm100ALoadbnkVolt { get; set; }

    public double? Lt220Pwm100ALoadbnkCurr { get; set; }

    public double? Lt220Pwm100BLoadbnkVolt { get; set; }

    public double? Lt220Pwm100BLoadbnkCurr { get; set; }

    public int? Lt220Status { get; set; }

    public double? ContWakeA { get; set; }

    public double? Cont12vA { get; set; }

    public double? Cont9vCua { get; set; }

    public double? ContCanlA { get; set; }

    public double? ContCanhA { get; set; }

    public double? ContWakeB { get; set; }

    public double? Cont12vB { get; set; }

    public double? Cont9vCub { get; set; }

    public double? ContCanlB { get; set; }

    public double? ContCanhB { get; set; }

    public double? ContDgndA { get; set; }

    public double? ContDgndB { get; set; }

    public double? ContV50refA { get; set; }

    public double? ContSteerA { get; set; }

    public double? ContV50refB { get; set; }

    public double? ContSteerB { get; set; }

    public double? ContVbatPlusB { get; set; }

    public int? ContStatus { get; set; }

    public int? HipotTestStatus { get; set; }

    public int? OverallTestStatus { get; set; }

    public string? UserName { get; set; }

    public string? SoftwareVersion { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public string? Comment { get; set; }
}

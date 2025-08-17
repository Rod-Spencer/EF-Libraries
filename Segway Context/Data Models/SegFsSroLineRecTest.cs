using System;
using System.Collections.Generic;

namespace Segway.EF.SegwayCntxt;

public partial class SegFsSroLineRecTest
{
    public string Createdby { get; set; } = null!;

    public string Updatedby { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public DateTime Recorddate { get; set; }

    public Guid Rowpointer { get; set; }

    public byte Noteexistsflag { get; set; }

    public byte Inworkflow { get; set; }

    public string SroNum { get; set; } = null!;

    public string SroLine { get; set; } = null!;

    public byte? MotordiagRcv { get; set; }

    public byte? MotordiagShp { get; set; }

    public byte? PwrbaseRcv { get; set; }

    public byte? PwrbaseShp { get; set; }

    public byte? UiRcv { get; set; }

    public byte? UiShp { get; set; }

    public byte? CsbRcv { get; set; }

    public byte? CsbShp { get; set; }

    public byte? HipotRcv { get; set; }

    public byte? HipotShp { get; set; }

    public byte? NormratiofailRcv { get; set; }

    public byte? NormratiofailShp { get; set; }

    public byte? Rcvdamaged { get; set; }

    public string? Batteries { get; set; }

    public byte? G1keysBlack { get; set; }

    public string? Infokeys { get; set; }

    public string? Kickstand { get; set; }

    public byte? Readytoquote { get; set; }

    public byte? Repaircompleted { get; set; }

    public byte? Transcompleted { get; set; }

    public byte? Prodshipped { get; set; }

    public string? Fenders { get; set; }

    public string? Hubcaps { get; set; }

    public string? Wheels { get; set; }

    public string? Consoletrim { get; set; }

    public string? Chargeport { get; set; }

    public string? Mats { get; set; }

    public string? Comfortmats { get; set; }

    public float? Laborhrs { get; set; }

    public DateTime? Datequoted { get; set; }

    public DateTime? Datecompleted { get; set; }

    public DateTime? Datetrans { get; set; }

    public DateTime? Dateshipped { get; set; }

    public string? Timea { get; set; }

    public string? Timeb { get; set; }

    public string? Faultloga { get; set; }

    public string? Faultlogb { get; set; }

    public string? Batterya { get; set; }

    public string? Batteryb { get; set; }

    public string? TirepsiRcv { get; set; }

    public string? TirepsiShp { get; set; }

    public string? Seriala { get; set; }

    public string? Serialb { get; set; }

    public byte? Passfaila { get; set; }

    public byte? Passfailb { get; set; }

    public string? Reva { get; set; }

    public string? Revb { get; set; }

    public string? Failreasona { get; set; }

    public string? Failreasonb { get; set; }

    public string? Errorcodenote { get; set; }

    public string? Observationsnote { get; set; }

    public string? Repairperformednote { get; set; }

    public string? Receivingnote { get; set; }

    public string? Quotenote { get; set; }

    public byte? G1keysYellow { get; set; }

    public byte? G1keysRed { get; set; }

    public byte? G1keysBlue { get; set; }

    public string? G1keysLegacy { get; set; }

    public string? AdditionalNotes { get; set; }

    public DateTime? ApprovalReceived { get; set; }

    public int? BsaCode { get; set; }

    public int? BsaFixed { get; set; }

    public int? CuACode { get; set; }

    public int? CuALog { get; set; }

    public int? CuALogClear { get; set; }

    public int? CuALogCode { get; set; }

    public int? CuBCode { get; set; }

    public int? CuBLog { get; set; }

    public int? CuBLogClear { get; set; }

    public int? CuBLogCode { get; set; }

    public int? ConfigureFinish { get; set; }

    public int? ConfigureStart { get; set; }

    public int? ConfigurationOverride { get; set; }

    public int? DiagMotorTest { get; set; }

    public int? DiagPowerbaseTest { get; set; }

    public int? DiagUiTest { get; set; }

    public int? DiagLedTest { get; set; }

    public int? DiagMotorLeftTest { get; set; }

    public int? DiagMotorRightTest { get; set; }

    public int? DiagRiderDefectTest { get; set; }

    public int? DiagBsaTest { get; set; }

    public int? DiagOtherTest { get; set; }

    public string? ErrorCode { get; set; }

    public int? ErrorCodeNoStart { get; set; }

    public int? ErrorCodeNone { get; set; }

    public string? HyperElcon { get; set; }

    public float? LaborHrsPb { get; set; }

    public DateTime? ManagementApproved { get; set; }

    public DateTime? ManagementRejected { get; set; }

    public string? Minutes { get; set; }

    public string? NewPbPn { get; set; }

    public string? NewPbSn { get; set; }

    public string? OdometerReading { get; set; }

    public string? OpsComments { get; set; }

    public string? Owner { get; set; }

    public string? PbServiceRequest { get; set; }

    public string? ProblemDescription { get; set; }

    public DateTime? ProductReceived { get; set; }

    public string? RepairPerformed { get; set; }

    public string? RepairType { get; set; }

    public string? ReportNumber { get; set; }

    public string? RmaNumber { get; set; }

    public string? SalesOrder { get; set; }

    public string? SegwayObservation { get; set; }

    public DateTime? StartDate1 { get; set; }

    public DateTime? StartDate2 { get; set; }

    public float? TirePsiLeftRcv { get; set; }

    public float? TirePsiRightRcv { get; set; }

    public float? TirePsiLeftShp { get; set; }

    public float? TirePsiRightShp { get; set; }

    public string? TirePsi { get; set; }

    public string? TirePsi1 { get; set; }

    public int? UnitCleaned { get; set; }

    public string? UnitCondition { get; set; }

    public int? WaitCustomerApproval { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Syteline;

public partial class SegFsSrolineRecTest
{
    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime RecordDate { get; set; }

    public Guid RowPointer { get; set; }

    public byte NoteExistsFlag { get; set; }

    public byte InWorkflow { get; set; }

    public string SroNum { get; set; } = null!;

    public int SroLine { get; set; }

    public byte? MotorDiagRcv { get; set; }

    public byte? MotorDiagShp { get; set; }

    public byte? PwrBaseRcv { get; set; }

    public byte? PwrBaseShp { get; set; }

    public byte? UiRcv { get; set; }

    public byte? UiShp { get; set; }

    public byte? CsbRcv { get; set; }

    public byte? CsbShp { get; set; }

    public byte? HiPotRcv { get; set; }

    public byte? HiPotShp { get; set; }

    public byte? NormRatioFailRcv { get; set; }

    public byte? NormRatioFailShp { get; set; }

    public byte? RcvDamaged { get; set; }

    public string? Batteries { get; set; }

    public string? InfoKeys { get; set; }

    public string? KickStand { get; set; }

    public byte? ReadyToQuote { get; set; }

    public byte? RepairCompleted { get; set; }

    public byte? TransCompleted { get; set; }

    public byte? ProdShipped { get; set; }

    public string? Fenders { get; set; }

    public string? HubCaps { get; set; }

    public string? Wheels { get; set; }

    public string? ConsoleTrim { get; set; }

    public string? ChargePort { get; set; }

    public string? Mats { get; set; }

    public string? ComfortMats { get; set; }

    public float? LaborHrs { get; set; }

    public DateTime? DateQuoted { get; set; }

    public DateTime? DateCompleted { get; set; }

    public DateTime? DateTrans { get; set; }

    public DateTime? DateShipped { get; set; }

    public string? TimeA { get; set; }

    public string? TimeB { get; set; }

    public string? FaultLogA { get; set; }

    public string? FaultLogB { get; set; }

    public float? BatteryA { get; set; }

    public float? BatteryB { get; set; }

    public string? SerialA { get; set; }

    public string? SerialB { get; set; }

    public byte? PassFailA { get; set; }

    public byte? PassFailB { get; set; }

    public string? RevA { get; set; }

    public string? RevB { get; set; }

    public string? FailReasonA { get; set; }

    public string? FailReasonB { get; set; }

    public string? ErrorCodeNote { get; set; }

    public string? ObservationsNote { get; set; }

    public string? RepairPerformedNote { get; set; }

    public string? ReceivingNote { get; set; }

    public string? QuoteNote { get; set; }

    public byte? G1keysYellow { get; set; }

    public byte? G1keysRed { get; set; }

    public byte? G1keysBlue { get; set; }

    public byte? G1keysBlack { get; set; }

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

    public int? ConfigureFinal { get; set; }

    public int? ConfigureStart { get; set; }

    public int? ConfigStartOverride { get; set; }

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

    public string? OdometerReadingA { get; set; }

    public string? OdometerReadingB { get; set; }

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

    public string? RefurbPb { get; set; }

    public byte? ConfigFinalOverride { get; set; }

    public string? OpenedBy { get; set; }
}

using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class SartWorkOrder
{
    public int Id { get; set; }

    public string? PtModel { get; set; }

    public string? PtSerial { get; set; }

    public string? PtPartNumber { get; set; }

    public string? WorkOrderId { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? EnteredBy { get; set; }

    public int? Status { get; set; }

    public string? AdditionalNotes { get; set; }

    public DateTime? ApprovalReceived { get; set; }

    public string? ASideTime { get; set; }

    public string? BatteryRbatFront { get; set; }

    public string? BatteryRbatRear { get; set; }

    public string? BatterySerialFront { get; set; }

    public string? BatterySerialRear { get; set; }

    public string? BatteryStatusFront { get; set; }

    public string? BatteryStatusRear { get; set; }

    public string? BattCommentsFront { get; set; }

    public string? BattCommentsRear { get; set; }

    public int? BsaCode { get; set; }

    public int? BsaFixed { get; set; }

    public string? BSideTime { get; set; }

    public string? CustomerComplaint { get; set; }

    public string? CustomerName { get; set; }

    public int? CuACode { get; set; }

    public int? CuALog { get; set; }

    public int? CuALogClear { get; set; }

    public int? CuALogCode { get; set; }

    public string? CuALogLink { get; set; }

    public int? CuBCode { get; set; }

    public int? CuBLog { get; set; }

    public int? CuBLogClear { get; set; }

    public int? CuBLogCode { get; set; }

    public string? CuBLogLink { get; set; }

    public int? ConfigureFinal { get; set; }

    public int? ConfigureStart { get; set; }

    public int? ConfigStartOverride { get; set; }

    public int? ConfigFinalOverride { get; set; }

    public DateTime? DateCompleted1 { get; set; }

    public DateTime? DateCompleted2 { get; set; }

    public int? DiagCsb { get; set; }

    public int? DiagCsb1 { get; set; }

    public int? DiagHipot { get; set; }

    public int? DiagHipot1 { get; set; }

    public int? DiagMotor { get; set; }

    public int? DiagMotor1 { get; set; }

    public int? DiagMotorTest { get; set; }

    public int? DiagNormRatio { get; set; }

    public int? DiagNormRatio1 { get; set; }

    public int? DiagPowerbase { get; set; }

    public int? DiagPowerbase1 { get; set; }

    public int? DiagPowerbaseTest { get; set; }

    public int? DiagUi { get; set; }

    public int? DiagUi1 { get; set; }

    public int? DiagUiTest { get; set; }

    public int? DiagLedTest { get; set; }

    public int? DiagMotorLeftTest { get; set; }

    public int? DiagMotorRightTest { get; set; }

    public int? DiagRiderDetectTest { get; set; }

    public int? DiagBsaTest { get; set; }

    public int? RideTest { get; set; }

    public string? ErrorCode { get; set; }

    public int? ErrorCodeNoStart { get; set; }

    public int? ErrorCodeNone { get; set; }

    public string? FailureReason1 { get; set; }

    public string? FailureReason2 { get; set; }

    public int GroupId { get; set; }

    public string? Hours { get; set; }

    public string? HyperElcon { get; set; }

    public double? LaborHours { get; set; }

    public double? LaborHoursPb { get; set; }

    public DateTime? ManagementApproved { get; set; }

    public DateTime? ManagementRejected { get; set; }

    public string? Minutes { get; set; }

    public string? NewPbPn { get; set; }

    public string? NewPbSn { get; set; }

    public string? OdometerReading { get; set; }

    public string? OpsComments { get; set; }

    public string? Owner { get; set; }

    public string? PbServiceRequest { get; set; }

    public string? PictureLinks { get; set; }

    public string? ProblemDescription { get; set; }

    public DateTime? ProductReceived { get; set; }

    public int? ProductShipped { get; set; }

    public string? QuoteNotes { get; set; }

    public DateTime? QuoteSent { get; set; }

    public string? RecBatteries { get; set; }

    public string? RecChargeport { get; set; }

    public string? RecComfortmats { get; set; }

    public string? RecConsoletrim { get; set; }

    public string? RecDamaged { get; set; }

    public string? RecFenders { get; set; }

    public string? RecG1Keys { get; set; }

    public string? RecHubcaps { get; set; }

    public string? RecInfokeys { get; set; }

    public string? RecKickstand { get; set; }

    public string? RecMats { get; set; }

    public string? RecNotes { get; set; }

    public string? RecWheels { get; set; }

    public string? RefurbPb { get; set; }

    public int? RepairComplete1 { get; set; }

    public int? RepairComplete2 { get; set; }

    public string? RepairPerformed { get; set; }

    public string? RepairType { get; set; }

    public string? ReportNumber { get; set; }

    public string? RmaNumber { get; set; }

    public string? SalesOrder { get; set; }

    public string? SegwayObservation { get; set; }

    public string? ServiceRequest { get; set; }

    public string? ServiceRequestId { get; set; }

    public DateTime? ShippedDate { get; set; }

    public DateTime? StartDate1 { get; set; }

    public DateTime? StartDate2 { get; set; }

    public string? TechnicianName1 { get; set; }

    public string? TechnicianName2 { get; set; }

    public string? TechnicianObservation { get; set; }

    public string? TirePassFail2 { get; set; }

    public int? TirePressure { get; set; }

    public string? TirePsiLeft { get; set; }

    public string? TirePsiRight { get; set; }

    public int? TransactionComplete { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? UnitCleaned { get; set; }

    public string? UnitCondition { get; set; }

    public string? UpdatedBy { get; set; }

    public int? WaitCustomerApproval { get; set; }

    public int Warranty { get; set; }

    public string? WorkingStatus { get; set; }

    public Guid? Rowpointer { get; set; }

    public decimal? TirePsiLeftRcv { get; set; }

    public decimal? TirePsiLeftShp { get; set; }

    public decimal? TirePsiRightRcv { get; set; }

    public decimal? TirePsiRightShp { get; set; }

    public string? OpenedBy { get; set; }

    public string? Priority { get; set; }

    public string? ErrorCodeNotes { get; set; }
}

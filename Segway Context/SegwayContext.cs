using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SpenSoft.EF.Segway;

public partial class SegwayContext : DbContext
{
    public SegwayContext()
    {
    }

    public SegwayContext(DbContextOptions<SegwayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AllowedUnitStatus> AllowedUnitStatuses { get; set; }

    public virtual DbSet<ArsDatum> ArsData { get; set; }

    public virtual DbSet<AssignedInvestigation> AssignedInvestigations { get; set; }

    public virtual DbSet<AttachDatum> AttachData { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<BackupBsaBlackBoxDatum> BackupBsaBlackBoxData { get; set; }

    public virtual DbSet<BatteryAssociationActivity> BatteryAssociationActivities { get; set; }

    public virtual DbSet<BatteryCharge> BatteryCharges { get; set; }

    public virtual DbSet<BatteryConfig> BatteryConfigs { get; set; }

    public virtual DbSet<BatteryOperationalDatum> BatteryOperationalData { get; set; }

    public virtual DbSet<BatteryTesterViewHistory> BatteryTesterViewHistories { get; set; }

    public virtual DbSet<BatteryV8Flash> BatteryV8Flashes { get; set; }

    public virtual DbSet<BcuDatum> BcuData { get; set; }

    public virtual DbSet<BcuLogDatum> BcuLogData { get; set; }

    public virtual DbSet<BcuTemperature> BcuTemperatures { get; set; }

    public virtual DbSet<BcuVoltage> BcuVoltages { get; set; }

    public virtual DbSet<BsaArsXref> BsaArsXrefs { get; set; }

    public virtual DbSet<BsaBlackBox> BsaBlackBoxes { get; set; }

    public virtual DbSet<BsaBlackBoxDatum> BsaBlackBoxData { get; set; }

    public virtual DbSet<BsaBlackBoxHeader> BsaBlackBoxHeaders { get; set; }

    public virtual DbSet<BsaCalibrationDatum> BsaCalibrationData { get; set; }

    public virtual DbSet<BsaExclusion> BsaExclusions { get; set; }

    public virtual DbSet<BsaInclusion> BsaInclusions { get; set; }

    public virtual DbSet<Bug> Bugs { get; set; }

    public virtual DbSet<CkdConversion> CkdConversions { get; set; }

    public virtual DbSet<Component> Components { get; set; }

    public virtual DbSet<ComponentsV1> ComponentsV1s { get; set; }

    public virtual DbSet<ConvertedModelSerial> ConvertedModelSerials { get; set; }

    public virtual DbSet<CuFaultLog> CuFaultLogs { get; set; }

    public virtual DbSet<Cukit> Cukits { get; set; }

    public virtual DbSet<EpicSerialValidation> EpicSerialValidations { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public virtual DbSet<FailureTrackingDtl> FailureTrackingDtls { get; set; }

    public virtual DbSet<FailureTrackingHdr> FailureTrackingHdrs { get; set; }

    public virtual DbSet<FinalDisposition> FinalDispositions { get; set; }

    public virtual DbSet<FinalUnitDisposition> FinalUnitDispositions { get; set; }

    public virtual DbSet<FleetLookup> FleetLookups { get; set; }

    public virtual DbSet<FleetMaster> FleetMasters { get; set; }

    public virtual DbSet<FleetMasterBackup> FleetMasterBackups { get; set; }

    public virtual DbSet<FleetReservation> FleetReservations { get; set; }

    public virtual DbSet<FleetTransaction> FleetTransactions { get; set; }

    public virtual DbSet<FredDatum> FredData { get; set; }

    public virtual DbSet<FredDealerGroup> FredDealerGroups { get; set; }

    public virtual DbSet<FredKnockDown> FredKnockDowns { get; set; }

    public virtual DbSet<FsPriorCode> FsPriorCodes { get; set; }

    public virtual DbSet<FunctionalDatum> FunctionalData { get; set; }

    public virtual DbSet<FunctionalTest> FunctionalTests { get; set; }

    public virtual DbSet<G2CuLog> G2CuLogs { get; set; }

    public virtual DbSet<GenTestInfo> GenTestInfos { get; set; }

    public virtual DbSet<HoldBadKey> HoldBadKeys { get; set; }

    public virtual DbSet<InfoKeyAssignment> InfoKeyAssignments { get; set; }

    public virtual DbSet<InfoKeyConfigUsage> InfoKeyConfigUsages { get; set; }

    public virtual DbSet<InfoKeyErrorCode> InfoKeyErrorCodes { get; set; }

    public virtual DbSet<InfoKeyManufacture> InfoKeyManufactures { get; set; }

    public virtual DbSet<InfokeyConfigUsageAction> InfokeyConfigUsageActions { get; set; }

    public virtual DbSet<Key> Keys { get; set; }

    public virtual DbSet<KeyCode> KeyCodes { get; set; }

    public virtual DbSet<KnowledgeBase> KnowledgeBases { get; set; }

    public virtual DbSet<KnowledgebaseHistory> KnowledgebaseHistories { get; set; }

    public virtual DbSet<LastProcess> LastProcesses { get; set; }

    public virtual DbSet<LineReason> LineReasons { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Logfault> Logfaults { get; set; }

    public virtual DbSet<Manufacturing_Component_Assemblies> Manufacturing_Component_Assemblies { get; set; }

    public virtual DbSet<ManufacturingComponentComment> ManufacturingComponentComments { get; set; }

    public virtual DbSet<Manufacturing_Component_Data> Manufacturing_Component_Data { get; set; }

    public virtual DbSet<Manufacturing_Component_Events> Manufacturing_Component_Events { get; set; }

    public virtual DbSet<ManufacturingComponentGearBoxLot> ManufacturingComponentGearBoxLots { get; set; }

    public virtual DbSet<Manufacturing_Component_Serialized> Manufacturing_Component_Serialized { get; set; }

    public virtual DbSet<Manufacturing_Components> Manufacturing_Components { get; set; }

    public virtual DbSet<ManufacturingLocation> ManufacturingLocations { get; set; }

    public virtual DbSet<ManufacturingReason> ManufacturingReasons { get; set; }

    public virtual DbSet<ManufacturingReasonCode> ManufacturingReasonCodes { get; set; }

    public virtual DbSet<ManufacturingReasonLocation> ManufacturingReasonLocations { get; set; }

    public virtual DbSet<ManufacturingSerializedAssembly> ManufacturingSerializedAssemblies { get; set; }

    public virtual DbSet<ManufacturingSerializedComment> ManufacturingSerializedComments { get; set; }

    public virtual DbSet<ManufacturingSerializedComponent> ManufacturingSerializedComponents { get; set; }

    public virtual DbSet<ManufacturingSerializedComponentEvent> ManufacturingSerializedComponentEvents { get; set; }

    public virtual DbSet<MdtDetail> MdtDetails { get; set; }

    public virtual DbSet<MdtMaster> MdtMasters { get; set; }

    public virtual DbSet<Microsoftdtproperty> Microsoftdtproperties { get; set; }

    public virtual DbSet<MiniProProduct> MiniProProducts { get; set; }

    public virtual DbSet<MiniProTracking> MiniProTrackings { get; set; }

    public virtual DbSet<MiniProTrackingCode> MiniProTrackingCodes { get; set; }

    public virtual DbSet<ModelNumber> ModelNumbers { get; set; }

    public virtual DbSet<MotorNormRatioTest> MotorNormRatioTests { get; set; }

    public virtual DbSet<NewConfig> NewConfigs { get; set; }

    public virtual DbSet<NineBotPartNumber> NineBotPartNumbers { get; set; }

    public virtual DbSet<ObcAssembly> ObcAssemblies { get; set; }

    public virtual DbSet<ObcTest> ObcTests { get; set; }

    public virtual DbSet<ObcTestDetail> ObcTestDetails { get; set; }

    public virtual DbSet<PartNumber> PartNumbers { get; set; }

    public virtual DbSet<PivotSensor> PivotSensors { get; set; }

    public virtual DbSet<PivotSensorTemp> PivotSensorTemps { get; set; }

    public virtual DbSet<PivotTesterResult> PivotTesterResults { get; set; }

    public virtual DbSet<PowerSupplyTesterDatum> PowerSupplyTesterData { get; set; }

    public virtual DbSet<Problemcode> Problemcodes { get; set; }

    public virtual DbSet<ProductionLineAssembly> ProductionLineAssemblies { get; set; }

    public virtual DbSet<ProductionLineAssembly1> ProductionLineAssemblies1 { get; set; }

    public virtual DbSet<ProductionLineAssemblyBack> ProductionLineAssemblyBacks { get; set; }

    public virtual DbSet<ProductionLineAssemblyReason> ProductionLineAssemblyReasons { get; set; }

    public virtual DbSet<ProductionLineAssemblyScrapped> ProductionLineAssemblyScrappeds { get; set; }

    public virtual DbSet<ProductionLineBaseConfig> ProductionLineBaseConfigs { get; set; }

    public virtual DbSet<ProductionLineMotorOverride> ProductionLineMotorOverrides { get; set; }

    public virtual DbSet<ProductionLookup> ProductionLookups { get; set; }

    public virtual DbSet<PtBatteriesHistory> PtBatteriesHistories { get; set; }

    public virtual DbSet<PtBattery> PtBatteries { get; set; }

    public virtual DbSet<PtCertifiedUsed> PtCertifiedUseds { get; set; }

    public virtual DbSet<PtCountry> PtCountries { get; set; }

    public virtual DbSet<PtCustomer> PtCustomers { get; set; }

    public virtual DbSet<PtCustomersHistory> PtCustomersHistories { get; set; }

    public virtual DbSet<PtDealer> PtDealers { get; set; }

    public virtual DbSet<PtDealersHistory> PtDealersHistories { get; set; }

    public virtual DbSet<PtOpenOrder> PtOpenOrders { get; set; }

    public virtual DbSet<PtRegistration> PtRegistrations { get; set; }

    public virtual DbSet<PtRegistrationHistory> PtRegistrationHistories { get; set; }

    public virtual DbSet<PtShipmentOverride> PtShipmentOverrides { get; set; }

    public virtual DbSet<PtShippingDate> PtShippingDates { get; set; }

    public virtual DbSet<PT_US_Cities> PT_US_Cities { get; set; }

    public virtual DbSet<ReleaseNote> ReleaseNotes { get; set; }

    public virtual DbSet<Revision> Revisions { get; set; }

    public virtual DbSet<Rework> Reworks { get; set; }

    public virtual DbSet<ReworkLookup> ReworkLookups { get; set; }

    public virtual DbSet<ReworkReason> ReworkReasons { get; set; }

    public virtual DbSet<ReworkTicket> ReworkTickets { get; set; }

    public virtual DbSet<ReworkticketBackup> ReworkticketBackups { get; set; }

    public virtual DbSet<RideTest> RideTests { get; set; }

    public virtual DbSet<RmtPivotAssembly> RmtPivotAssemblies { get; set; }

    public virtual DbSet<RmtPtAssembly> RmtPtAssemblies { get; set; }

    public virtual DbSet<RuntimeLog> RuntimeLogs { get; set; }

    public virtual DbSet<SartBsaTestLimit> SartBsaTestLimits { get; set; }

    public virtual DbSet<SartCoffFile> SartCoffFiles { get; set; }

    public virtual DbSet<SartCuLog> SartCuLogs { get; set; }

    public virtual DbSet<SartCuLogsB> SartCuLogsBs { get; set; }

    public virtual DbSet<SartDisclaimer> SartDisclaimers { get; set; }

    public virtual DbSet<SartEvent> SartEvents { get; set; }

    public virtual DbSet<SartEventLogEntry> SartEventLogEntries { get; set; }

    public virtual DbSet<SartEventObject> SartEventObjects { get; set; }

    public virtual DbSet<SartEventType> SartEventTypes { get; set; }

    public virtual DbSet<SartJtagVisibility> SartJtagVisibilities { get; set; }

    public virtual DbSet<SartMotorDiagnosticDatum> SartMotorDiagnosticData { get; set; }

    public virtual DbSet<SartMotorDiagnosticGraphDatum> SartMotorDiagnosticGraphData { get; set; }

    public virtual DbSet<SartMotorDiagnosticGraphTest> SartMotorDiagnosticGraphTests { get; set; }

    public virtual DbSet<SartMotorDiagnosticGraphValue> SartMotorDiagnosticGraphValues { get; set; }

    public virtual DbSet<SartPicture> SartPictures { get; set; }

    public virtual DbSet<SartPtConfiguration> SartPtConfigurations { get; set; }

    public virtual DbSet<SartRepairApprovalCode> SartRepairApprovalCodes { get; set; }

    public virtual DbSet<SartRepairBillingCode> SartRepairBillingCodes { get; set; }

    public virtual DbSet<SartRepairChangeCode> SartRepairChangeCodes { get; set; }

    public virtual DbSet<SartRepairInstalledCode> SartRepairInstalledCodes { get; set; }

    public virtual DbSet<SartRepairLocationCode> SartRepairLocationCodes { get; set; }

    public virtual DbSet<SartRideTest> SartRideTests { get; set; }

    public virtual DbSet<SartSetting> SartSettings { get; set; }

    public virtual DbSet<SartSroType> SartSroTypes { get; set; }

    public virtual DbSet<SartUser> SartUsers { get; set; }

    public virtual DbSet<SartUserSetting> SartUserSettings { get; set; }

    public virtual DbSet<SartWoComponent> SartWoComponents { get; set; }

    public virtual DbSet<SartWorkOrder> SartWorkOrders { get; set; }

    public virtual DbSet<Se3OnboardSoftware> Se3OnboardSoftwares { get; set; }

    public virtual DbSet<Se3OnboardSoftware1> Se3OnboardSoftwares1 { get; set; }

    public virtual DbSet<Se3ThrottleCalibrationValue> Se3ThrottleCalibrationValues { get; set; }

    public virtual DbSet<Security> Securities { get; set; }

    public virtual DbSet<SegFsSroLineRecTest> SegFsSroLineRecTests { get; set; }

    public virtual DbSet<Segs4VetsUnit> Segs4VetsUnits { get; set; }

    public virtual DbSet<SegwayBattery> SegwayBatteries { get; set; }

    public virtual DbSet<SegwayBatteryTemperature> SegwayBatteryTemperatures { get; set; }

    public virtual DbSet<SegwayBatteryUserDatum> SegwayBatteryUserData { get; set; }

    public virtual DbSet<SegwayBatteryUserViewed> SegwayBatteryUserVieweds { get; set; }

    public virtual DbSet<SegwayBatteryUserViewedNew> SegwayBatteryUserViewedNews { get; set; }

    public virtual DbSet<SegwayBatteryValanceFault> SegwayBatteryValanceFaults { get; set; }

    public virtual DbSet<SegwayBatteryVoltage> SegwayBatteryVoltages { get; set; }

    public virtual DbSet<SegwayDealerAccountXref> SegwayDealerAccountXrefs { get; set; }

    public virtual DbSet<SegwayInfoKey> SegwayInfoKeys { get; set; }

    public virtual DbSet<SegwayLogin> SegwayLogins { get; set; }

    public virtual DbSet<SegwayPartNumberInformation> SegwayPartNumberInformations { get; set; }

    public virtual DbSet<SegwayPartNumberProductionXref> SegwayPartNumberProductionXrefs { get; set; }

    public virtual DbSet<SegwayPartTypeXref> SegwayPartTypeXrefs { get; set; }

    public virtual DbSet<SegwayReplacementAddress> SegwayReplacementAddresses { get; set; }

    public virtual DbSet<SegwayRetainer> SegwayRetainers { get; set; }

    public virtual DbSet<SegwayRmaReturnStatus> SegwayRmaReturnStatuses { get; set; }

    public virtual DbSet<SegwaySaRPrimaryReturnStatus> SegwaySaRPrimaryReturnStatuses { get; set; }

    public virtual DbSet<SegwaySaRSecondaryReturnStatus> SegwaySaRSecondaryReturnStatuses { get; set; }

    public virtual DbSet<SegwayServiceMonitor> SegwayServiceMonitors { get; set; }

    public virtual DbSet<SegwayServiceMonitorArchive> SegwayServiceMonitorArchives { get; set; }

    public virtual DbSet<SegwayServiceMonitorDataArchive> SegwayServiceMonitorDataArchives { get; set; }

    public virtual DbSet<SegwayServiceMonitorDatum> SegwayServiceMonitorData { get; set; }

    public virtual DbSet<SegwayServiceMonitorNotification> SegwayServiceMonitorNotifications { get; set; }

    public virtual DbSet<SegwayWarehouseLocation> SegwayWarehouseLocations { get; set; }

    public virtual DbSet<SerialNumber> SerialNumbers { get; set; }

    public virtual DbSet<SerialNumbersBackup> SerialNumbersBackups { get; set; }

    public virtual DbSet<SerialNumbersGenerated> SerialNumbersGenerateds { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceIbutton> ServiceIbuttons { get; set; }

    public virtual DbSet<ServiceLookup> ServiceLookups { get; set; }

    public virtual DbSet<ServiceTable> ServiceTables { get; set; }

    public virtual DbSet<ServiceTech> ServiceTeches { get; set; }

    public virtual DbSet<ServiceTool> ServiceTools { get; set; }

    public virtual DbSet<ServiceToolsAuthenticationToken> ServiceToolsAuthenticationTokens { get; set; }

    public virtual DbSet<ServiceUser> ServiceUsers { get; set; }

    public virtual DbSet<ServiceUserAccess> ServiceUserAccesses { get; set; }

    public virtual DbSet<ShippingInstructionsComment> ShippingInstructionsComments { get; set; }

    public virtual DbSet<ShippingInstructionsDatum> ShippingInstructionsData { get; set; }

    public virtual DbSet<ShippingInstructionsSerial> ShippingInstructionsSerials { get; set; }

    public virtual DbSet<SmpVddOperationsTable> SmpVddOperationsTables { get; set; }

    public virtual DbSet<SmpVdfMaslist> SmpVdfMaslists { get; set; }

    public virtual DbSet<SmpVdmAddress> SmpVdmAddresses { get; set; }

    public virtual DbSet<SmpVdmGlobalInfo> SmpVdmGlobalInfos { get; set; }

    public virtual DbSet<SmpVdmLastNotifSeqPertype> SmpVdmLastNotifSeqPertypes { get; set; }

    public virtual DbSet<SmpVdmNotification> SmpVdmNotifications { get; set; }

    public virtual DbSet<SmpVdmNotificationDetail> SmpVdmNotificationDetails { get; set; }

    public virtual DbSet<SmpVdmNotificationNvpair> SmpVdmNotificationNvpairs { get; set; }

    public virtual DbSet<SmpVdmNotificationService> SmpVdmNotificationServices { get; set; }

    public virtual DbSet<SmpVdmPagingCarrierInfo> SmpVdmPagingCarrierInfos { get; set; }

    public virtual DbSet<SmpVdmSessionNotiftypePair> SmpVdmSessionNotiftypePairs { get; set; }

    public virtual DbSet<SmpVdsReposVersion> SmpVdsReposVersions { get; set; }

    public virtual DbSet<SmpVdsSessionsTable> SmpVdsSessionsTables { get; set; }

    public virtual DbSet<SmpVduCallbackTable> SmpVduCallbackTables { get; set; }

    public virtual DbSet<SmpVduObjectsTable> SmpVduObjectsTables { get; set; }

    public virtual DbSet<SmpVduPrincipalsTable> SmpVduPrincipalsTables { get; set; }

    public virtual DbSet<SmpVduPrivilegeTable> SmpVduPrivilegeTables { get; set; }

    public virtual DbSet<SmpVdvUser> SmpVdvUsers { get; set; }

    public virtual DbSet<Stage1BsaSecurity> Stage1BsaSecurities { get; set; }

    public virtual DbSet<Stage1CuSecurity> Stage1CuSecurities { get; set; }

    public virtual DbSet<Stage1FunctionalDatum> Stage1FunctionalData { get; set; }

    public virtual DbSet<Stage1FunctionalInfo> Stage1FunctionalInfos { get; set; }

    public virtual DbSet<Stage1FunctionalTest> Stage1FunctionalTests { get; set; }

    public virtual DbSet<Stage1Gearbox1> Stage1Gearbox1s { get; set; }

    public virtual DbSet<Stage1Gearbox2> Stage1Gearbox2s { get; set; }

    public virtual DbSet<Stage1Motor1> Stage1Motor1s { get; set; }

    public virtual DbSet<Stage1Motor2> Stage1Motor2s { get; set; }

    public virtual DbSet<Stage1PartNumber> Stage1PartNumbers { get; set; }

    public virtual DbSet<Stage1Partnum> Stage1Partnums { get; set; }

    public virtual DbSet<Stage2Console> Stage2Consoles { get; set; }

    public virtual DbSet<Stage2Cover> Stage2Covers { get; set; }

    public virtual DbSet<Stage2FunctionalDatum> Stage2FunctionalData { get; set; }

    public virtual DbSet<Stage2FunctionalInfo> Stage2FunctionalInfos { get; set; }

    public virtual DbSet<Stage2FunctionalTest> Stage2FunctionalTests { get; set; }

    public virtual DbSet<Stage2Pivot> Stage2Pivots { get; set; }

    public virtual DbSet<SteeringFunctionalDatum> SteeringFunctionalData { get; set; }

    public virtual DbSet<SupportTicketDatum> SupportTicketData { get; set; }

    public virtual DbSet<SytelineSroMaterialLineApprovalCode> SytelineSroMaterialLineApprovalCodes { get; set; }

    public virtual DbSet<SytelineSroMaterialLineBillingCode> SytelineSroMaterialLineBillingCodes { get; set; }

    public virtual DbSet<SytelineSroMaterialLineChangeCode> SytelineSroMaterialLineChangeCodes { get; set; }

    public virtual DbSet<SytelineSroMaterialLineInstalledCode> SytelineSroMaterialLineInstalledCodes { get; set; }

    public virtual DbSet<SytelineSroMaterialLineLocationCode> SytelineSroMaterialLineLocationCodes { get; set; }

    public virtual DbSet<TableSize> TableSizes { get; set; }

    public virtual DbSet<TempServiceUser> TempServiceUsers { get; set; }

    public virtual DbSet<Ticketindex> Ticketindices { get; set; }

    public virtual DbSet<TicketindexBackup> TicketindexBackups { get; set; }

    public virtual DbSet<UiConfig> UiConfigs { get; set; }

    public virtual DbSet<UicConfig> UicConfigs { get; set; }

    public virtual DbSet<UicConfigurationTestResult> UicConfigurationTestResults { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Valence_Battery_Master> ValenceBatteryMasters { get; set; }

    public virtual DbSet<ValidationMessage> ValidationMessages { get; set; }

    public virtual DbSet<VbatteryLookup> VbatteryLookups { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<XxxCustAddress> XxxCustAddresses { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var jsonSetting = new ConfigurationBuilder().AddJsonFile("appsettings-EF-Segway.json").Build();

        var connectionString = jsonSetting.GetConnectionString("SegwayContext");
        optionsBuilder.UseSqlServer(connectionString)
                   .LogTo(Console.WriteLine, LogLevel.Information)
                   .EnableSensitiveDataLogging();
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Server=.;Database=Segway_Production;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AllowedUnitStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Allowed_Unit_Statuses");

            entity.Property(e => e.Classification)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLASSIFICATION");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UnitStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UNIT_STATUS");
        });

        modelBuilder.Entity<ArsDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ARS_DATA");

            entity.Property(e => e.ArsSerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ARS_SERIAL_NUMBER");
            entity.Property(e => e.DatetimeCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME_CREATED");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mean0Degs25Degc).HasColumnName("MEAN_0_DEGS_25_DEGC");
            entity.Property(e => e.Mean0Degs5degc).HasColumnName("MEAN_0_DEGS_5DEGC");
            entity.Property(e => e.Mean0Degs60Degc).HasColumnName("MEAN_0_DEGS_60_DEGC");
            entity.Property(e => e.Mean200Degs25Degc).HasColumnName("MEAN_200_DEGS_25_DEGC");
            entity.Property(e => e.Mean200Degs5degc).HasColumnName("MEAN_200_DEGS_5DEGC");
            entity.Property(e => e.Mean200Degs60Degc).HasColumnName("MEAN_200_DEGS_60_DEGC");
            entity.Property(e => e.MeanNeg200Degs25Degc).HasColumnName("MEAN_NEG200_DEGS_25_DEGC");
            entity.Property(e => e.MeanNeg200Degs5degc).HasColumnName("MEAN_NEG200_DEGS_5DEGC");
            entity.Property(e => e.MeanNeg200Degs60Degc).HasColumnName("MEAN_NEG200_DEGS_60_DEGC");
            entity.Property(e => e.MeanTemp25Degc).HasColumnName("MEAN_TEMP_25_DEGC");
            entity.Property(e => e.MeanTemp25Degc2).HasColumnName("MEAN_TEMP_25_DEGC_2");
            entity.Property(e => e.MeanTemp5degc).HasColumnName("MEAN_TEMP_5DEGC");
            entity.Property(e => e.MeanTemp5degc2).HasColumnName("MEAN_TEMP_5DEGC_2");
            entity.Property(e => e.MeanTemp60Degc).HasColumnName("MEAN_TEMP_60_DEGC");
            entity.Property(e => e.MeanTemp60degc60Degc).HasColumnName("MEAN_TEMP_60DEGC_60_DEGC");
            entity.Property(e => e.Motion25Degc).HasColumnName("MOTION_25_DEGC");
            entity.Property(e => e.Motion5degc).HasColumnName("MOTION_5DEGC");
            entity.Property(e => e.Motion60Degc).HasColumnName("MOTION_60_DEGC");
            entity.Property(e => e.Neg200DegsMaxDev125Degc).HasColumnName("NEG200_DEGS_MAX_DEV_1_25_DEGC");
            entity.Property(e => e.Neg200DegsMaxDev15degc).HasColumnName("NEG200_DEGS_MAX_DEV_1_5DEGC");
            entity.Property(e => e.Neg200DegsMaxDev160Degc).HasColumnName("NEG200_DEGS_MAX_DEV_1_60_DEGC");
            entity.Property(e => e.Neg200DegsMaxDev225Degc).HasColumnName("NEG200_DEGS_MAX_DEV_2_25_DEGC");
            entity.Property(e => e.Neg200DegsMaxDev25degc).HasColumnName("NEG200_DEGS_MAX_DEV_2_5DEGC");
            entity.Property(e => e.Neg200DegsMaxDev260Degc).HasColumnName("NEG200_DEGS_MAX_DEV_2_60_DEGC");
            entity.Property(e => e.Neg200DegsMinDev125Degc).HasColumnName("NEG200_DEGS_MIN_DEV_1_25_DEGC");
            entity.Property(e => e.Neg200DegsMinDev15degc).HasColumnName("NEG200_DEGS_MIN_DEV_1_5DEGC");
            entity.Property(e => e.Neg200DegsMinDev160Degc).HasColumnName("NEG200_DEGS_MIN_DEV_1_60_DEGC");
            entity.Property(e => e.Neg200DegsMinDev225Degc).HasColumnName("NEG200_DEGS_MIN_DEV_2_25_DEGC");
            entity.Property(e => e.Neg200DegsMinDev25degc).HasColumnName("NEG200_DEGS_MIN_DEV_2_5DEGC");
            entity.Property(e => e.Neg200DegsMinDev260Degc).HasColumnName("NEG200_DEGS_MIN_DEV_2_60_DEGC");
            entity.Property(e => e.Nest).HasColumnName("NEST");
            entity.Property(e => e.Pos200DegsMaxDev125Degc).HasColumnName("POS200_DEGS_MAX_DEV_1_25_DEGC");
            entity.Property(e => e.Pos200DegsMaxDev15degc).HasColumnName("POS200_DEGS_MAX_DEV_1_5DEGC");
            entity.Property(e => e.Pos200DegsMaxDev160Degc).HasColumnName("POS200_DEGS_MAX_DEV_1_60_DEGC");
            entity.Property(e => e.Pos200DegsMaxDev225Degc).HasColumnName("POS200_DEGS_MAX_DEV_2_25_DEGC");
            entity.Property(e => e.Pos200DegsMaxDev25degc).HasColumnName("POS200_DEGS_MAX_DEV_2_5DEGC");
            entity.Property(e => e.Pos200DegsMaxDev260Degc).HasColumnName("POS200_DEGS_MAX_DEV_2_60_DEGC");
            entity.Property(e => e.Pos200DegsMinDev125Degc).HasColumnName("POS200_DEGS_MIN_DEV_1_25_DEGC");
            entity.Property(e => e.Pos200DegsMinDev15degc).HasColumnName("POS200_DEGS_MIN_DEV_1_5DEGC");
            entity.Property(e => e.Pos200DegsMinDev160Degc).HasColumnName("POS200_DEGS_MIN_DEV_1_60_DEGC");
            entity.Property(e => e.Pos200DegsMinDev225Degc).HasColumnName("POS200_DEGS_MIN_DEV_2_25_DEGC");
            entity.Property(e => e.Pos200DegsMinDev25degc).HasColumnName("POS200_DEGS_MIN_DEV_2_5DEGC");
            entity.Property(e => e.Pos200DegsMinDev260Degc).HasColumnName("POS200_DEGS_MIN_DEV_2_60_DEGC");
            entity.Property(e => e.ReportedTemp25Degc).HasColumnName("REPORTED_TEMP_25_DEGC");
            entity.Property(e => e.ReportedTemp5degc).HasColumnName("REPORTED_TEMP_5DEGC");
            entity.Property(e => e.ReportedTemp60Degc).HasColumnName("REPORTED_TEMP_60_DEGC");
            entity.Property(e => e.RmsAt60DegcFlow).HasColumnName("RMS_AT_60_DEGC_FLOW");
            entity.Property(e => e.RmsAt60DegcNoFlow).HasColumnName("RMS_AT_60_DEGC_NO_FLOW");
            entity.Property(e => e.Rs25oc).HasColumnName("RS25OC");
            entity.Property(e => e.Rs25sfcc).HasColumnName("RS25SFCC");
            entity.Property(e => e.Rs25tsoc).HasColumnName("RS25TSOC");
            entity.Property(e => e.Rsotcc).HasColumnName("RSOTCC");
            entity.Property(e => e.Rssfctcc).HasColumnName("RSSFCTCC");
            entity.Property(e => e.Rst25e0degs).HasColumnName("RST25E_0DEGS");
            entity.Property(e => e.Rst25e200degs).HasColumnName("RST25E_200DEGS");
            entity.Property(e => e.Rst25eNeg200degs).HasColumnName("RST25E_NEG200DEGS");
            entity.Property(e => e.Rst5oe0degs).HasColumnName("RST5OE_0DEGS");
            entity.Property(e => e.Rst5oe200degs).HasColumnName("RST5OE_200DEGS");
            entity.Property(e => e.Rst5oeNeg200degs).HasColumnName("RST5OE_NEG200DEGS");
            entity.Property(e => e.Rst60oe0degs).HasColumnName("RST60OE_0DEGS");
            entity.Property(e => e.Rst60oe200degs).HasColumnName("RST60OE_200DEGS");
            entity.Property(e => e.Rst60oeNeg200degs).HasColumnName("RST60OE_NEG200DEGS");
            entity.Property(e => e.Rstssfc).HasColumnName("RSTSSFC");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Stddev0Degs25Degc).HasColumnName("STDDEV_0_DEGS_25_DEGC");
            entity.Property(e => e.Stddev0Degs5degc).HasColumnName("STDDEV_0_DEGS_5DEGC");
            entity.Property(e => e.Stddev0Degs60Degc).HasColumnName("STDDEV_0_DEGS_60_DEGC");
            entity.Property(e => e.Stddev200Degs25Degc).HasColumnName("STDDEV_200_DEGS_25_DEGC");
            entity.Property(e => e.Stddev200Degs5degc).HasColumnName("STDDEV_200_DEGS_5DEGC");
            entity.Property(e => e.Stddev200Degs60Degc).HasColumnName("STDDEV_200_DEGS_60_DEGC");
            entity.Property(e => e.StddevNeg200Degs25Degc).HasColumnName("STDDEV_NEG200_DEGS_25_DEGC");
            entity.Property(e => e.StddevNeg200Degs5degc).HasColumnName("STDDEV_NEG200_DEGS_5DEGC");
            entity.Property(e => e.StddevNeg200Degs60Degc).HasColumnName("STDDEV_NEG200_DEGS_60_DEGC");
            entity.Property(e => e.StddevTemp25Degc).HasColumnName("STDDEV_TEMP_25_DEGC");
            entity.Property(e => e.StddevTemp25Degc2).HasColumnName("STDDEV_TEMP_25_DEGC_2");
            entity.Property(e => e.StddevTemp5degc).HasColumnName("STDDEV_TEMP_5DEGC");
            entity.Property(e => e.StddevTemp5degc2).HasColumnName("STDDEV_TEMP_5DEGC_2");
            entity.Property(e => e.StddevTemp60Degc).HasColumnName("STDDEV_TEMP_60_DEGC");
            entity.Property(e => e.StddevTemp60degc60Degc).HasColumnName("STDDEV_TEMP_60DEGC_60_DEGC");
        });

        modelBuilder.Entity<AssignedInvestigation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ASSIGNED_INVESTIGATION", "REWORK");

            entity.Property(e => e.FinalUnitDisposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINAL_UNIT_DISPOSITION");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
        });

        modelBuilder.Entity<AttachDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("attach_data", "BugZilla");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Thedata).HasColumnName("thedata");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("attachments", "BugZilla");

            entity.Property(e => e.AttachId)
                .ValueGeneratedOnAdd()
                .HasColumnName("attach_id");
            entity.Property(e => e.BugId).HasColumnName("bug_id");
            entity.Property(e => e.CreationTs).HasColumnName("creation_ts");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("filename");
            entity.Property(e => e.Isobsolete)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("isobsolete");
            entity.Property(e => e.Ispatch).HasColumnName("ispatch");
            entity.Property(e => e.Isprivate)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("isprivate");
            entity.Property(e => e.Isurl)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("isurl");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("mimetype");
            entity.Property(e => e.SubmitterId)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("submitter_id");
        });

        modelBuilder.Entity<BackupBsaBlackBoxDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACKUP_BSA_Black_Box_Data");

            entity.Property(e => e.AccTemperature).HasColumnName("ACC_TEMPERATURE");
            entity.Property(e => e.AdjustedFrameCount).HasColumnName("ADJUSTED_FRAME_COUNT");
            entity.Property(e => e.Ars0).HasColumnName("ARS_0");
            entity.Property(e => e.Ars1).HasColumnName("ARS_1");
            entity.Property(e => e.Ars2).HasColumnName("ARS_2");
            entity.Property(e => e.Ars3).HasColumnName("ARS_3");
            entity.Property(e => e.Ars4).HasColumnName("ARS_4");
            entity.Property(e => e.BridgeCurrent).HasColumnName("BRIDGE_CURRENT");
            entity.Property(e => e.ControllerFlags).HasColumnName("CONTROLLER_FLAGS");
            entity.Property(e => e.CrcIsValid).HasColumnName("CRC_IS_VALID");
            entity.Property(e => e.CurrentLimit).HasColumnName("CURRENT_LIMIT");
            entity.Property(e => e.DesiredPitchOffset).HasColumnName("DESIRED_PITCH_OFFSET");
            entity.Property(e => e.DesiredYawCommand).HasColumnName("DESIRED_YAW_COMMAND");
            entity.Property(e => e.EntryCrc).HasColumnName("ENTRY_CRC");
            entity.Property(e => e.FrameCount).HasColumnName("FRAME_COUNT");
            entity.Property(e => e.HeaderKey).HasColumnName("HEADER_KEY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LeftMotorIq).HasColumnName("LEFT_MOTOR_IQ");
            entity.Property(e => e.LeftMotorVq).HasColumnName("LEFT_MOTOR_VQ");
            entity.Property(e => e.LeftTractionCommand).HasColumnName("LEFT_TRACTION_COMMAND");
            entity.Property(e => e.LeftWheelSpeed).HasColumnName("LEFT_WHEEL_SPEED");
            entity.Property(e => e.LocalPitchAcc).HasColumnName("LOCAL_PITCH_ACC");
            entity.Property(e => e.LocalRollAcc).HasColumnName("LOCAL_ROLL_ACC");
            entity.Property(e => e.LocalSteeringSensor).HasColumnName("LOCAL_STEERING_SENSOR");
            entity.Property(e => e.PitchAngle).HasColumnName("PITCH_ANGLE");
            entity.Property(e => e.PitchCommand).HasColumnName("PITCH_COMMAND");
            entity.Property(e => e.PitchRate).HasColumnName("PITCH_RATE");
            entity.Property(e => e.PseInfoBits).HasColumnName("PSE_INFO_BITS");
            entity.Property(e => e.Record).HasColumnName("RECORD");
            entity.Property(e => e.RightMotorIq).HasColumnName("RIGHT_MOTOR_IQ");
            entity.Property(e => e.RightMotorVq).HasColumnName("RIGHT_MOTOR_VQ");
            entity.Property(e => e.RightTractionCommand).HasColumnName("RIGHT_TRACTION_COMMAND");
            entity.Property(e => e.RightWheelSpeed).HasColumnName("RIGHT_WHEEL_SPEED");
            entity.Property(e => e.RollAngle).HasColumnName("ROLL_ANGLE");
            entity.Property(e => e.ShakeCommand).HasColumnName("SHAKE_COMMAND");
            entity.Property(e => e.SkTestWord1).HasColumnName("SK_TEST_WORD_1");
            entity.Property(e => e.SkTestWord2).HasColumnName("SK_TEST_WORD_2");
            entity.Property(e => e.SkTestWord3).HasColumnName("SK_TEST_WORD_3");
            entity.Property(e => e.SpeedLimit).HasColumnName("SPEED_LIMIT");
            entity.Property(e => e.StateBits).HasColumnName("STATE_BITS");
            entity.Property(e => e.SteeringCommand).HasColumnName("STEERING_COMMAND");
            entity.Property(e => e.SteeringReduction).HasColumnName("STEERING_REDUCTION");
            entity.Property(e => e.Vbus).HasColumnName("VBUS");
            entity.Property(e => e.YawCommand).HasColumnName("YAW_COMMAND");
            entity.Property(e => e.YawRate).HasColumnName("YAW_RATE");
        });

        modelBuilder.Entity<BatteryAssociationActivity>(entity =>
        {
            entity.ToTable("BatteryAssociationActivity");

            entity.HasIndex(e => e.DateTimeEntered, "IX_BatteryAssociationActivity_DateTimeEntered");

            entity.HasIndex(e => e.VehicleSerial, "IX_BatteryAssociationActivity_VehicleSerial");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Activity)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Battery1Serial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Battery2Serial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered).HasColumnType("datetime");
            entity.Property(e => e.VehiclePartNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VehicleSerial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BatteryCharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BATTERY_CHARGE", "REWORK");

            entity.Property(e => e.DateRecorded)
                .HasColumnType("date")
                .HasColumnName("DATE_RECORDED");
            entity.Property(e => e.PalletNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PALLET_NUMBER");
            entity.Property(e => e.RecordNumber)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("RECORD_NUMBER");
            entity.Property(e => e.Recorder)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RECORDER");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
        });

        modelBuilder.Entity<BatteryConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Battery_Config");

            entity.Property(e => e.BcuAPartnumRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_PARTNUM_REV");
            entity.Property(e => e.BcuASerialnumRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_SERIALNUM_REV");
            entity.Property(e => e.BcuASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_SW_REV");
            entity.Property(e => e.BcuBPartnumRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_PARTNUM_REV");
            entity.Property(e => e.BcuBSerialnumRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_SERIALNUM_REV");
            entity.Property(e => e.BcuBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_SW_REV");
            entity.Property(e => e.DateEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.ProductSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<BatteryOperationalDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Battery_Operational_Data");

            entity.Property(e => e.BcuSerialNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("BCU_SERIAL_NUMBER");
            entity.Property(e => e.BootLoaderPartNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOOT_LOADER_PART_NUMBER");
            entity.Property(e => e.BootLoaderRevNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOOT_LOADER_REV_NUMBER");
            entity.Property(e => e.CalibrationPartNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CALIBRATION_PART_NUMBER");
            entity.Property(e => e.CalibrationRevNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CALIBRATION_REV_NUMBER");
            entity.Property(e => e.CellChemistry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CELL_CHEMISTRY");
            entity.Property(e => e.ChargeProcessStatus).HasColumnName("CHARGE_PROCESS_STATUS");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FaultFlags).HasColumnName("FAULT_FLAGS");
            entity.Property(e => e.HazardFlags).HasColumnName("HAZARD_FLAGS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Invalid).HasColumnName("INVALID");
            entity.Property(e => e.Location)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LOCATION");
            entity.Property(e => e.ManufactureDate).HasColumnName("MANUFACTURE_DATE");
            entity.Property(e => e.OvervoltageIndicator).HasColumnName("OVERVOLTAGE_INDICATOR");
            entity.Property(e => e.PackCurrent).HasColumnName("PACK_CURRENT");
            entity.Property(e => e.PackRevNumber)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("PACK_REV_NUMBER");
            entity.Property(e => e.PackTemperature).HasColumnName("PACK_TEMPERATURE");
            entity.Property(e => e.PackVoltage).HasColumnName("PACK_VOLTAGE");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.SessionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SESSION_NAME");
            entity.Property(e => e.SoftwarePartNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_PART_NUMBER");
            entity.Property(e => e.SoftwareRevNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_REV_NUMBER");
            entity.Property(e => e.StateOfCharge).HasColumnName("STATE_OF_CHARGE");
            entity.Property(e => e.StateOfEnergy).HasColumnName("STATE_OF_ENERGY");
            entity.Property(e => e.StateOfPower).HasColumnName("STATE_OF_POWER");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.UndervoltageIndicator).HasColumnName("UNDERVOLTAGE_INDICATOR");
            entity.Property(e => e.WorkOrderNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_NUMBER");
        });

        modelBuilder.Entity<BatteryTesterViewHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Battery_Tester_View_History");

            entity.Property(e => e.BatterySerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_NUMBER");
            entity.Property(e => e.BatteryTestIdentifier).HasColumnName("BATTERY_TEST_IDENTIFIER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PtSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<BatteryV8Flash>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Battery_V8_Flash");

            entity.Property(e => e.BatterySerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL");
            entity.Property(e => e.FlashStatus).HasColumnName("FLASH_STATUS");
            entity.Property(e => e.LevelAfter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEVEL_AFTER");
            entity.Property(e => e.LevelBefore)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEVEL_BEFORE");
            entity.Property(e => e.MachineName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MACHINE_NAME");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.RevisionAfter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REVISION_AFTER");
            entity.Property(e => e.RevisionBefore)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REVISION_BEFORE");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<BcuDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BCU_Data");

            entity.Property(e => e.BcuSerialNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("BCU_SERIAL_NUMBER");
            entity.Property(e => e.BootLoaderPartNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOOT_LOADER_PART_NUMBER");
            entity.Property(e => e.BootLoaderRevNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOOT_LOADER_REV_NUMBER");
            entity.Property(e => e.CalibrationPartNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CALIBRATION_PART_NUMBER");
            entity.Property(e => e.CalibrationRevNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CALIBRATION_REV_NUMBER");
            entity.Property(e => e.CellChemistry)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CELL_CHEMISTRY");
            entity.Property(e => e.CellTemperature0).HasColumnName("CELL_TEMPERATURE_0");
            entity.Property(e => e.CellTemperature1).HasColumnName("CELL_TEMPERATURE_1");
            entity.Property(e => e.CellTemperature2).HasColumnName("CELL_TEMPERATURE_2");
            entity.Property(e => e.CellTemperature3).HasColumnName("CELL_TEMPERATURE_3");
            entity.Property(e => e.CellVoltage0).HasColumnName("CELL_VOLTAGE_0");
            entity.Property(e => e.CellVoltage1).HasColumnName("CELL_VOLTAGE_1");
            entity.Property(e => e.CellVoltage10).HasColumnName("CELL_VOLTAGE_10");
            entity.Property(e => e.CellVoltage11).HasColumnName("CELL_VOLTAGE_11");
            entity.Property(e => e.CellVoltage12).HasColumnName("CELL_VOLTAGE_12");
            entity.Property(e => e.CellVoltage13).HasColumnName("CELL_VOLTAGE_13");
            entity.Property(e => e.CellVoltage14).HasColumnName("CELL_VOLTAGE_14");
            entity.Property(e => e.CellVoltage15).HasColumnName("CELL_VOLTAGE_15");
            entity.Property(e => e.CellVoltage16).HasColumnName("CELL_VOLTAGE_16");
            entity.Property(e => e.CellVoltage17).HasColumnName("CELL_VOLTAGE_17");
            entity.Property(e => e.CellVoltage18).HasColumnName("CELL_VOLTAGE_18");
            entity.Property(e => e.CellVoltage19).HasColumnName("CELL_VOLTAGE_19");
            entity.Property(e => e.CellVoltage2).HasColumnName("CELL_VOLTAGE_2");
            entity.Property(e => e.CellVoltage20).HasColumnName("CELL_VOLTAGE_20");
            entity.Property(e => e.CellVoltage21).HasColumnName("CELL_VOLTAGE_21");
            entity.Property(e => e.CellVoltage22).HasColumnName("CELL_VOLTAGE_22");
            entity.Property(e => e.CellVoltage3).HasColumnName("CELL_VOLTAGE_3");
            entity.Property(e => e.CellVoltage4).HasColumnName("CELL_VOLTAGE_4");
            entity.Property(e => e.CellVoltage5).HasColumnName("CELL_VOLTAGE_5");
            entity.Property(e => e.CellVoltage6).HasColumnName("CELL_VOLTAGE_6");
            entity.Property(e => e.CellVoltage7).HasColumnName("CELL_VOLTAGE_7");
            entity.Property(e => e.CellVoltage8).HasColumnName("CELL_VOLTAGE_8");
            entity.Property(e => e.CellVoltage9).HasColumnName("CELL_VOLTAGE_9");
            entity.Property(e => e.ChargeProcessStatus).HasColumnName("CHARGE_PROCESS_STATUS");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FaultFlags).HasColumnName("FAULT_FLAGS");
            entity.Property(e => e.HazardFlags).HasColumnName("HAZARD_FLAGS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Invalid).HasColumnName("INVALID");
            entity.Property(e => e.Location)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LOCATION");
            entity.Property(e => e.ManufactureDate).HasColumnName("MANUFACTURE_DATE");
            entity.Property(e => e.OvervoltageIndicator).HasColumnName("OVERVOLTAGE_INDICATOR");
            entity.Property(e => e.PackCurrent).HasColumnName("PACK_CURRENT");
            entity.Property(e => e.PackRevNumber)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("PACK_REV_NUMBER");
            entity.Property(e => e.PackTemperature).HasColumnName("PACK_TEMPERATURE");
            entity.Property(e => e.PackVoltage).HasColumnName("PACK_VOLTAGE");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.SessionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SESSION_NAME");
            entity.Property(e => e.SoftwarePartNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_PART_NUMBER");
            entity.Property(e => e.SoftwareRevNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_REV_NUMBER");
            entity.Property(e => e.StateOfCharge).HasColumnName("STATE_OF_CHARGE");
            entity.Property(e => e.StateOfEnergy).HasColumnName("STATE_OF_ENERGY");
            entity.Property(e => e.StateOfPower).HasColumnName("STATE_OF_POWER");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.UndervoltageIndicator).HasColumnName("UNDERVOLTAGE_INDICATOR");
        });

        modelBuilder.Entity<BcuLogDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BCU_Log_Data");

            entity.Property(e => e.BcuRecId).HasColumnName("BCU_REC_ID");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.LogCode).HasColumnName("LOG_CODE");
            entity.Property(e => e.LogNumber).HasColumnName("LOG_NUMBER");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<BcuTemperature>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BCU_TEMPERATURES", "GENII");

            entity.Property(e => e.BatteryRecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("BATTERY_REC_ID");
            entity.Property(e => e.BlockNumber)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("BLOCK_NUMBER");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Temperature).HasColumnName("TEMPERATURE");
        });

        modelBuilder.Entity<BcuVoltage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BCU_VOLTAGES", "GENII");

            entity.Property(e => e.BatteryRecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("BATTERY_REC_ID");
            entity.Property(e => e.CellNumber)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("CELL_NUMBER");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Voltage).HasColumnName("VOLTAGE");
        });

        modelBuilder.Entity<BsaArsXref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_ARS_XREF");

            entity.Property(e => e.ArsSerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ARS_SERIAL_NUMBER");
            entity.Property(e => e.BsaSerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeTested)
                .HasPrecision(0)
                .HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<BsaBlackBox>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_Black_Box");

            entity.Property(e => e.BlackboxKey).HasColumnName("BLACKBOX_KEY");
            entity.Property(e => e.BsaSerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Side)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SIDE");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<BsaBlackBoxDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_Black_Box_Data");

            entity.Property(e => e.AccTemperature).HasColumnName("ACC_TEMPERATURE");
            entity.Property(e => e.AdjustedFrameCount).HasColumnName("ADJUSTED_FRAME_COUNT");
            entity.Property(e => e.Ars0).HasColumnName("ARS_0");
            entity.Property(e => e.Ars1).HasColumnName("ARS_1");
            entity.Property(e => e.Ars2).HasColumnName("ARS_2");
            entity.Property(e => e.Ars3).HasColumnName("ARS_3");
            entity.Property(e => e.Ars4).HasColumnName("ARS_4");
            entity.Property(e => e.BridgeCurrent).HasColumnName("BRIDGE_CURRENT");
            entity.Property(e => e.ControllerFlags).HasColumnName("CONTROLLER_FLAGS");
            entity.Property(e => e.CrcIsValid).HasColumnName("CRC_IS_VALID");
            entity.Property(e => e.CurrentLimit).HasColumnName("CURRENT_LIMIT");
            entity.Property(e => e.DesiredPitchOffset).HasColumnName("DESIRED_PITCH_OFFSET");
            entity.Property(e => e.DesiredYawCommand).HasColumnName("DESIRED_YAW_COMMAND");
            entity.Property(e => e.EntryCrc).HasColumnName("ENTRY_CRC");
            entity.Property(e => e.FrameCount).HasColumnName("FRAME_COUNT");
            entity.Property(e => e.HeaderKey).HasColumnName("HEADER_KEY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LeftMotorIq).HasColumnName("LEFT_MOTOR_IQ");
            entity.Property(e => e.LeftMotorVq).HasColumnName("LEFT_MOTOR_VQ");
            entity.Property(e => e.LeftTractionCommand).HasColumnName("LEFT_TRACTION_COMMAND");
            entity.Property(e => e.LeftWheelSpeed).HasColumnName("LEFT_WHEEL_SPEED");
            entity.Property(e => e.LocalPitchAcc).HasColumnName("LOCAL_PITCH_ACC");
            entity.Property(e => e.LocalRollAcc).HasColumnName("LOCAL_ROLL_ACC");
            entity.Property(e => e.LocalSteeringSensor).HasColumnName("LOCAL_STEERING_SENSOR");
            entity.Property(e => e.PitchAngle).HasColumnName("PITCH_ANGLE");
            entity.Property(e => e.PitchCommand).HasColumnName("PITCH_COMMAND");
            entity.Property(e => e.PitchRate).HasColumnName("PITCH_RATE");
            entity.Property(e => e.PseInfoBits).HasColumnName("PSE_INFO_BITS");
            entity.Property(e => e.Record).HasColumnName("RECORD");
            entity.Property(e => e.RightMotorIq).HasColumnName("RIGHT_MOTOR_IQ");
            entity.Property(e => e.RightMotorVq).HasColumnName("RIGHT_MOTOR_VQ");
            entity.Property(e => e.RightTractionCommand).HasColumnName("RIGHT_TRACTION_COMMAND");
            entity.Property(e => e.RightWheelSpeed).HasColumnName("RIGHT_WHEEL_SPEED");
            entity.Property(e => e.RollAngle).HasColumnName("ROLL_ANGLE");
            entity.Property(e => e.ShakeCommand).HasColumnName("SHAKE_COMMAND");
            entity.Property(e => e.SkTestWord1).HasColumnName("SK_TEST_WORD_1");
            entity.Property(e => e.SkTestWord2).HasColumnName("SK_TEST_WORD_2");
            entity.Property(e => e.SkTestWord3).HasColumnName("SK_TEST_WORD_3");
            entity.Property(e => e.SpeedLimit).HasColumnName("SPEED_LIMIT");
            entity.Property(e => e.StateBits).HasColumnName("STATE_BITS");
            entity.Property(e => e.SteeringCommand).HasColumnName("STEERING_COMMAND");
            entity.Property(e => e.SteeringReduction).HasColumnName("STEERING_REDUCTION");
            entity.Property(e => e.Vbus).HasColumnName("VBUS");
            entity.Property(e => e.YawCommand).HasColumnName("YAW_COMMAND");
            entity.Property(e => e.YawRate).HasColumnName("YAW_RATE");
        });

        modelBuilder.Entity<BsaBlackBoxHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_Black_Box_Header");

            entity.Property(e => e.BlackboxKey).HasColumnName("BLACKBOX_KEY");
            entity.Property(e => e.BsaLocalCommFaults).HasColumnName("BSA_LOCAL_COMM_FAULTS");
            entity.Property(e => e.BsaLocalModuleFaults).HasColumnName("BSA_LOCAL_MODULE_FAULTS");
            entity.Property(e => e.BsaLocalSensorFaults).HasColumnName("BSA_LOCAL_SENSOR_FAULTS");
            entity.Property(e => e.BsaRemoteCommFaults).HasColumnName("BSA_REMOTE_COMM_FAULTS");
            entity.Property(e => e.BsaRemoteModuleFaults).HasColumnName("BSA_REMOTE_MODULE_FAULTS");
            entity.Property(e => e.BsaRemoteSensorFaults).HasColumnName("BSA_REMOTE_SENSOR_FAULTS");
            entity.Property(e => e.BsaSoftwareVersion).HasColumnName("BSA_SOFTWARE_VERSION");
            entity.Property(e => e.Crc).HasColumnName("CRC");
            entity.Property(e => e.CuSoftwareVersion).HasColumnName("CU_SOFTWARE_VERSION");
            entity.Property(e => e.DataLogVersion).HasColumnName("DATA_LOG_VERSION");
            entity.Property(e => e.FaultWord1).HasColumnName("FAULT_WORD_1");
            entity.Property(e => e.FaultWord2).HasColumnName("FAULT_WORD_2");
            entity.Property(e => e.FaultWord3).HasColumnName("FAULT_WORD_3");
            entity.Property(e => e.FaultWord4).HasColumnName("FAULT_WORD_4");
            entity.Property(e => e.FrameCount).HasColumnName("FRAME_COUNT");
            entity.Property(e => e.HeaderKey).HasColumnName("HEADER_KEY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsCrcOk).HasColumnName("IS_CRC_OK");
            entity.Property(e => e.Log).HasColumnName("LOG");
            entity.Property(e => e.OperationTime).HasColumnName("OPERATION_TIME");
            entity.Property(e => e.PseStatusWord).HasColumnName("PSE_STATUS_WORD");
            entity.Property(e => e.PsefAzeromean).HasColumnName("PSEF_AZEROMEAN");
            entity.Property(e => e.PsefBzeromean).HasColumnName("PSEF_BZEROMEAN");
            entity.Property(e => e.RawRbat).HasColumnName("RAW_RBAT");
            entity.Property(e => e.RawVoc).HasColumnName("RAW_VOC");
            entity.Property(e => e.RecordIndex).HasColumnName("RECORD_INDEX");
        });

        modelBuilder.Entity<BsaCalibrationDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_Calibration_Data");

            entity.Property(e => e.AAccOffsetsAtRefTemp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("A_ACC_OFFSETS_AT_REF_TEMP");
            entity.Property(e => e.AAccOffsetsTempco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("A_ACC_OFFSETS_TEMPCO");
            entity.Property(e => e.AAccRotMatrixRefTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("A_ACC_ROT_MATRIX_REF_TEMP");
            entity.Property(e => e.AAccRotMatrixTempco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("A_ACC_ROT_MATRIX_TEMPCO");
            entity.Property(e => e.ASteeringAlphaOffset).HasColumnName("A_STEERING_ALPHA_OFFSET");
            entity.Property(e => e.ASteeringOffsetB).HasColumnName("A_STEERING_OFFSET_B");
            entity.Property(e => e.ASteeringOneOverMQ23).HasColumnName("A_STEERING_ONE_OVER_M_Q23");
            entity.Property(e => e.ASteeringOneOverVrefQ16).HasColumnName("A_STEERING_ONE_OVER_VREF_Q16");
            entity.Property(e => e.ArsTempGain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_TEMP_GAIN");
            entity.Property(e => e.ArsTempOffsetAtRefTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_TEMP_OFFSET_AT_REF_TEMP");
            entity.Property(e => e.BAccOffsetsAtRefTemp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("B_ACC_OFFSETS_AT_REF_TEMP");
            entity.Property(e => e.BAccOffsetsTempco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("B_ACC_OFFSETS_TEMPCO");
            entity.Property(e => e.BAccRotMatrixRefTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("B_ACC_ROT_MATRIX_REF_TEMP");
            entity.Property(e => e.BAccRotMatrixTempco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("B_ACC_ROT_MATRIX_TEMPCO");
            entity.Property(e => e.BScaleFactor).HasColumnName("B_SCALE_FACTOR");
            entity.Property(e => e.BSteeringAlphaOffset).HasColumnName("B_STEERING_ALPHA_OFFSET");
            entity.Property(e => e.BSteeringOffsetB).HasColumnName("B_STEERING_OFFSET_B");
            entity.Property(e => e.BSteeringOneOverMQ23).HasColumnName("B_STEERING_ONE_OVER_M_Q23");
            entity.Property(e => e.BSteeringOneOverVrefQ16).HasColumnName("B_STEERING_ONE_OVER_VREF_Q16");
            entity.Property(e => e.BsaPartNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BSA_PART_NUMBER");
            entity.Property(e => e.BsaSerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER");
            entity.Property(e => e.BsaSerialNumberCal).HasColumnName("BSA_SERIAL_NUMBER_CAL");
            entity.Property(e => e.BsaSerialNumberLabel)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER_LABEL");
            entity.Property(e => e.CalDataCrc).HasColumnName("CAL_DATA_CRC");
            entity.Property(e => e.CalRefTemperature).HasColumnName("CAL_REF_TEMPERATURE");
            entity.Property(e => e.CalStructureLength).HasColumnName("CAL_STRUCTURE_LENGTH");
            entity.Property(e => e.CalStructureVersionId).HasColumnName("CAL_STRUCTURE_VERSION_ID");
            entity.Property(e => e.DateCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DATE_CODE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PtSerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL_NUMBER");
            entity.Property(e => e.RsOffsetAtRefTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RS_OFFSET_AT_REF_TEMP");
            entity.Property(e => e.RsOffsetTempco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RS_OFFSET_TEMPCO");
            entity.Property(e => e.RsScaleFactorCorrRefTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RS_SCALE_FACTOR_CORR_REF_TEMP");
            entity.Property(e => e.RsScaleFactorCorrTempco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RS_SCALE_FACTOR_CORR_TEMPCO");
            entity.Property(e => e.Side)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SIDE");
            entity.Property(e => e.TimeDateEntered).HasColumnName("TIME_DATE_ENTERED");
            entity.Property(e => e.TransformMartrix)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TRANSFORM_MARTRIX");
            entity.Property(e => e.VectorC)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECTOR_C");
            entity.Property(e => e.VectorD)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECTOR_D");
        });

        modelBuilder.Entity<BsaExclusion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_EXCLUSION");

            entity.Property(e => e.BsaSerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<BsaInclusion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BSA_INCLUSION");

            entity.Property(e => e.BsaSerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Bug>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bugs", "BugZilla");

            entity.Property(e => e.Alias)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.AssignedTo).HasColumnName("Assigned_To");
            entity.Property(e => e.BugFileLoc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Bug_file_loc");
            entity.Property(e => e.BugId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Bug_ID");
            entity.Property(e => e.BugSeverity)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Bug_severity");
            entity.Property(e => e.BugStatus)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Bug_status");
            entity.Property(e => e.BugType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bug_type");
            entity.Property(e => e.CclistAccessible)
                .IsRequired()
                .HasDefaultValueSql("('1')")
                .HasColumnName("cclist_accessible");
            entity.Property(e => e.ComponentId).HasColumnName("component_id");
            entity.Property(e => e.CreationTs)
                .HasColumnType("datetime")
                .HasColumnName("Creation_ts");
            entity.Property(e => e.Deadline)
                .HasColumnType("datetime")
                .HasColumnName("deadline");
            entity.Property(e => e.DeltaTs)
                .HasColumnType("datetime")
                .HasColumnName("Delta_ts");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.EstimatedTime)
                .HasDefaultValueSql("('0.00')")
                .HasColumnName("estimated_time");
            entity.Property(e => e.Everconfirmed).HasColumnName("everconfirmed");
            entity.Property(e => e.Frequency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("frequency");
            entity.Property(e => e.ImplVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("impl_version");
            entity.Property(e => e.IsHidden).HasColumnName("is_hidden");
            entity.Property(e => e.KeyWords)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Lastdiffed)
                .HasColumnType("datetime")
                .HasColumnName("lastdiffed");
            entity.Property(e => e.LogsLoaded).HasColumnName("logs_loaded");
            entity.Property(e => e.OccurranceTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("occurrance_timestamp");
            entity.Property(e => e.OpSys)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Op_sys");
            entity.Property(e => e.Priority)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ProductId).HasColumnName("Product_id");
            entity.Property(e => e.QaContact).HasColumnName("qa_contact");
            entity.Property(e => e.RemainingTime)
                .HasDefaultValueSql("('0.00')")
                .HasColumnName("remaining_time");
            entity.Property(e => e.RepPlatform)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("rep_platform");
            entity.Property(e => e.Reporter).HasColumnName("reporter");
            entity.Property(e => e.ReporterAccessible)
                .IsRequired()
                .HasDefaultValueSql("('1')")
                .HasColumnName("reporter_accessible");
            entity.Property(e => e.Resolution)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("resolution");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Short_desc");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.StatusWhiteboard)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("status_whiteboard");
            entity.Property(e => e.TargetMilestone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('---')")
                .HasColumnName("target_milestone");
            entity.Property(e => e.Version)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("version");
            entity.Property(e => e.Votes).HasDefaultValueSql("('0')");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("work_order");
        });

        modelBuilder.Entity<CkdConversion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CKD_Conversion");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LabelPrinted).HasColumnName("LABEL_PRINTED");
            entity.Property(e => e.ManufacturingItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURING_ITEM");
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.TopLevelItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TOP_LEVEL_ITEM");
        });

        modelBuilder.Entity<Component>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COMPONENTS", "REWORK");

            entity.Property(e => e.Component1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPONENT");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
        });

        modelBuilder.Entity<ComponentsV1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COMPONENTS_V1", "REWORK");

            entity.Property(e => e.Component)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPONENT");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
        });

        modelBuilder.Entity<ConvertedModelSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("converted_model_serials");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Serial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
        });

        modelBuilder.Entity<CuFaultLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CU_Fault_Logs");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.CuSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL");
            entity.Property(e => e.CuSerialEpic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL_EPIC");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeExtracted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_EXTRACTED");
            entity.Property(e => e.Gen)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GEN");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.LogData)
                .HasMaxLength(1300)
                .IsUnicode(false)
                .HasColumnName("LOG_DATA");
            entity.Property(e => e.Odometer).HasColumnName("ODOMETER");
            entity.Property(e => e.OperatingTime).HasColumnName("OPERATING_TIME");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL");
            entity.Property(e => e.SartExtraction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SART_EXTRACTION");
            entity.Property(e => e.Side)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SIDE");
            entity.Property(e => e.SwBuild)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_BUILD");
            entity.Property(e => e.SwPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_PART_NUMBER");
            entity.Property(e => e.SwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_VERSION");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<Cukit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUKIT", "TESTMSTR");

            entity.Property(e => e.BuildCount)
                .HasMaxLength(20)
                .HasColumnName("BUILD_COUNT");
            entity.Property(e => e.CreateDate)
                .HasColumnType("date")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CuASerialNum)
                .HasMaxLength(50)
                .HasColumnName("CU_A_SERIAL_NUM");
            entity.Property(e => e.CuBSerialNum)
                .HasMaxLength(50)
                .HasColumnName("CU_B_SERIAL_NUM");
            entity.Property(e => e.FlashCuA)
                .HasMaxLength(50)
                .HasColumnName("FLASH_CU_A");
            entity.Property(e => e.FlashCuB)
                .HasMaxLength(50)
                .HasColumnName("FLASH_CU_B");
            entity.Property(e => e.FleetKey)
                .HasMaxLength(50)
                .HasColumnName("FLEET_KEY");
            entity.Property(e => e.ProductSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PRODUCT_SERIAL_NUMBER");
            entity.Property(e => e.ServiceKey)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_KEY");
            entity.Property(e => e.UserKey1)
                .HasMaxLength(50)
                .HasColumnName("USER_KEY_1");
            entity.Property(e => e.UserKey2)
                .HasMaxLength(50)
                .HasColumnName("USER_KEY_2");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("USERID");
        });

        modelBuilder.Entity<EpicSerialValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EPIC_Serial_Validation");

            entity.Property(e => e.Comments)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Epicstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EPICSTATUS");
            entity.Property(e => e.Firstfail)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRSTFAIL");
            entity.Property(e => e.Fixture)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIXTURE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Station)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATION");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Testbench)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TESTBENCH");
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENT_LOGS", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.FileSize)
                .HasColumnType("numeric(22, 0)")
                .HasColumnName("FILE_SIZE");
            entity.Property(e => e.FileTimestamp)
                .HasColumnType("date")
                .HasColumnName("FILE_TIMESTAMP");
            entity.Property(e => e.Filename)
                .HasMaxLength(256)
                .HasColumnName("FILENAME");
            entity.Property(e => e.HostFolder)
                .HasMaxLength(1024)
                .HasColumnName("HOST_FOLDER");
            entity.Property(e => e.LogContents).HasColumnName("LOG_CONTENTS");
            entity.Property(e => e.PtSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PT_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(22, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<FailureTrackingDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAILURE_TRACKING_DTL", "GENII");

            entity.Property(e => e.AnalysisNotes)
                .HasMaxLength(2048)
                .HasColumnName("ANALYSIS_NOTES");
            entity.Property(e => e.ComponentLotNumber)
                .HasMaxLength(50)
                .HasColumnName("COMPONENT_LOT_NUMBER");
            entity.Property(e => e.ComponentPartNumber)
                .HasMaxLength(50)
                .HasColumnName("COMPONENT_PART_NUMBER");
            entity.Property(e => e.ComponentSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("COMPONENT_SERIAL_NUMBER");
            entity.Property(e => e.FailureMessage)
                .HasMaxLength(2048)
                .HasColumnName("FAILURE_MESSAGE");
            entity.Property(e => e.FailureSubcategory)
                .HasMaxLength(50)
                .HasColumnName("FAILURE_SUBCATEGORY");
            entity.Property(e => e.FailureTrackingHdrId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("FAILURE_TRACKING_HDR_ID");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<FailureTrackingHdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAILURE_TRACKING_HDR", "GENII");

            entity.Property(e => e.AnalysisNotes)
                .HasMaxLength(2048)
                .HasColumnName("ANALYSIS_NOTES");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.FailureCategory)
                .HasMaxLength(50)
                .HasColumnName("FAILURE_CATEGORY");
            entity.Property(e => e.FailureMessage)
                .HasMaxLength(2048)
                .HasColumnName("FAILURE_MESSAGE");
            entity.Property(e => e.FailureStationId)
                .HasMaxLength(50)
                .HasColumnName("FAILURE_STATION_ID");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<FinalDisposition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FINAL_DISPOSITION", "REWORK");

            entity.Property(e => e.FinalDispositionLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_LOCATION");
            entity.Property(e => e.FinalDispositionid)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("FINAL_DISPOSITIONID");
        });

        modelBuilder.Entity<FinalUnitDisposition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FINAL_UNIT_DISPOSITION", "REWORK");

            entity.Property(e => e.FinalUnitDisposition1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINAL_UNIT_DISPOSITION");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
        });

        modelBuilder.Entity<FleetLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FLEET_LOOKUPS", "SERVMGR");

            entity.Property(e => e.Attribute1)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE1");
            entity.Property(e => e.Attribute2)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE2");
            entity.Property(e => e.Attribute3)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE3");
            entity.Property(e => e.Attribute4)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE4");
            entity.Property(e => e.Attribute5)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE5");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.LookupDescription)
                .HasMaxLength(100)
                .HasColumnName("LOOKUP_DESCRIPTION");
            entity.Property(e => e.LookupType)
                .HasMaxLength(20)
                .HasColumnName("LOOKUP_TYPE");
            entity.Property(e => e.LookupValue)
                .HasMaxLength(100)
                .HasColumnName("LOOKUP_VALUE");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<FleetMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FLEET_MASTER", "SERVMGR");

            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FleetIdNumber)
                .HasMaxLength(20)
                .HasColumnName("FLEET_ID_NUMBER");
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(20)
                .HasColumnName("MODEL_NUMBER");
            entity.Property(e => e.OwnerDepartment)
                .HasMaxLength(60)
                .HasColumnName("OWNER_DEPARTMENT");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.ResponsiblePerson)
                .HasMaxLength(60)
                .HasColumnName("RESPONSIBLE_PERSON");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("STATUS");
            entity.Property(e => e.UnitDescription)
                .HasMaxLength(2000)
                .HasColumnName("UNIT_DESCRIPTION");
            entity.Property(e => e.UnitLocation)
                .HasMaxLength(100)
                .HasColumnName("UNIT_LOCATION");
        });

        modelBuilder.Entity<FleetMasterBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FLEET_MASTER_BACKUP", "SERVMGR");

            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FleetIdNumber)
                .HasMaxLength(20)
                .HasColumnName("FLEET_ID_NUMBER");
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(20)
                .HasColumnName("MODEL_NUMBER");
            entity.Property(e => e.OwnerDepartment)
                .HasMaxLength(60)
                .HasColumnName("OWNER_DEPARTMENT");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.ResponsiblePerson)
                .HasMaxLength(60)
                .HasColumnName("RESPONSIBLE_PERSON");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("STATUS");
            entity.Property(e => e.UnitDescription)
                .HasMaxLength(2000)
                .HasColumnName("UNIT_DESCRIPTION");
            entity.Property(e => e.UnitLocation)
                .HasMaxLength(100)
                .HasColumnName("UNIT_LOCATION");
        });

        modelBuilder.Entity<FleetReservation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FLEET_RESERVATION", "SERVMGR");

            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(20)
                .HasColumnName("MODEL_NUMBER");
            entity.Property(e => e.OwnerDepartment)
                .HasMaxLength(60)
                .HasColumnName("OWNER_DEPARTMENT");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.RequiredSetup)
                .HasMaxLength(2000)
                .HasColumnName("REQUIRED_SETUP");
            entity.Property(e => e.ReservationEndDate)
                .HasColumnType("date")
                .HasColumnName("RESERVATION_END_DATE");
            entity.Property(e => e.ReservationStartDate)
                .HasColumnType("date")
                .HasColumnName("RESERVATION_START_DATE");
            entity.Property(e => e.ReservationStatus)
                .HasMaxLength(20)
                .HasColumnName("RESERVATION_STATUS");
            entity.Property(e => e.ResponsibleDepartment)
                .HasMaxLength(60)
                .HasColumnName("RESPONSIBLE_DEPARTMENT");
            entity.Property(e => e.ResponsiblePerson)
                .HasMaxLength(60)
                .HasColumnName("RESPONSIBLE_PERSON");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .HasColumnName("SERIAL_NUMBER");
        });

        modelBuilder.Entity<FleetTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FLEET_TRANSACTION", "SERVMGR");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(60)
                .HasColumnName("ADDRESS_LINE_1");
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(60)
                .HasColumnName("ADDRESS_LINE_2");
            entity.Property(e => e.AddressLine3)
                .HasMaxLength(60)
                .HasColumnName("ADDRESS_LINE_3");
            entity.Property(e => e.AsReceivedDescription)
                .HasMaxLength(2000)
                .HasColumnName("AS_RECEIVED_DESCRIPTION");
            entity.Property(e => e.AsShippedDescription)
                .HasMaxLength(2000)
                .HasColumnName("AS_SHIPPED_DESCRIPTION");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(60)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.ContactName)
                .HasMaxLength(60)
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(60)
                .HasColumnName("CONTACT_PHONE");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.ExpectedReceiptDate)
                .HasColumnType("date")
                .HasColumnName("EXPECTED_RECEIPT_DATE");
            entity.Property(e => e.HeaderId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("HEADER_ID");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.ReceivedDate)
                .HasColumnType("date")
                .HasColumnName("RECEIVED_DATE");
            entity.Property(e => e.ReservationEndDate)
                .HasColumnType("date")
                .HasColumnName("RESERVATION_END_DATE");
            entity.Property(e => e.ReservationStartDate)
                .HasColumnType("date")
                .HasColumnName("RESERVATION_START_DATE");
            entity.Property(e => e.ResponsibleDepartment)
                .HasMaxLength(60)
                .HasColumnName("RESPONSIBLE_DEPARTMENT");
            entity.Property(e => e.ResponsiblePerson)
                .HasMaxLength(60)
                .HasColumnName("RESPONSIBLE_PERSON");
            entity.Property(e => e.ShippedDate)
                .HasColumnType("date")
                .HasColumnName("SHIPPED_DATE");
            entity.Property(e => e.TransactionStatus)
                .HasMaxLength(20)
                .HasColumnName("TRANSACTION_STATUS");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(20)
                .HasColumnName("TRANSACTION_TYPE");
            entity.Property(e => e.UsageNotes)
                .HasMaxLength(2000)
                .HasColumnName("USAGE_NOTES");
        });

        modelBuilder.Entity<FredDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FRED_DATA");

            entity.Property(e => e.AffiliatedDealer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AFFILIATED_DEALER");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.CustomertypeInt).HasColumnName("CUSTOMERTYPE_INT");
            entity.Property(e => e.Dealer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEALER");
            entity.Property(e => e.DealerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEALER_ID");
            entity.Property(e => e.DealerName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("DEALER_NAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ModelString)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL_STRING");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.RegCustRecId).HasColumnName("REG_CUST_REC_ID");
            entity.Property(e => e.RegDealerId).HasColumnName("REG_DEALER_ID");
            entity.Property(e => e.RegionString)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REGION_STRING");
            entity.Property(e => e.Registered)
                .HasPrecision(0)
                .HasColumnName("REGISTERED");
            entity.Property(e => e.SarAccountId).HasColumnName("SAR_ACCOUNT_ID");
            entity.Property(e => e.SarCustAcct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAR_CUST_ACCT");
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.ShipType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SHIP_TYPE");
            entity.Property(e => e.Shipped)
                .HasColumnType("date")
                .HasColumnName("SHIPPED");
        });

        modelBuilder.Entity<FredDealerGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FRED_Dealer_Groups");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DealerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Dealer_Name");
            entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Group_Name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("User_Name");
        });

        modelBuilder.Entity<FredKnockDown>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FRED_KnockDown");

            entity.Property(e => e.Assembled)
                .HasColumnType("date")
                .HasColumnName("ASSEMBLED");
            entity.Property(e => e.Dealer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DEALER");
            entity.Property(e => e.Registered)
                .HasColumnType("date")
                .HasColumnName("REGISTERED");
            entity.Property(e => e.Ridetested)
                .HasColumnType("date")
                .HasColumnName("RIDETESTED");
            entity.Property(e => e.RowId).HasColumnName("ROW_ID");
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.Shipped)
                .HasColumnType("date")
                .HasColumnName("SHIPPED");
        });

        modelBuilder.Entity<FsPriorCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_prior_code");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.DaysFollowup).HasColumnName("days_followup");
            entity.Property(e => e.DaysLate).HasColumnName("days_late");
            entity.Property(e => e.DaysUntilWarning).HasColumnName("days_until_warning");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.FollowupBasis)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("followup_basis");
            entity.Property(e => e.HrsFollowup)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("hrs_followup");
            entity.Property(e => e.HrsLate)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("hrs_late");
            entity.Property(e => e.HrsUntilWarning)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("hrs_until_warning");
            entity.Property(e => e.LateBasis)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("late_basis");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .HasColumnName("prior_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.WarningBasis)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("warning_basis");
        });

        modelBuilder.Entity<FunctionalDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Functional_Data");

            entity.Property(e => e.BatteryVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_VOLTAGE_A");
            entity.Property(e => e.BatteryVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_VOLTAGE_B");
            entity.Property(e => e.ClMotorLDeltaTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_DELTA_TEMP");
            entity.Property(e => e.ClMotorLDeltaTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_DELTA_TIME");
            entity.Property(e => e.ClMotorLHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorLHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorLHighVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_VOLTAGE_A");
            entity.Property(e => e.ClMotorLHighVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_VOLTAGE_B");
            entity.Property(e => e.ClMotorLLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_SPEED_A");
            entity.Property(e => e.ClMotorLLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_SPEED_B");
            entity.Property(e => e.ClMotorLLowVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_VOLTAGE_A");
            entity.Property(e => e.ClMotorLLowVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_VOLTAGE_B");
            entity.Property(e => e.ClMotorLMedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_MED_SPEED_A");
            entity.Property(e => e.ClMotorLMedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_MED_SPEED_B");
            entity.Property(e => e.ClMotorLMedVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_MED_VOLTAGE_A");
            entity.Property(e => e.ClMotorLMedVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_MED_VOLTAGE_B");
            entity.Property(e => e.ClMotorLNegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorLNegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorLNegHighVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_VOLTAGE_A");
            entity.Property(e => e.ClMotorLNegHighVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_VOLTAGE_B");
            entity.Property(e => e.ClMotorLNegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_SPEED_A");
            entity.Property(e => e.ClMotorLNegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_SPEED_B");
            entity.Property(e => e.ClMotorLNegLowVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_VOLTAGE_A");
            entity.Property(e => e.ClMotorLNegLowVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_VOLTAGE_B");
            entity.Property(e => e.ClMotorLNegMedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_MED_SPEED_A");
            entity.Property(e => e.ClMotorLNegMedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_MED_SPEED_B");
            entity.Property(e => e.ClMotorLNegMedVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_MED_VOLTAGE_A");
            entity.Property(e => e.ClMotorLNegMedVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_MED_VOLTAGE_B");
            entity.Property(e => e.ClMotorLOffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_SPEED_A");
            entity.Property(e => e.ClMotorLOffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_SPEED_B");
            entity.Property(e => e.ClMotorLOffVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_VOLTAGE_A");
            entity.Property(e => e.ClMotorLOffVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_VOLTAGE_B");
            entity.Property(e => e.ClMotorRDeltaTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_DELTA_TEMP");
            entity.Property(e => e.ClMotorRDeltaTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_DELTA_TIME");
            entity.Property(e => e.ClMotorRHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorRHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorRHighVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_VOLTAGE_A");
            entity.Property(e => e.ClMotorRHighVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_VOLTAGE_B");
            entity.Property(e => e.ClMotorRLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_SPEED_A");
            entity.Property(e => e.ClMotorRLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_SPEED_B");
            entity.Property(e => e.ClMotorRLowVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_VOLTAGE_A");
            entity.Property(e => e.ClMotorRLowVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_VOLTAGE_B");
            entity.Property(e => e.ClMotorRMedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_MED_SPEED_A");
            entity.Property(e => e.ClMotorRMedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_MED_SPEED_B");
            entity.Property(e => e.ClMotorRMedVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_MED_VOLTAGE_A");
            entity.Property(e => e.ClMotorRMedVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_MED_VOLTAGE_B");
            entity.Property(e => e.ClMotorRNegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorRNegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorRNegHighVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_VOLTAGE_A");
            entity.Property(e => e.ClMotorRNegHighVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_VOLTAGE_B");
            entity.Property(e => e.ClMotorRNegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_SPEED_A");
            entity.Property(e => e.ClMotorRNegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_SPEED_B");
            entity.Property(e => e.ClMotorRNegLowVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_VOLTAGE_A");
            entity.Property(e => e.ClMotorRNegLowVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_VOLTAGE_B");
            entity.Property(e => e.ClMotorRNegMedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_MED_SPEED_A");
            entity.Property(e => e.ClMotorRNegMedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_MED_SPEED_B");
            entity.Property(e => e.ClMotorRNegMedVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_MED_VOLTAGE_A");
            entity.Property(e => e.ClMotorRNegMedVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_MED_VOLTAGE_B");
            entity.Property(e => e.ClMotorROffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_SPEED_A");
            entity.Property(e => e.ClMotorROffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_SPEED_B");
            entity.Property(e => e.ClMotorROffVoltageA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_VOLTAGE_A");
            entity.Property(e => e.ClMotorROffVoltageB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_VOLTAGE_B");
            entity.Property(e => e.OlAmp1HighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp1HighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp1HighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp1HighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp1LowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp1LowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp1LowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp1LowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp1LowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_SPEED_A");
            entity.Property(e => e.OlAmp1LowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_SPEED_B");
            entity.Property(e => e.OlAmp1MedCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_MED_CURRENT_A");
            entity.Property(e => e.OlAmp1MedCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_MED_CURRENT_B");
            entity.Property(e => e.OlAmp1MedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_MED_SPEED_A");
            entity.Property(e => e.OlAmp1MedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_MED_SPEED_B");
            entity.Property(e => e.OlAmp1NegHighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp1NegHighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp1NegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp1NegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp1NegLowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp1NegLowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp1NegLowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp1NegLowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp1NegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_SPEED_A");
            entity.Property(e => e.OlAmp1NegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_SPEED_B");
            entity.Property(e => e.OlAmp1NegMedCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_MED_CURRENT_A");
            entity.Property(e => e.OlAmp1NegMedCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_MED_CURRENT_B");
            entity.Property(e => e.OlAmp1NegMedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_MED_SPEED_A");
            entity.Property(e => e.OlAmp1NegMedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_MED_SPEED_B");
            entity.Property(e => e.OlAmp1OffCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_CURRENT_A");
            entity.Property(e => e.OlAmp1OffCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_CURRENT_B");
            entity.Property(e => e.OlAmp1OffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_SPEED_A");
            entity.Property(e => e.OlAmp1OffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_SPEED_B");
            entity.Property(e => e.OlAmp2HighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp2HighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp2HighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp2HighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp2LowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp2LowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp2LowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp2LowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp2LowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_SPEED_A");
            entity.Property(e => e.OlAmp2LowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_SPEED_B");
            entity.Property(e => e.OlAmp2MedCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_MED_CURRENT_A");
            entity.Property(e => e.OlAmp2MedCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_MED_CURRENT_B");
            entity.Property(e => e.OlAmp2MedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_MED_SPEED_A");
            entity.Property(e => e.OlAmp2MedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_MED_SPEED_B");
            entity.Property(e => e.OlAmp2NegHighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp2NegHighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp2NegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp2NegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp2NegLowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp2NegLowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp2NegLowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp2NegLowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp2NegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_SPEED_A");
            entity.Property(e => e.OlAmp2NegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_SPEED_B");
            entity.Property(e => e.OlAmp2NegMedCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_MED_CURRENT_A");
            entity.Property(e => e.OlAmp2NegMedCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_MED_CURRENT_B");
            entity.Property(e => e.OlAmp2NegMedSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_MED_SPEED_A");
            entity.Property(e => e.OlAmp2NegMedSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_MED_SPEED_B");
            entity.Property(e => e.OlAmp2OffCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_CURRENT_A");
            entity.Property(e => e.OlAmp2OffCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_CURRENT_B");
            entity.Property(e => e.OlAmp2OffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_SPEED_A");
            entity.Property(e => e.OlAmp2OffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_SPEED_B");
            entity.Property(e => e.RiderDetectAHighStat1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_HIGH_STAT_1");
            entity.Property(e => e.RiderDetectAHighStat2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_HIGH_STAT_2");
            entity.Property(e => e.RiderDetectAHighStat3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_HIGH_STAT_3");
            entity.Property(e => e.RiderDetectAHighStat4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_HIGH_STAT_4");
            entity.Property(e => e.RiderDetectALowStat1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_LOW_STAT_1");
            entity.Property(e => e.RiderDetectALowStat2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_LOW_STAT_2");
            entity.Property(e => e.RiderDetectALowStat3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_LOW_STAT_3");
            entity.Property(e => e.RiderDetectALowStat4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_LOW_STAT_4");
            entity.Property(e => e.RiderDetectAllOff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_ALL_OFF");
            entity.Property(e => e.RiderDetectBHighStat1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_HIGH_STAT_1");
            entity.Property(e => e.RiderDetectBHighStat2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_HIGH_STAT_2");
            entity.Property(e => e.RiderDetectBHighStat3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_HIGH_STAT_3");
            entity.Property(e => e.RiderDetectBHighStat4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_HIGH_STAT_4");
            entity.Property(e => e.RiderDetectBLowStat1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_LOW_STAT_1");
            entity.Property(e => e.RiderDetectBLowStat2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_LOW_STAT_2");
            entity.Property(e => e.RiderDetectBLowStat3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_LOW_STAT_3");
            entity.Property(e => e.RiderDetectBLowStat4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_LOW_STAT_4");
            entity.Property(e => e.RiderDetectCHighStat1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_HIGH_STAT_1");
            entity.Property(e => e.RiderDetectCHighStat2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_HIGH_STAT_2");
            entity.Property(e => e.RiderDetectCHighStat3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_HIGH_STAT_3");
            entity.Property(e => e.RiderDetectCHighStat4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_HIGH_STAT_4");
            entity.Property(e => e.RiderDetectCLowStat1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_LOW_STAT_1");
            entity.Property(e => e.RiderDetectCLowStat2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_LOW_STAT_2");
            entity.Property(e => e.RiderDetectCLowStat3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_LOW_STAT_3");
            entity.Property(e => e.RiderDetectCLowStat4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_LOW_STAT_4");
            entity.Property(e => e.RiderDetectStatus1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_STATUS_1");
            entity.Property(e => e.RiderDetectStatus2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_STATUS_2");
            entity.Property(e => e.RiderDetectStatus3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_STATUS_3");
            entity.Property(e => e.RiderDetectStatus4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_STATUS_4");
            entity.Property(e => e.StopButtonA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STOP_BUTTON_A");
            entity.Property(e => e.StopButtonB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STOP_BUTTON_B");
            entity.Property(e => e.TestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_ID");
            entity.Property(e => e.TiltPos1TiltX)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_1_TILT_X");
            entity.Property(e => e.TiltPos1TiltY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_1_TILT_Y");
            entity.Property(e => e.TiltPos2TiltX)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_2_TILT_X");
            entity.Property(e => e.TiltPos2TiltY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_2_TILT_Y");
            entity.Property(e => e.YawCcwA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CCW_A");
            entity.Property(e => e.YawCcwB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CCW_B");
            entity.Property(e => e.YawCenterACuA1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CENTER_A_CU_A_1");
            entity.Property(e => e.YawCenterACuA2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CENTER_A_CU_A_2");
            entity.Property(e => e.YawCenterBCuB1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CENTER_B_CU_B_1");
            entity.Property(e => e.YawCenterBCuB2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CENTER_B_CU_B_2");
            entity.Property(e => e.YawCwA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CW_A");
            entity.Property(e => e.YawCwB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CW_B");
            entity.Property(e => e.YawSlewRate1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_SLEW_RATE_1");
            entity.Property(e => e.YawSlewRate2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_SLEW_RATE_2");
        });

        modelBuilder.Entity<FunctionalTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Functional_Test");

            entity.Property(e => e.AllKeysStartUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALL_KEYS_START_UNIT");
            entity.Property(e => e.Assemble)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASSEMBLE");
            entity.Property(e => e.BatteryChargingSystem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_CHARGING_SYSTEM");
            entity.Property(e => e.BcuCommunicationVoltage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_COMMUNICATION_VOLTAGE");
            entity.Property(e => e.ClTestMotorLHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_HIGH");
            entity.Property(e => e.ClTestMotorLLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_LOW");
            entity.Property(e => e.ClTestMotorLMed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_MED");
            entity.Property(e => e.ClTestMotorLNegHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_NEG_HIGH");
            entity.Property(e => e.ClTestMotorLNegLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_NEG_LOW");
            entity.Property(e => e.ClTestMotorLNegMed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_NEG_MED");
            entity.Property(e => e.ClTestMotorLOff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_OFF");
            entity.Property(e => e.ClTestMotorRHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_HIGH");
            entity.Property(e => e.ClTestMotorRLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_LOW");
            entity.Property(e => e.ClTestMotorRMed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_MED");
            entity.Property(e => e.ClTestMotorRNegHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_NEG_HIGH");
            entity.Property(e => e.ClTestMotorRNegLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_NEG_LOW");
            entity.Property(e => e.ClTestMotorRNegMed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_NEG_MED");
            entity.Property(e => e.ClTestMotorROff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_OFF");
            entity.Property(e => e.ConfigurationValidation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONFIGURATION_VALIDATION");
            entity.Property(e => e.DisconnectFromTestStand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCONNECT_FROM_TEST_STAND");
            entity.Property(e => e.FlashManufacturingCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLASH_MANUFACTURING_CODE");
            entity.Property(e => e.FlashProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLASH_PRODUCT_CODE");
            entity.Property(e => e.FormatLogA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORMAT_LOG_A");
            entity.Property(e => e.FormatLogB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FORMAT_LOG_B");
            entity.Property(e => e.IButtonKeyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("I_BUTTON_KEY_CODE");
            entity.Property(e => e.IButtonRelayFrameFault)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("I_BUTTON_RELAY_FRAME_FAULT");
            entity.Property(e => e.LcdOperationGreen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LCD_OPERATION_GREEN");
            entity.Property(e => e.LcdOperationRed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LCD_OPERATION_RED");
            entity.Property(e => e.ModelIdNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL_ID_NUMBER");
            entity.Property(e => e.ModuleSerialNumbers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE_SERIAL_NUMBERS");
            entity.Property(e => e.OlTestAmp1High)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_HIGH");
            entity.Property(e => e.OlTestAmp1Low)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_LOW");
            entity.Property(e => e.OlTestAmp1Med)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_MED");
            entity.Property(e => e.OlTestAmp1NegHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_HIGH");
            entity.Property(e => e.OlTestAmp1NegLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_LOW");
            entity.Property(e => e.OlTestAmp1NegMed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_MED");
            entity.Property(e => e.OlTestAmp1Off)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_OFF");
            entity.Property(e => e.OlTestAmp2High)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_HIGH");
            entity.Property(e => e.OlTestAmp2Low)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_LOW");
            entity.Property(e => e.OlTestAmp2Med)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_MED");
            entity.Property(e => e.OlTestAmp2NegHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_HIGH");
            entity.Property(e => e.OlTestAmp2NegLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_LOW");
            entity.Property(e => e.OlTestAmp2NegMed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_MED");
            entity.Property(e => e.OlTestAmp2Off)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_OFF");
            entity.Property(e => e.PlacementInTestStand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACEMENT_IN_TEST_STAND");
            entity.Property(e => e.PropulsionTestInitiated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROPULSION_TEST_INITIATED");
            entity.Property(e => e.RiderDetectAHighWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_HIGH_WEIGHT");
            entity.Property(e => e.RiderDetectALowWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_A_LOW_WEIGHT");
            entity.Property(e => e.RiderDetectBHighWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_HIGH_WEIGHT");
            entity.Property(e => e.RiderDetectBLowWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_B_LOW_WEIGHT");
            entity.Property(e => e.RiderDetectCHighWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_HIGH_WEIGHT");
            entity.Property(e => e.RiderDetectCLowWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_C_LOW_WEIGHT");
            entity.Property(e => e.RiderDetectSwitches)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_SWITCHES");
            entity.Property(e => e.SerialIdNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL_ID_NUMBER");
            entity.Property(e => e.SpeakerOperation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPEAKER_OPERATION");
            entity.Property(e => e.StartUpAndRide)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("START_UP_AND_RIDE");
            entity.Property(e => e.StopButton)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STOP_BUTTON");
            entity.Property(e => e.TestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_ID");
            entity.Property(e => e.TiltPosition1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POSITION_1");
            entity.Property(e => e.TiltPosition2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POSITION_2");
            entity.Property(e => e.TurnLeft)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TURN_LEFT");
            entity.Property(e => e.TurnRight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TURN_RIGHT");
            entity.Property(e => e.UnitStart)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_START");
            entity.Property(e => e.UnplannedShutdownDetected)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UNPLANNED_SHUTDOWN_DETECTED");
            entity.Property(e => e.UnplannedShutdownResponse)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UNPLANNED_SHUTDOWN_RESPONSE");
            entity.Property(e => e.YawCenterPosition1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CENTER_POSITION_1");
            entity.Property(e => e.YawCenterPosition2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_CENTER_POSITION_2");
            entity.Property(e => e.YawReturnToCenter1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_RETURN_TO_CENTER_1");
            entity.Property(e => e.YawReturnToCenter2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YAW_RETURN_TO_CENTER_2");
        });

        modelBuilder.Entity<G2CuLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("G2_CU_Log");

            entity.Property(e => e.Channel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogBuild)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOG_BUILD");
            entity.Property(e => e.LogData)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("LOG_DATA");
            entity.Property(e => e.LogFileName)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("LOG_FILE_NAME");
            entity.Property(e => e.LogType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LOG_TYPE");
            entity.Property(e => e.Odometer).HasColumnName("ODOMETER");
            entity.Property(e => e.OperatingTime).HasColumnName("OPERATING_TIME");
            entity.Property(e => e.PrimaryLog).HasColumnName("PRIMARY_LOG");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.TimeStamp).HasColumnName("TIME_STAMP");
            entity.Property(e => e.Unit).HasColumnName("UNIT");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<GenTestInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GEN_TEST_INFO");

            entity.Property(e => e.BcuADateCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_DATE_CODE");
            entity.Property(e => e.BcuAPartNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_PART_NUM");
            entity.Property(e => e.BcuASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_SW_REV");
            entity.Property(e => e.BcuBDateCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_DATE_CODE");
            entity.Property(e => e.BcuBPartNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_PART_NUM");
            entity.Property(e => e.BcuBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_SW_REV");
            entity.Property(e => e.ConfigurationFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONFIGURATION_FILE_NAME");
            entity.Property(e => e.CuAPartNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_PART_NUM");
            entity.Property(e => e.CuASerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SERIAL_NUM");
            entity.Property(e => e.CuASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SW_REV");
            entity.Property(e => e.CuBPartNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_PART_NUM");
            entity.Property(e => e.CuBSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SERIAL_NUM");
            entity.Property(e => e.CuBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SW_REV");
            entity.Property(e => e.DateEntered)
                .HasPrecision(0)
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.DutATestSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DUT_A_TEST_SW_REV");
            entity.Property(e => e.DutBTestSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DUT_B_TEST_SW_REV");
            entity.Property(e => e.FirstTest)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FIRST_TEST");
            entity.Property(e => e.ImuASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_A_SW_REV");
            entity.Property(e => e.ImuBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_B_SW_REV");
            entity.Property(e => e.ImuPartNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_PART_NUM");
            entity.Property(e => e.ImuSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_SERIAL_NUM");
            entity.Property(e => e.LoginName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOGIN_NAME");
            entity.Property(e => e.OperatorTimeSec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERATOR_TIME_SEC");
            entity.Property(e => e.ProductPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_PART_NUMBER");
            entity.Property(e => e.ProductSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_SERIAL_NUMBER");
            entity.Property(e => e.ProgramTimeSec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROGRAM_TIME_SEC");
            entity.Property(e => e.TestDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_DATE");
            entity.Property(e => e.TestId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_ID");
            entity.Property(e => e.TesterDllVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TESTER_DLL_VERSION");
            entity.Property(e => e.TesterInterfaceVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TESTER_INTERFACE_VERSION");
            entity.Property(e => e.TotalTestDurationSec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOTAL_TEST_DURATION_SEC");
            entity.Property(e => e.UiASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_A_SW_REV");
            entity.Property(e => e.UiBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_B_SW_REV");
            entity.Property(e => e.UiPartNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_PART_NUM");
            entity.Property(e => e.UiSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SERIAL_NUM");
        });

        modelBuilder.Entity<HoldBadKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HOLD_BAD_KEYS", "SERVMGR");

            entity.Property(e => e.DateEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.DateRekeyed)
                .HasColumnType("date")
                .HasColumnName("DATE_REKEYED");
            entity.Property(e => e.FlashCuA)
                .HasMaxLength(50)
                .HasColumnName("FLASH_CU_A");
            entity.Property(e => e.FlashCuB)
                .HasMaxLength(50)
                .HasColumnName("FLASH_CU_B");
            entity.Property(e => e.FleetKey)
                .HasMaxLength(50)
                .HasColumnName("FLEET_KEY");
            entity.Property(e => e.ProductPartNumber)
                .HasMaxLength(50)
                .HasColumnName("PRODUCT_PART_NUMBER");
            entity.Property(e => e.ProductSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PRODUCT_SERIAL_NUMBER");
            entity.Property(e => e.Rmp)
                .HasMaxLength(3)
                .HasColumnName("RMP");
            entity.Property(e => e.ServiceKey)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_KEY");
            entity.Property(e => e.UserKey1)
                .HasMaxLength(50)
                .HasColumnName("USER_KEY_1");
            entity.Property(e => e.UserKey2)
                .HasMaxLength(50)
                .HasColumnName("USER_KEY_2");
        });

        modelBuilder.Entity<InfoKeyAssignment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoKey_Assignment");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.ElprotronicId).HasColumnName("ELPROTRONIC_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InstanceId).HasColumnName("INSTANCE_ID");
        });

        modelBuilder.Entity<InfoKeyConfigUsage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoKey_Config_Usage");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.ChannelSelection)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHANNEL_SELECTION");
            entity.Property(e => e.Checksum).HasColumnName("CHECKSUM");
            entity.Property(e => e.CryptoKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CRYPTO_KEY");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.FixtureSerialNumber).HasColumnName("FIXTURE_SERIAL_NUMBER");
            entity.Property(e => e.FobConfigFlags)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_CONFIG_FLAGS");
            entity.Property(e => e.FobPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_PART_NUMBER");
            entity.Property(e => e.FobSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_SERIAL_NUMBER");
            entity.Property(e => e.FobSid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_SID");
            entity.Property(e => e.FobSidPrefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_SID_PREFIX");
            entity.Property(e => e.FobWid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_WID");
            entity.Property(e => e.IkptSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IKPT_SERIAL_NUMBER");
            entity.Property(e => e.IkptVersionNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IKPT_VERSION_NUMBER");
            entity.Property(e => e.Is64bit).HasColumnName("IS_64BIT");
            entity.Property(e => e.IsInternal).HasColumnName("IS_INTERNAL");
            entity.Property(e => e.IsStolen).HasColumnName("IS_STOLEN");
            entity.Property(e => e.MachineLogin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MACHINE_LOGIN");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MACHINE_NAME");
            entity.Property(e => e.MfgDate).HasColumnName("MFG_DATE");
            entity.Property(e => e.OperatingSystem)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("OPERATING_SYSTEM");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.RiderKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_KEY");
            entity.Property(e => e.ShutDownTimeout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHUT_DOWN_TIMEOUT");
            entity.Property(e => e.SoftwarePartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_PART_NUMBER");
            entity.Property(e => e.SoftwareVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_VERSION");
            entity.Property(e => e.SpeedLimitBeginner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPEED_LIMIT_BEGINNER");
            entity.Property(e => e.SpeedLimitExpert)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPEED_LIMIT_EXPERT");
            entity.Property(e => e.UicWid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UIC_WID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<InfoKeyErrorCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoKey_Error_Codes");

            entity.Property(e => e.ActionLevel1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACTION_LEVEL1");
            entity.Property(e => e.ActionLevel2)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACTION_LEVEL2");
            entity.Property(e => e.ActionLevel3)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ACTION_LEVEL3");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Charge).HasColumnName("CHARGE");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Message)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORIGIN");
            entity.Property(e => e.Restart).HasColumnName("RESTART");
            entity.Property(e => e.ServiceImmediate).HasColumnName("SERVICE_IMMEDIATE");
            entity.Property(e => e.ServicePersists).HasColumnName("SERVICE_PERSISTS");
            entity.Property(e => e.Translation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TRANSLATION");
        });

        modelBuilder.Entity<InfoKeyManufacture>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InfoKey_Manufacture");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.ElprotronicId).HasColumnName("ELPROTRONIC_ID");
            entity.Property(e => e.FailureRead).HasColumnName("FAILURE_READ");
            entity.Property(e => e.FailureWrite).HasColumnName("FAILURE_WRITE");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.SuccessRead).HasColumnName("SUCCESS_READ");
            entity.Property(e => e.SuccessWrite).HasColumnName("SUCCESS_WRITE");
        });

        modelBuilder.Entity<InfokeyConfigUsageAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INFOKEY_CONFIG_USAGE_ACTIONS", "SERVMGR");

            entity.Property(e => e.Action)
                .HasMaxLength(30)
                .HasColumnName("ACTION");
            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("CODE");
        });

        modelBuilder.Entity<Key>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KEY", "SERVMGR");

            entity.Property(e => e.DateEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.DateKeyed)
                .HasColumnType("date")
                .HasColumnName("DATE_KEYED");
            entity.Property(e => e.Flash1)
                .HasMaxLength(50)
                .HasColumnName("FLASH_1");
            entity.Property(e => e.Flash2)
                .HasMaxLength(50)
                .HasColumnName("FLASH_2");
            entity.Property(e => e.Flash3)
                .HasMaxLength(50)
                .HasColumnName("FLASH_3");
            entity.Property(e => e.Flash4)
                .HasMaxLength(50)
                .HasColumnName("FLASH_4");
            entity.Property(e => e.FlashCuA)
                .HasMaxLength(50)
                .HasColumnName("FLASH_CU_A");
            entity.Property(e => e.FlashCuB)
                .HasMaxLength(50)
                .HasColumnName("FLASH_CU_B");
            entity.Property(e => e.FleetKey)
                .HasMaxLength(50)
                .HasColumnName("FLEET_KEY");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(50)
                .HasColumnName("MODEL_CODE");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.ServiceKey)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_KEY");
            entity.Property(e => e.UserKey1)
                .HasMaxLength(50)
                .HasColumnName("USER_KEY_1");
            entity.Property(e => e.UserKey2)
                .HasMaxLength(50)
                .HasColumnName("USER_KEY_2");
        });

        modelBuilder.Entity<KeyCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Key_Codes");

            entity.Property(e => e.DateEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.DateRekeyed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_REKEYED");
            entity.Property(e => e.FlashCuA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLASH_CU_A");
            entity.Property(e => e.FlashCuB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLASH_CU_B");
            entity.Property(e => e.FleetKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLEET_KEY");
            entity.Property(e => e.ProductPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_PART_NUMBER");
            entity.Property(e => e.ProductSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.Rmp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("RMP");
            entity.Property(e => e.ServiceKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_KEY");
            entity.Property(e => e.UserKey1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_KEY_1");
            entity.Property(e => e.UserKey2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_KEY_2");
        });

        modelBuilder.Entity<KnowledgeBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KnowledgeBase");

            entity.Property(e => e.Attach)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ATTACH");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Deleted).HasColumnName("DELETED");
            entity.Property(e => e.Errorcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ERRORCODE");
            entity.Property(e => e.Issuestatus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ISSUESTATUS");
            entity.Property(e => e.Kbcategory)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("KBCATEGORY");
            entity.Property(e => e.Keywords)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("KEYWORDS");
            entity.Property(e => e.Problem)
                .IsUnicode(false)
                .HasColumnName("PROBLEM");
            entity.Property(e => e.Products)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PRODUCTS");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.Solutionss)
                .IsUnicode(false)
                .HasColumnName("SOLUTIONSS");
            entity.Property(e => e.Solutionst)
                .IsUnicode(false)
                .HasColumnName("SOLUTIONST");
            entity.Property(e => e.Solutionts)
                .IsUnicode(false)
                .HasColumnName("SOLUTIONTS");
            entity.Property(e => e.Summary)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SUMMARY");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
            entity.Property(e => e.ValidationNotes)
                .IsUnicode(false)
                .HasColumnName("VALIDATION_NOTES");
        });

        modelBuilder.Entity<KnowledgebaseHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KNOWLEDGEBASE_HISTORY", "SERVMGR");

            entity.Property(e => e.ChangeType)
                .HasMaxLength(10)
                .HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.SolAttach)
                .HasMaxLength(1000)
                .HasColumnName("SOL_ATTACH");
            entity.Property(e => e.SolDateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("SOL_DATE_TIME_ENTERED");
            entity.Property(e => e.SolDeleted)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SOL_DELETED");
            entity.Property(e => e.SolErrorcode)
                .HasMaxLength(10)
                .HasColumnName("SOL_ERRORCODE");
            entity.Property(e => e.SolIssuestatus)
                .HasMaxLength(15)
                .HasColumnName("SOL_ISSUESTATUS");
            entity.Property(e => e.SolKbcategory)
                .HasMaxLength(150)
                .HasColumnName("SOL_KBCATEGORY");
            entity.Property(e => e.SolKeywords)
                .HasMaxLength(500)
                .HasColumnName("SOL_KEYWORDS");
            entity.Property(e => e.SolProblem).HasColumnName("SOL_PROBLEM");
            entity.Property(e => e.SolProducts)
                .HasMaxLength(1000)
                .HasColumnName("SOL_PRODUCTS");
            entity.Property(e => e.SolRecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SOL_REC_ID");
            entity.Property(e => e.SolSolutionss).HasColumnName("SOL_SOLUTIONSS");
            entity.Property(e => e.SolSolutionst).HasColumnName("SOL_SOLUTIONST");
            entity.Property(e => e.SolSolutionts).HasColumnName("SOL_SOLUTIONTS");
            entity.Property(e => e.SolSummary)
                .HasMaxLength(200)
                .HasColumnName("SOL_SUMMARY");
            entity.Property(e => e.SolUsername)
                .HasMaxLength(50)
                .HasColumnName("SOL_USERNAME");
            entity.Property(e => e.SolValidationNotes).HasColumnName("SOL_VALIDATION_NOTES");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<LastProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LAST_PROCESS", "REWORK");

            entity.Property(e => e.LastProcess1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_PROCESS");
        });

        modelBuilder.Entity<LineReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LINE_REASONS", "REWORK");

            entity.Property(e => e.Reason)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("REASON");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Channel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.LogBuild)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOG_BUILD");
            entity.Property(e => e.LogData)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("LOG_DATA");
            entity.Property(e => e.Logfilename)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("LOGFILENAME");
            entity.Property(e => e.Logtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LOGTYPE");
            entity.Property(e => e.Odometer).HasColumnName("ODOMETER");
            entity.Property(e => e.Operatingtime).HasColumnName("OPERATINGTIME");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.TimeStamp).HasColumnName("TIME_STAMP");
            entity.Property(e => e.Unit).HasColumnName("UNIT");
            entity.Property(e => e.Unitserial)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UNITSERIAL");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<Logfault>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGFAULTS", "SERVMGR");

            entity.Property(e => e.Actuatorlocal)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ACTUATORLOCAL");
            entity.Property(e => e.Actuatorremote)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ACTUATORREMOTE");
            entity.Property(e => e.Comm)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("COMM");
            entity.Property(e => e.GpStatus1)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("GP_STATUS1");
            entity.Property(e => e.GpStatus2)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("GP_STATUS2");
            entity.Property(e => e.GpStatus3)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("GP_STATUS3");
            entity.Property(e => e.GpStatus4)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("GP_STATUS4");
            entity.Property(e => e.Hazards)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("HAZARDS");
            entity.Property(e => e.Islinked)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ISLINKED");
            entity.Property(e => e.LogData)
                .HasMaxLength(2000)
                .HasColumnName("LOG_DATA");
            entity.Property(e => e.LogId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("LOG_ID");
            entity.Property(e => e.Lognumber)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("LOGNUMBER");
            entity.Property(e => e.Odometer)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ODOMETER");
            entity.Property(e => e.Operatingtime)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("OPERATINGTIME");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.Sensorlocal)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SENSORLOCAL");
            entity.Property(e => e.Sensorremote)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SENSORREMOTE");
            entity.Property(e => e.Timeafterpower)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TIMEAFTERPOWER");
            entity.Property(e => e.Tsw1)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TSW1");
            entity.Property(e => e.Tsw2)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TSW2");
            entity.Property(e => e.Tsw3)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TSW3");
        });

        modelBuilder.Entity<Manufacturing_Component_Assemblies>(entity =>
        {
            entity
                .ToTable("Manufacturing_Component_Assemblies")
                .HasKey(x => x.ID);

            entity.Property(e => e.Child_Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHILD_SERIAL");
            entity.Property(e => e.Created_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Date_Time_Created)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.Date_Time_Removed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REMOVED");
            entity.Property(e => e.ID)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Parent_Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.Part_Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.Position)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSITION");
            entity.Property(e => e.Removed_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMOVED_BY");
            entity.Property(e => e.Site)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.Work_Order)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<ManufacturingComponentComment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Component_Comments");

            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Comment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<Manufacturing_Component_Data>(entity =>
        {
            entity
                .ToTable("Manufacturing_Component_Data")
                .HasKey(x => x.ID);

            entity.Property(e => e.Created_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Data)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DATA");
            entity.Property(e => e.Data_Type)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DATA_TYPE");
            entity.Property(e => e.Date_Time_Created)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.Date_Time_Removed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REMOVED");
            entity.Property(e => e.ID)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Parent_Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.Removed_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMOVED_BY");
            entity.Property(e => e.Site)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.Work_Order)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<Manufacturing_Component_Events>(entity =>
        {
            entity
                .ToTable("Manufacturing_Component_Events")
                .HasKey(e => e.ID);

            entity.Property(e => e.Created_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Date_Time_Created)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.Date_Time_Removed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REMOVED");
            entity.Property(e => e.Event_Data)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EVENT_DATA");
            entity.Property(e => e.Event_Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EVENT_STATUS");
            entity.Property(e => e.Event_Type)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("EVENT_TYPE");
            entity.Property(e => e.ID)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Parent_Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.Removed_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMOVED_BY");
            entity.Property(e => e.Site)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.Work_Order)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<ManufacturingComponentGearBoxLot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Component_GearBoxLot");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.GearIntmLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GEAR_INTM_LOT");
            entity.Property(e => e.GearIntmPn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GEAR_INTM_PN");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.LotDate)
                .HasColumnType("date")
                .HasColumnName("LOT_DATE");
            entity.Property(e => e.LotKey).HasColumnName("LOT_KEY");
            entity.Property(e => e.OutputGearLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OUTPUT_GEAR_LOT");
            entity.Property(e => e.OutputGearPn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OUTPUT_GEAR_PN");
            entity.Property(e => e.ShaftInputLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHAFT_INPUT_LOT");
            entity.Property(e => e.ShaftInputPn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHAFT_INPUT_PN");
            entity.Property(e => e.ShaftIntmLot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHAFT_INTM_LOT");
            entity.Property(e => e.ShaftIntmPn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHAFT_INTM_PN");
        });

        modelBuilder.Entity<Manufacturing_Component_Serialized>(entity =>
        {
            entity
                .ToTable("Manufacturing_Component_Serialized")
                .HasKey(x => x.ID);

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Created_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Date_Time_Created)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.Date_Time_Removed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REMOVED");
            entity.Property(e => e.ID)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Model_Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL_NAME");
            entity.Property(e => e.Part_Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.Part_Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.Removed_By)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMOVED_BY");
            entity.Property(e => e.Serial_Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Manufacturing_Components>(entity =>
        {
            entity
                .ToTable("Manufacturing_Components")
                .HasKey(x => x.ID);

            entity.Property(e => e.ID)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Component)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COMPONENT");
        });

        modelBuilder.Entity<ManufacturingLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Locations");

            entity.Property(e => e.Account)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ManufacturingReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Reasons");

            entity.Property(e => e.Action)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NewAssemblySerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NEW_ASSEMBLY_SERIAL");
            entity.Property(e => e.OldAssemblySerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OLD_ASSEMBLY_SERIAL");
            entity.Property(e => e.Operator)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.ReasonCode).HasColumnName("REASON_CODE");
        });

        modelBuilder.Entity<ManufacturingReasonCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Reason_Codes");

            entity.Property(e => e.ComponentType)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("COMPONENT_TYPE");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LocationName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LOCATION_NAME");
            entity.Property(e => e.Operator)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.Reason)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReasonCode)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("REASON_CODE");
            entity.Property(e => e.ReasonType)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REASON_TYPE");
        });

        modelBuilder.Entity<ManufacturingReasonLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Reason_Location");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LocationName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LOCATION_NAME");
            entity.Property(e => e.Operator)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("OPERATOR");
        });

        modelBuilder.Entity<ManufacturingSerializedAssembly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Serialized_Assemblies");

            entity.Property(e => e.ChildSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHILD_SERIAL");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateTimeCreated)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeRemoved)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REMOVED");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.ParentSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.PartType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.Position)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSITION");
            entity.Property(e => e.RemovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMOVED_BY");
            entity.Property(e => e.Site)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<ManufacturingSerializedComment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Serialized_Comments");

            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Comment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<ManufacturingSerializedComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Serialized_Components");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateTimeCreated)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.ModelName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL_NAME");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ManufacturingSerializedComponentEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Manufacturing_Serialized_Component_Events");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateTimeCreated)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeRemoved)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_REMOVED");
            entity.Property(e => e.EventData)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EVENT_DATA");
            entity.Property(e => e.EventType)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("EVENT_TYPE");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.ParentSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.RemovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMOVED_BY");
            entity.Property(e => e.Site)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<MdtDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MDT_DETAIL", "SERVMGR");

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.InventoryItemId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("INVENTORY_ITEM_ID");
            entity.Property(e => e.ItemCost)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ITEM_COST");
            entity.Property(e => e.MdtId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("MDT_ID");
            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("QUANTITY");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.Revision)
                .HasMaxLength(20)
                .HasColumnName("REVISION");
            entity.Property(e => e.SubinventoryCode)
                .HasMaxLength(20)
                .HasColumnName("SUBINVENTORY_CODE");
        });

        modelBuilder.Entity<MdtMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MDT_MASTER", "SERVMGR");

            entity.Property(e => e.ApprovalDate)
                .HasColumnType("date")
                .HasColumnName("APPROVAL_DATE");
            entity.Property(e => e.Approver)
                .HasMaxLength(60)
                .HasColumnName("APPROVER");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DispositionId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("DISPOSITION_ID");
            entity.Property(e => e.Justification)
                .HasMaxLength(200)
                .HasColumnName("JUSTIFICATION");
            entity.Property(e => e.MdtId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("MDT_ID");
            entity.Property(e => e.Originator)
                .HasMaxLength(60)
                .HasColumnName("ORIGINATOR");
            entity.Property(e => e.RecipientDepartment)
                .HasMaxLength(60)
                .HasColumnName("RECIPIENT_DEPARTMENT");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Microsoftdtproperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MICROSOFTDTPROPERTIES", "SERVMGR");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Lvalue).HasColumnName("LVALUE");
            entity.Property(e => e.Objectid)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("OBJECTID");
            entity.Property(e => e.Property)
                .HasMaxLength(64)
                .HasColumnName("PROPERTY");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
            entity.Property(e => e.Version)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<MiniProProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MiniPro_Products");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
        });

        modelBuilder.Entity<MiniProTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MiniPro_Tracking");

            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Incident)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
            entity.Property(e => e.TrackingCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tracking_Code");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
        });

        modelBuilder.Entity<MiniProTrackingCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MiniPro_Tracking_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
        });

        modelBuilder.Entity<ModelNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MODEL_NUMBERS", "REWORK");

            entity.Property(e => e.ModelNumberId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("MODEL_NUMBER_ID");
            entity.Property(e => e.ModelNumbers)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL_NUMBERS");
        });

        modelBuilder.Entity<MotorNormRatioTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Motor_Norm_Ratio_Test");

            entity.Property(e => e.BaseCriteria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BASE_CRITERIA");
            entity.Property(e => e.BaseTest)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BASE_TEST");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Lt1Criteria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT1_CRITERIA");
            entity.Property(e => e.Lt1Delta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT1_DELTA");
            entity.Property(e => e.Lt1DeltaCriteria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT1_DELTA_CRITERIA");
            entity.Property(e => e.Lt1Test)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT1_TEST");
            entity.Property(e => e.Lt2Criteria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT2_CRITERIA");
            entity.Property(e => e.Lt2Delta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT2_DELTA");
            entity.Property(e => e.Lt2DeltaCriteria)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT2_DELTA_CRITERIA");
            entity.Property(e => e.Lt2Test)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LT2_TEST");
            entity.Property(e => e.MotorId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MOTOR_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.SoftwareVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_VERSION");
            entity.Property(e => e.TestId).HasColumnName("TEST_ID");
            entity.Property(e => e.TestTime)
                .HasColumnType("datetime")
                .HasColumnName("TEST_TIME");
            entity.Property(e => e.TestType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TEST_TYPE");
        });

        modelBuilder.Entity<NewConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("New_Config");

            entity.Property(e => e.BcuAModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_MODEL_NUM");
            entity.Property(e => e.BcuASerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_SERIAL_NUM");
            entity.Property(e => e.BcuASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_A_SW_REV");
            entity.Property(e => e.BcuBModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_MODEL_NUM");
            entity.Property(e => e.BcuBSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_SERIAL_NUM");
            entity.Property(e => e.BcuBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BCU_B_SW_REV");
            entity.Property(e => e.CuAModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_MODEL_NUM");
            entity.Property(e => e.CuASerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SERIAL_NUM");
            entity.Property(e => e.CuASwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SW_REV");
            entity.Property(e => e.CuBModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_MODEL_NUM");
            entity.Property(e => e.CuBSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SERIAL_NUM");
            entity.Property(e => e.CuBSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SW_REV");
            entity.Property(e => e.DateEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.DllVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DLL_VERSION");
            entity.Property(e => e.GearBox1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GEAR_BOX_1");
            entity.Property(e => e.GearBox2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GEAR_BOX_2");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImuAModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_A_MODEL_NUM");
            entity.Property(e => e.ImuASerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_A_SERIAL_NUM");
            entity.Property(e => e.ImuBModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_B_MODEL_NUM");
            entity.Property(e => e.ImuBSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_B_SERIAL_NUM");
            entity.Property(e => e.ImuPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_PART_NUMBER");
            entity.Property(e => e.ImuSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_SERIAL_NUM");
            entity.Property(e => e.ImuSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_SW_REV");
            entity.Property(e => e.ImuSwRevA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_SW_REV_A");
            entity.Property(e => e.ImuSwRevB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMU_SW_REV_B");
            entity.Property(e => e.Mat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAT");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.Motor1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOTOR_1");
            entity.Property(e => e.Motor2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOTOR_2");
            entity.Property(e => e.PowerSupplySerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POWER_SUPPLY_SERIAL_NUMBER");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.ServiceNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERVICE_NUMBER");
            entity.Property(e => e.ServiceTech)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_TECH");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TireWheel1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRE_WHEEL_1");
            entity.Property(e => e.TireWheel2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIRE_WHEEL_2");
            entity.Property(e => e.UiModelNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_MODEL_NUM");
            entity.Property(e => e.UiSerialNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SERIAL_NUM");
            entity.Property(e => e.UiSwRev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SW_REV");
        });

        modelBuilder.Entity<NineBotPartNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NineBot_Part_Numbers");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NinebotPartNumber1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NINEBOT_PART_NUMBER");
            entity.Property(e => e.SegwayPartNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SEGWAY_PART_NUMBER");
            entity.Property(e => e.Upc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UPC");
        });

        modelBuilder.Entity<ObcAssembly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Obc_Assembly");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InternalUicSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("INTERNAL_UIC_SERIAL");
            entity.Property(e => e.ObcSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBC_SERIAL");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<ObcTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Obc_Test");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ObcSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBC_SERIAL");
            entity.Property(e => e.TestPassed).HasColumnName("TEST_PASSED");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<ObcTestDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Obc_Test_Details");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InputVoltage).HasColumnName("INPUT_VOLTAGE");
            entity.Property(e => e.LevelPassed).HasColumnName("LEVEL_PASSED");
            entity.Property(e => e.LoadSetting).HasColumnName("LOAD_SETTING");
            entity.Property(e => e.Side1Current).HasColumnName("SIDE_1_CURRENT");
            entity.Property(e => e.Side1Voltage).HasColumnName("SIDE_1_VOLTAGE");
            entity.Property(e => e.Side2Current).HasColumnName("SIDE_2_CURRENT");
            entity.Property(e => e.Side2Voltage).HasColumnName("SIDE_2_VOLTAGE");
            entity.Property(e => e.TestId).HasColumnName("TEST_ID");
        });

        modelBuilder.Entity<PartNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Part_Numbers");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.PartNumber1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.SerialType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERIAL_TYPE");
        });

        modelBuilder.Entity<PivotSensor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pivot_Sensor");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.PivotBaseSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PIVOT_BASE_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.SensorReadingValue).HasColumnName("SENSOR_READING_VALUE");
        });

        modelBuilder.Entity<PivotSensorTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PIVOT_SENSOR_TEMP", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.PivotBaseSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PIVOT_BASE_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.SensorReadingValue)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SENSOR_READING_VALUE");
        });

        modelBuilder.Entity<PivotTesterResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pivot_Tester_Results");

            entity.Property(e => e.Cyclepivot45CcwTimetozeroFromccw).HasColumnName("CYCLEPIVOT_45_CCW_TIMETOZERO_FROMCCW");
            entity.Property(e => e.Cyclepivot45CwTimetozeroFromcw).HasColumnName("CYCLEPIVOT_45_CW_TIMETOZERO_FROMCW");
            entity.Property(e => e.D10CcwMeasuretorque10Ccw).HasColumnName("D10_CCW_MEASURETORQUE_10_CCW");
            entity.Property(e => e.D10CwMeasuretorque10Cw).HasColumnName("D10_CW_MEASURETORQUE_10_CW");
            entity.Property(e => e.D20CcwMeasuretorque20Ccw).HasColumnName("D20_CCW_MEASURETORQUE_20_CCW");
            entity.Property(e => e.D20CwMeasuretorque20Cw).HasColumnName("D20_CW_MEASURETORQUE_20_CW");
            entity.Property(e => e.D22p5CcwMeasurea22p5Ccw).HasColumnName("D22P5_CCW_MEASUREA_22P5_CCW");
            entity.Property(e => e.D22p5CcwMeasureb22p5Ccw).HasColumnName("D22P5_CCW_MEASUREB_22P5_CCW");
            entity.Property(e => e.D22p5CcwMeasuretorque22p5Ccw).HasColumnName("D22P5_CCW_MEASURETORQUE_22P5_CCW");
            entity.Property(e => e.D22p5CcwReportcount22p5Ccw).HasColumnName("D22P5_CCW_REPORTCOUNT_22P5_CCW");
            entity.Property(e => e.D22p5CwMeasurea22p5Cw).HasColumnName("D22P5_CW_MEASUREA_22P5_CW");
            entity.Property(e => e.D22p5CwMeasureb22p5Cw).HasColumnName("D22P5_CW_MEASUREB_22P5_CW");
            entity.Property(e => e.D22p5CwMeasuretorque22p5Cw).HasColumnName("D22P5_CW_MEASURETORQUE_22P5_CW");
            entity.Property(e => e.D22p5CwReportcount22p5Cw).HasColumnName("D22P5_CW_REPORTCOUNT_22P5_CW");
            entity.Property(e => e.D30CcwMeasuretorque30Ccw).HasColumnName("D30_CCW_MEASURETORQUE_30_CCW");
            entity.Property(e => e.D30CwMeasuretorque30Cw).HasColumnName("D30_CW_MEASURETORQUE_30_CW");
            entity.Property(e => e.D40CcwMeasuretorque40Ccw).HasColumnName("D40_CCW_MEASURETORQUE_40_CCW");
            entity.Property(e => e.D40CwMeasuretorque40Cw).HasColumnName("D40_CW_MEASURETORQUE_40_CW");
            entity.Property(e => e.D45CcwMeasurea45Ccw).HasColumnName("D45_CCW_MEASUREA_45_CCW");
            entity.Property(e => e.D45CcwMeasureb45Ccw).HasColumnName("D45_CCW_MEASUREB_45_CCW");
            entity.Property(e => e.D45CcwMeasuretorque45Ccw).HasColumnName("D45_CCW_MEASURETORQUE_45_CCW");
            entity.Property(e => e.D45CcwReportcount45Ccw).HasColumnName("D45_CCW_REPORTCOUNT_45_CCW");
            entity.Property(e => e.D45CwMeasurea45Cw).HasColumnName("D45_CW_MEASUREA_45_CW");
            entity.Property(e => e.D45CwMeasureb45Cw).HasColumnName("D45_CW_MEASUREB_45_CW");
            entity.Property(e => e.D45CwMeasuretorque45Cw).HasColumnName("D45_CW_MEASURETORQUE_45_CW");
            entity.Property(e => e.D45CwReportcount45Cw).HasColumnName("D45_CW_REPORTCOUNT_45_CW");
            entity.Property(e => e.D50CcwMeasuretorque50Ccw).HasColumnName("D50_CCW_MEASURETORQUE_50_CCW");
            entity.Property(e => e.D50CwMeasuretorque50Cw).HasColumnName("D50_CW_MEASURETORQUE_50_CW");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FastensensorMeasuredifferentialFastened).HasColumnName("FASTENSENSOR_MEASUREDIFFERENTIAL_FASTENED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Key)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("KEY");
            entity.Property(e => e.Nest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NEST");
            entity.Property(e => e.SensorzeroingGotozeroposition).HasColumnName("SENSORZEROING_GOTOZEROPOSITION");
            entity.Property(e => e.SensorzeroingMeasuredifferentialZero).HasColumnName("SENSORZEROING_MEASUREDIFFERENTIAL_ZERO");
            entity.Property(e => e.Serial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.TimetozerofromccwTimetozeroFromccw).HasColumnName("TIMETOZEROFROMCCW_TIMETOZERO_FROMCCW");
            entity.Property(e => e.TimetozerofromcwTimetozeroFromcw).HasColumnName("TIMETOZEROFROMCW_TIMETOZERO_FROMCW");
            entity.Property(e => e.UnloaddutMeasuredifferentialFinish).HasColumnName("UNLOADDUT_MEASUREDIFFERENTIAL_FINISH");
            entity.Property(e => e.VerifysuppliesMeasureps).HasColumnName("VERIFYSUPPLIES_MEASUREPS");
            entity.Property(e => e.VerifysuppliesMeasurepsA).HasColumnName("VERIFYSUPPLIES_MEASUREPS_A");
            entity.Property(e => e.VerifysuppliesMeasurepsB).HasColumnName("VERIFYSUPPLIES_MEASUREPS_B");
            entity.Property(e => e.VerifyzeroMeasureaVerify).HasColumnName("VERIFYZERO_MEASUREA_VERIFY");
            entity.Property(e => e.VerifyzeroMeasurebVerify).HasColumnName("VERIFYZERO_MEASUREB_VERIFY");
            entity.Property(e => e.VerifyzeroMeasuredifferentialVerify).HasColumnName("VERIFYZERO_MEASUREDIFFERENTIAL_VERIFY");
            entity.Property(e => e.VerifyzeroReportnumzeroingattempts).HasColumnName("VERIFYZERO_REPORTNUMZEROINGATTEMPTS");
        });

        modelBuilder.Entity<PowerSupplyTesterDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Power_Supply_Tester_Data");

            entity.Property(e => e.AcInputSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AC_INPUT_SERIAL_NUMBER");
            entity.Property(e => e.Asct110Current).HasColumnName("ASCT_110_CURRENT");
            entity.Property(e => e.AsctStatus).HasColumnName("ASCT_STATUS");
            entity.Property(e => e.ChargerBoardSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHARGER_BOARD_SERIAL_NUMBER");
            entity.Property(e => e.Comment)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Cont12vA).HasColumnName("CONT_12V_A");
            entity.Property(e => e.Cont12vB).HasColumnName("CONT_12V_B");
            entity.Property(e => e.Cont9vCua).HasColumnName("CONT_9V_CUA");
            entity.Property(e => e.Cont9vCub).HasColumnName("CONT_9V_CUB");
            entity.Property(e => e.ContCanhA).HasColumnName("CONT_CANH_A");
            entity.Property(e => e.ContCanhB).HasColumnName("CONT_CANH_B");
            entity.Property(e => e.ContCanlA).HasColumnName("CONT_CANL_A");
            entity.Property(e => e.ContCanlB).HasColumnName("CONT_CANL_B");
            entity.Property(e => e.ContDgndA).HasColumnName("CONT_DGND_A");
            entity.Property(e => e.ContDgndB).HasColumnName("CONT_DGND_B");
            entity.Property(e => e.ContStatus).HasColumnName("CONT_STATUS");
            entity.Property(e => e.ContSteerA).HasColumnName("CONT_STEER_A");
            entity.Property(e => e.ContSteerB).HasColumnName("CONT_STEER_B");
            entity.Property(e => e.ContV50refA).HasColumnName("CONT_V50REF_A");
            entity.Property(e => e.ContV50refB).HasColumnName("CONT_V50REF_B");
            entity.Property(e => e.ContVbatPlusB).HasColumnName("CONT_VBAT_PLUS_B");
            entity.Property(e => e.ContWakeA).HasColumnName("CONT_WAKE_A");
            entity.Property(e => e.ContWakeB).HasColumnName("CONT_WAKE_B");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.HipotTestStatus).HasColumnName("HIPOT_TEST_STATUS");
            entity.Property(e => e.InterConnectBoardSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTER_CONNECT_BOARD_SERIAL_NUMBER");
            entity.Property(e => e.Lt110Pwm000ALoadbnkCurr).HasColumnName("LT110_PWM000_A_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm000ALoadbnkVolt).HasColumnName("LT110_PWM000_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm000BLoadbnkCurr).HasColumnName("LT110_PWM000_B_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm000BLoadbnkVolt).HasColumnName("LT110_PWM000_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm000V110V220Current).HasColumnName("LT110_PWM000_V110_V220_CURRENT");
            entity.Property(e => e.Lt110Pwm025ALoadbnkCurr).HasColumnName("LT110_PWM025_A_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm025ALoadbnkVolt).HasColumnName("LT110_PWM025_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm025BLoadbnkCurr).HasColumnName("LT110_PWM025_B_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm025BLoadbnkVolt).HasColumnName("LT110_PWM025_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm025V110V220Current).HasColumnName("LT110_PWM025_V110_V220_CURRENT");
            entity.Property(e => e.Lt110Pwm050ALoadbnkCurr).HasColumnName("LT110_PWM050_A_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm050ALoadbnkVolt).HasColumnName("LT110_PWM050_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm050BLoadbnkCurr).HasColumnName("LT110_PWM050_B_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm050BLoadbnkVolt).HasColumnName("LT110_PWM050_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm050V110V220Current).HasColumnName("LT110_PWM050_V110_V220_CURRENT");
            entity.Property(e => e.Lt110Pwm075ALoadbnkCurr).HasColumnName("LT110_PWM075_A_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm075ALoadbnkVolt).HasColumnName("LT110_PWM075_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm075BLoadbnkCurr).HasColumnName("LT110_PWM075_B_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm075BLoadbnkVolt).HasColumnName("LT110_PWM075_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm075V110V220Current).HasColumnName("LT110_PWM075_V110_V220_CURRENT");
            entity.Property(e => e.Lt110Pwm100ALoadbnkCurr).HasColumnName("LT110_PWM100_A_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm100ALoadbnkVolt).HasColumnName("LT110_PWM100_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm100BLoadbnkCurr).HasColumnName("LT110_PWM100_B_LOADBNK_CURR");
            entity.Property(e => e.Lt110Pwm100BLoadbnkVolt).HasColumnName("LT110_PWM100_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt110Pwm100V110V220Current).HasColumnName("LT110_PWM100_V110_V220_CURRENT");
            entity.Property(e => e.Lt110Status).HasColumnName("LT110_STATUS");
            entity.Property(e => e.Lt220Pwm000ALoadbnkCurr).HasColumnName("LT220_PWM000_A_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm000ALoadbnkVolt).HasColumnName("LT220_PWM000_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm000BLoadbnkCurr).HasColumnName("LT220_PWM000_B_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm000BLoadbnkVolt).HasColumnName("LT220_PWM000_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm000V110V220Current).HasColumnName("LT220_PWM000_V110_V220_CURRENT");
            entity.Property(e => e.Lt220Pwm025ALoadbnkCurr).HasColumnName("LT220_PWM025_A_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm025ALoadbnkVolt).HasColumnName("LT220_PWM025_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm025BLoadbnkCurr).HasColumnName("LT220_PWM025_B_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm025BLoadbnkVolt).HasColumnName("LT220_PWM025_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm025V110V220Current).HasColumnName("LT220_PWM025_V110_V220_CURRENT");
            entity.Property(e => e.Lt220Pwm050ALoadbnkCurr).HasColumnName("LT220_PWM050_A_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm050ALoadbnkVolt).HasColumnName("LT220_PWM050_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm050BLoadbnkCurr).HasColumnName("LT220_PWM050_B_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm050BLoadbnkVolt).HasColumnName("LT220_PWM050_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm050V110V220Current).HasColumnName("LT220_PWM050_V110_V220_CURRENT");
            entity.Property(e => e.Lt220Pwm075ALoadbnkCurr).HasColumnName("LT220_PWM075_A_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm075ALoadbnkVolt).HasColumnName("LT220_PWM075_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm075BLoadbnkCurr).HasColumnName("LT220_PWM075_B_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm075BLoadbnkVolt).HasColumnName("LT220_PWM075_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm075V110V220Current).HasColumnName("LT220_PWM075_V110_V220_CURRENT");
            entity.Property(e => e.Lt220Pwm100ALoadbnkCurr).HasColumnName("LT220_PWM100_A_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm100ALoadbnkVolt).HasColumnName("LT220_PWM100_A_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm100BLoadbnkCurr).HasColumnName("LT220_PWM100_B_LOADBNK_CURR");
            entity.Property(e => e.Lt220Pwm100BLoadbnkVolt).HasColumnName("LT220_PWM100_B_LOADBNK_VOLT");
            entity.Property(e => e.Lt220Pwm100V110V220Current).HasColumnName("LT220_PWM100_V110_V220_CURRENT");
            entity.Property(e => e.Lt220Status).HasColumnName("LT220_STATUS");
            entity.Property(e => e.Nlt12vA).HasColumnName("NLT_12V_A");
            entity.Property(e => e.Nlt12vB).HasColumnName("NLT_12V_B");
            entity.Property(e => e.NltStatus).HasColumnName("NLT_STATUS");
            entity.Property(e => e.OverallTestStatus).HasColumnName("OVERALL_TEST_STATUS");
            entity.Property(e => e.PivotSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PIVOT_SERIAL_NUMBER");
            entity.Property(e => e.SoftwareVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_VERSION");
            entity.Property(e => e.TestId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TEST_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<Problemcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROBLEMCODES", "REWORK");

            entity.Property(e => e.LastProcess)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LAST_PROCESS");
            entity.Property(e => e.ProblemCode1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_CODE");
        });

        modelBuilder.Entity<ProductionLineAssembly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Production_Line_Assembly");

            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");
            entity.Property(e => e.MasterSerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MASTER_SERIAL");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.OriginalId).HasColumnName("ORIGINAL_ID");
            entity.Property(e => e.OriginalMaster).HasColumnName("ORIGINAL_MASTER");
            entity.Property(e => e.OriginalParent).HasColumnName("ORIGINAL_PARENT");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
            entity.Property(e => e.ParentSerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.ReplacesId).HasColumnName("REPLACES_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Site)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.Stage1Id).HasColumnName("STAGE1_ID");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("UPDATED");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<ProductionLineAssembly1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRODUCTION_LINE_ASSEMBLY", "GENII");

            entity.Property(e => e.Code)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("MASTER_ID");
            entity.Property(e => e.MasterSerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MASTER_SERIAL");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.OriginalId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ORIGINAL_ID");
            entity.Property(e => e.OriginalMaster)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ORIGINAL_MASTER");
            entity.Property(e => e.OriginalParent)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ORIGINAL_PARENT");
            entity.Property(e => e.ParentId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("PARENT_ID");
            entity.Property(e => e.ParentSerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.ReplacesId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REPLACES_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Site)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.Stage1Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("STAGE1_ID");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Updated)
                .HasColumnType("date")
                .HasColumnName("UPDATED");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<ProductionLineAssemblyBack>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRODUCTION_LINE_ASSEMBLY_BACK", "GENII");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.MasterId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("MASTER_ID");
            entity.Property(e => e.MasterSerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MASTER_SERIAL");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.OriginalId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ORIGINAL_ID");
            entity.Property(e => e.OriginalMaster)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ORIGINAL_MASTER");
            entity.Property(e => e.OriginalParent)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ORIGINAL_PARENT");
            entity.Property(e => e.ParentId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("PARENT_ID");
            entity.Property(e => e.ParentSerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PARENT_SERIAL");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.ReplacesId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REPLACES_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Site)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.Stage1Id)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("STAGE1_ID");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Updated)
                .HasColumnType("date")
                .HasColumnName("UPDATED");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<ProductionLineAssemblyReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Production_Line_Assembly_Reasons");

            entity.Property(e => e.ComponentId).HasColumnName("COMPONENT_ID");
            entity.Property(e => e.ComponentSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COMPONENT_SERIAL");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Operator)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.ReasonId).HasColumnName("REASON_ID");
        });

        modelBuilder.Entity<ProductionLineAssemblyScrapped>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Production_Line_Assembly_Scrapped");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ScrappedBy)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("SCRAPPED_BY");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
        });

        modelBuilder.Entity<ProductionLineBaseConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRODUCTION_LINE_BASE_CONFIG", "GENII");

            entity.Property(e => e.ActiveEndDate)
                .HasColumnType("date")
                .HasColumnName("ACTIVE_END_DATE");
            entity.Property(e => e.ActiveStartDate)
                .HasColumnType("date")
                .HasColumnName("ACTIVE_START_DATE");
            entity.Property(e => e.ComponentInvItemId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COMPONENT_INV_ITEM_ID");
            entity.Property(e => e.ComponentInvOrgId)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COMPONENT_INV_ORG_ID");
            entity.Property(e => e.ComponentSerialNumber)
                .HasMaxLength(20)
                .HasColumnName("COMPONENT_SERIAL_NUMBER");
            entity.Property(e => e.ComponentStatus)
                .HasMaxLength(5)
                .HasColumnName("COMPONENT_STATUS");
            entity.Property(e => e.CreationDate)
                .HasColumnType("date")
                .HasColumnName("CREATION_DATE");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(20)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("date")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.ParentInvOrgId)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("PARENT_INV_ORG_ID");
            entity.Property(e => e.ParentInventoryItemId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PARENT_INVENTORY_ITEM_ID");
            entity.Property(e => e.ParentSerialNumber)
                .HasMaxLength(20)
                .HasColumnName("PARENT_SERIAL_NUMBER");
            entity.Property(e => e.ProdlineRecId)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PRODLINE_REC_ID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(20)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<ProductionLineMotorOverride>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Production_Line_Motor_Override");

            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.MessageType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_TYPE");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
        });

        modelBuilder.Entity<ProductionLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRODUCTION_LOOKUPS", "REWORK");

            entity.Property(e => e.Attribute1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE1");
            entity.Property(e => e.Attribute2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE2");
            entity.Property(e => e.Attribute3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE3");
            entity.Property(e => e.Attribute4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE4");
            entity.Property(e => e.Attribute5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE5");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.LookupDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOOKUP_DESCRIPTION");
            entity.Property(e => e.LookupType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOOKUP_TYPE");
            entity.Property(e => e.LookupValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOOKUP_VALUE");
            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<PtBatteriesHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Batteries_History");

            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.BatteryLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_LOCATION");
            entity.Property(e => e.BatterySerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.HistRecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HIST_REC_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.RegistrationId).HasColumnName("REGISTRATION_ID");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtBattery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Batteries");

            entity.Property(e => e.BatteryLocation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_LOCATION");
            entity.Property(e => e.BatterySerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.RegistrationId).HasColumnName("REGISTRATION_ID");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtCertifiedUsed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Certified_Used");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<PtCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Countries");

            entity.Property(e => e.AddressStyle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_STYLE");
            entity.Property(e => e.AddressValidation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_VALIDATION");
            entity.Property(e => e.AlternateTerritoryCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ALTERNATE_TERRITORY_CODE");
            entity.Property(e => e.BankInfoStyle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BANK_INFO_STYLE");
            entity.Property(e => e.BankInfoValidation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BANK_INFO_VALIDATION");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_DATE");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.EuCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EU_CODE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsoNumericCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ISO_NUMERIC_CODE");
            entity.Property(e => e.IsoTerritoryCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ISO_TERRITORY_CODE");
            entity.Property(e => e.LastUpdateDate)
                .HasColumnType("date")
                .HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.LastUpdateLogin).HasColumnName("LAST_UPDATE_LOGIN");
            entity.Property(e => e.LastUpdatedBy).HasColumnName("LAST_UPDATED_BY");
            entity.Property(e => e.NlsTerritory)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NLS_TERRITORY");
            entity.Property(e => e.ObsoleteFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OBSOLETE_FLAG");
            entity.Property(e => e.RowId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROW_ID");
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TERRITORY_CODE");
            entity.Property(e => e.TerritoryShortName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TERRITORY_SHORT_NAME");
        });

        modelBuilder.Entity<PtCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Customers");

            entity.Property(e => e.Address1)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.BillToSiteUseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BILL_TO_SITE_USE_ID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CustAccountId).HasColumnName("CUST_ACCOUNT_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DealerId).HasColumnName("DEALER_ID");
            entity.Property(e => e.DeliverToSiteUseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DELIVER_TO_SITE_USE_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Favorite).HasColumnName("FAVORITE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.ShipToSiteUseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SHIP_TO_SITE_USE_ID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtCustomersHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Customers_History");

            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.Address1)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.BillToSiteUseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("BILL_TO_SITE_USE_ID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CustAccountId).HasColumnName("CUST_ACCOUNT_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DealerId).HasColumnName("DEALER_ID");
            entity.Property(e => e.DeliverToSiteUseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DELIVER_TO_SITE_USE_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Favorite).HasColumnName("FAVORITE");
            entity.Property(e => e.HistRecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HIST_REC_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.ShipToSiteUseId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SHIP_TO_SITE_USE_ID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtDealer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Dealers");

            entity.Property(e => e.Address1)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtDealersHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Dealers_History");

            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.Address1)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("COMPANY_NAME");
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.HistRecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HIST_REC_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtOpenOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Open_Orders");

            entity.Property(e => e.AffiliatedDealer)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("AFFILIATED_DEALER");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.Dealer)
                .HasMaxLength(360)
                .IsUnicode(false)
                .HasColumnName("DEALER");
            entity.Property(e => e.LineNumber).HasColumnName("LINE_NUMBER");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.OrderNumber).HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Today).HasColumnName("TODAY");
        });

        modelBuilder.Entity<PtRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Registration");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DeliveryDetailId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DELIVERY_DETAIL_ID");
            entity.Property(e => e.IbInstanceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IB_INSTANCE_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InfokeyProgrammerCustId).HasColumnName("INFOKEY_PROGRAMMER_CUST_ID");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.OrderHeaderId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ORDER_HEADER_ID");
            entity.Property(e => e.PtCustomerId).HasColumnName("PT_CUSTOMER_ID");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.SaleDate).HasColumnName("SALE_DATE");
            entity.Property(e => e.ShipDate).HasColumnName("SHIP_DATE");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtRegistrationHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Registration_History");

            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DeliveryDetailId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("DELIVERY_DETAIL_ID");
            entity.Property(e => e.HistRecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HIST_REC_ID");
            entity.Property(e => e.IbInstanceId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("IB_INSTANCE_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InfokeyProgrammerCustId).HasColumnName("INFOKEY_PROGRAMMER_CUST_ID");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.OrderHeaderId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ORDER_HEADER_ID");
            entity.Property(e => e.PtCustomerId).HasColumnName("PT_CUSTOMER_ID");
            entity.Property(e => e.RecId).HasColumnName("REC_ID");
            entity.Property(e => e.SaleDate).HasColumnName("SALE_DATE");
            entity.Property(e => e.ShipDate).HasColumnName("SHIP_DATE");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<PtShipmentOverride>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Shipment_Override");

            entity.Property(e => e.AffiliatedDealer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("AFFILIATED_DEALER");
            entity.Property(e => e.Customer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Shipped).HasColumnName("SHIPPED");
        });

        modelBuilder.Entity<PtShippingDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PT_Shipping_Dates");

            entity.Property(e => e.Item)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.Serial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.ShipDate)
                .HasColumnType("date")
                .HasColumnName("SHIP_DATE");
            entity.Property(e => e.Shipped)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIPPED");
        });

        modelBuilder.Entity<PT_US_Cities>(entity =>
        {
            entity
                .ToTable("PT_US_Cities")
                .HasKey(e => e.Rec_ID);

            entity.Property(e => e.City_Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY_NAME");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.Postal_State_Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("POSTAL_STATE_CODE");
            entity.Property(e => e.Postal_Zip_Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTAL_ZIP_CODE");
            entity.Property(e => e.Rec_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.State_Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATE_NAME");
        });

        modelBuilder.Entity<ReleaseNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Release_Notes");

            entity.Property(e => e.Application)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Summary)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Revision>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ManCuaPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAN_CUA_PART_NUMBER");
            entity.Property(e => e.ManCuaSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAN_CUA_SERIAL_NUMBER");
            entity.Property(e => e.ManCuaSwRevision)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAN_CUA_SW_REVISION");
            entity.Property(e => e.ManCubPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAN_CUB_PART_NUMBER");
            entity.Property(e => e.ManCubSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAN_CUB_SERIAL_NUMBER");
            entity.Property(e => e.ManCubSwRevision)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MAN_CUB_SW_REVISION");
            entity.Property(e => e.ManufacturedDate)
                .HasColumnType("datetime")
                .HasColumnName("MANUFACTURED_DATE");
            entity.Property(e => e.PtSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL_NUMBER");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.ServiceDate)
                .HasColumnType("datetime")
                .HasColumnName("SERVICE_DATE");
            entity.Property(e => e.UpdCuaPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPD_CUA_PART_NUMBER");
            entity.Property(e => e.UpdCuaSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPD_CUA_SERIAL_NUMBER");
            entity.Property(e => e.UpdCuaSwRevision)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPD_CUA_SW_REVISION");
            entity.Property(e => e.UpdCubPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPD_CUB_PART_NUMBER");
            entity.Property(e => e.UpdCubSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPD_CUB_SERIAL_NUMBER");
            entity.Property(e => e.UpdCubSwRevision)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPD_CUB_SW_REVISION");
        });

        modelBuilder.Entity<Rework>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REWORK", "GENII");

            entity.Property(e => e.BsaASerialNumber)
                .HasMaxLength(50)
                .HasColumnName("BSA_A_SERIAL_NUMBER");
            entity.Property(e => e.BsaBSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("BSA_B_SERIAL_NUMBER");
            entity.Property(e => e.ConsolePsupplySerialNumber)
                .HasMaxLength(50)
                .HasColumnName("CONSOLE_PSUPPLY_SERIAL_NUMBER");
            entity.Property(e => e.ConsoleRadioSid)
                .HasMaxLength(50)
                .HasColumnName("CONSOLE_RADIO_SID");
            entity.Property(e => e.CoverLotCode)
                .HasMaxLength(50)
                .HasColumnName("COVER_LOT_CODE");
            entity.Property(e => e.CuASerialNumber)
                .HasMaxLength(50)
                .HasColumnName("CU_A_SERIAL_NUMBER");
            entity.Property(e => e.CuBSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("CU_B_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeServiced)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_SERVICED");
            entity.Property(e => e.Gearbox1SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("GEARBOX1_SERIAL_NUMBER");
            entity.Property(e => e.Gearbox2SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("GEARBOX2_SERIAL_NUMBER");
            entity.Property(e => e.Motor1SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("MOTOR1_SERIAL_NUMBER");
            entity.Property(e => e.Motor2SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("MOTOR2_SERIAL_NUMBER");
            entity.Property(e => e.PivotBaseSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PIVOT_BASE_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<ReworkLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REWORK_LOOKUPS", "REWORK");

            entity.Property(e => e.Attribute1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE1");
            entity.Property(e => e.Attribute2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE2");
            entity.Property(e => e.Attribute3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE3");
            entity.Property(e => e.Attribute4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE4");
            entity.Property(e => e.Attribute5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE5");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.LookupDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOOKUP_DESCRIPTION");
            entity.Property(e => e.LookupType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOOKUP_TYPE");
            entity.Property(e => e.LookupValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOOKUP_VALUE");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<ReworkReason>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Rework_Reason");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Reason)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.Specialty)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("specialty");
        });

        modelBuilder.Entity<ReworkTicket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Rework_Ticket");

            entity.Property(e => e.AssemblyStation)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ASSEMBLY_STATION");
            entity.Property(e => e.AssignedInvestigation)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ASSIGNED_INVESTIGATION");
            entity.Property(e => e.Date1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_1");
            entity.Property(e => e.Date2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_2");
            entity.Property(e => e.Date3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_3");
            entity.Property(e => e.Date4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_4");
            entity.Property(e => e.Date5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_5");
            entity.Property(e => e.Date6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_6");
            entity.Property(e => e.Date7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_7");
            entity.Property(e => e.Date8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_8");
            entity.Property(e => e.DateCreated)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateReworkCompleted)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_REWORK_COMPLETED");
            entity.Property(e => e.FieldRmaNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FIELD_RMA_NUMBER");
            entity.Property(e => e.FinalDisposition1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_1");
            entity.Property(e => e.FinalDisposition2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_2");
            entity.Property(e => e.FinalDisposition3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_3");
            entity.Property(e => e.FinalDisposition4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_4");
            entity.Property(e => e.FinalDisposition5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_5");
            entity.Property(e => e.FinalDisposition6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_6");
            entity.Property(e => e.FinalDisposition7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_7");
            entity.Property(e => e.FinalDisposition8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_8");
            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.InitiatedBy)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("INITIATED_BY");
            entity.Property(e => e.LastProcess)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("LAST_PROCESS");
            entity.Property(e => e.LineRework)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("LINE_REWORK");
            entity.Property(e => e.MdtNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MDT_NUMBER");
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MODEL_NUMBER");
            entity.Property(e => e.NewSerialOrLot1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_1");
            entity.Property(e => e.NewSerialOrLot2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_2");
            entity.Property(e => e.NewSerialOrLot3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_3");
            entity.Property(e => e.NewSerialOrLot4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_4");
            entity.Property(e => e.NewSerialOrLot5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_5");
            entity.Property(e => e.NewSerialOrLot6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_6");
            entity.Property(e => e.NewSerialOrLot7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_7");
            entity.Property(e => e.NewSerialOrLot8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_8");
            entity.Property(e => e.OldSerialOrLot1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_1");
            entity.Property(e => e.OldSerialOrLot2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_2");
            entity.Property(e => e.OldSerialOrLot3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_3");
            entity.Property(e => e.OldSerialOrLot4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_4");
            entity.Property(e => e.OldSerialOrLot5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_5");
            entity.Property(e => e.OldSerialOrLot6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_6");
            entity.Property(e => e.OldSerialOrLot7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_7");
            entity.Property(e => e.OldSerialOrLot8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_8");
            entity.Property(e => e.OracleItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ORACLE_ITEM");
            entity.Property(e => e.OracleReceipt)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ORACLE_RECEIPT");
            entity.Property(e => e.PartNumber1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_1");
            entity.Property(e => e.PartNumber2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_2");
            entity.Property(e => e.PartNumber3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_3");
            entity.Property(e => e.PartNumber4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_4");
            entity.Property(e => e.PartNumber5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_5");
            entity.Property(e => e.PartNumber6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_6");
            entity.Property(e => e.PartNumber7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_7");
            entity.Property(e => e.PartNumber8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_8");
            entity.Property(e => e.ProblemDesc)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESC");
            entity.Property(e => e.ProblemDescNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESC_NOTES");
            entity.Property(e => e.ProcessOption)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROCESS_OPTION");
            entity.Property(e => e.QaNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("QA_NOTES");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.ReplacedBy1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_1");
            entity.Property(e => e.ReplacedBy2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_2");
            entity.Property(e => e.ReplacedBy3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_3");
            entity.Property(e => e.ReplacedBy4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_4");
            entity.Property(e => e.ReplacedBy5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_5");
            entity.Property(e => e.ReplacedBy6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_6");
            entity.Property(e => e.ReplacedBy7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_7");
            entity.Property(e => e.ReplacedBy8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_8");
            entity.Property(e => e.ReplacedComponent1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_1");
            entity.Property(e => e.ReplacedComponent2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_2");
            entity.Property(e => e.ReplacedComponent3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_3");
            entity.Property(e => e.ReplacedComponent4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_4");
            entity.Property(e => e.ReplacedComponent5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_5");
            entity.Property(e => e.ReplacedComponent6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_6");
            entity.Property(e => e.ReplacedComponent7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_7");
            entity.Property(e => e.ReplacedComponent8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_8");
            entity.Property(e => e.ReplacementGivenBy1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_1");
            entity.Property(e => e.ReplacementGivenBy2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_2");
            entity.Property(e => e.ReplacementGivenBy3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_3");
            entity.Property(e => e.ReplacementGivenBy4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_4");
            entity.Property(e => e.ReplacementGivenBy5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_5");
            entity.Property(e => e.ReplacementGivenBy6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_6");
            entity.Property(e => e.ReplacementGivenBy7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_7");
            entity.Property(e => e.ReplacementGivenBy8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_8");
            entity.Property(e => e.ReplacementTakenFrom1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_1");
            entity.Property(e => e.ReplacementTakenFrom2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_2");
            entity.Property(e => e.ReplacementTakenFrom3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_3");
            entity.Property(e => e.ReplacementTakenFrom4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_4");
            entity.Property(e => e.ReplacementTakenFrom5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_5");
            entity.Property(e => e.ReplacementTakenFrom6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_6");
            entity.Property(e => e.ReplacementTakenFrom7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_7");
            entity.Property(e => e.ReplacementTakenFrom8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_8");
            entity.Property(e => e.ReworkRequired)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("REWORK_REQUIRED");
            entity.Property(e => e.ReworkStatus)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REWORK_STATUS");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.ServiceRequestNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TroubleshootingDetails)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("TROUBLESHOOTING_DETAILS");
            entity.Property(e => e.UnitDispBy)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UNIT_DISP_BY");
            entity.Property(e => e.UnitDispDate)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UNIT_DISP_DATE");
            entity.Property(e => e.UnitDisposition)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("UNIT_DISPOSITION");
            entity.Property(e => e.UnwipFromReworkDate)
                .HasColumnType("datetime")
                .HasColumnName("UNWIP_FROM_REWORK_DATE");
            entity.Property(e => e.WipToReworkDate)
                .HasColumnType("datetime")
                .HasColumnName("WIP_TO_REWORK_DATE");
        });

        modelBuilder.Entity<ReworkticketBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REWORKTICKET_BACKUP", "REWORK");

            entity.Property(e => e.AssemblyStation)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ASSEMBLY_STATION");
            entity.Property(e => e.AssignedInvestigation)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ASSIGNED_INVESTIGATION");
            entity.Property(e => e.Date1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_1");
            entity.Property(e => e.Date2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_2");
            entity.Property(e => e.Date3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_3");
            entity.Property(e => e.Date4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_4");
            entity.Property(e => e.Date5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_5");
            entity.Property(e => e.Date6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_6");
            entity.Property(e => e.Date7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_7");
            entity.Property(e => e.Date8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_8");
            entity.Property(e => e.DateCreated)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateReworkCompleted)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DATE_REWORK_COMPLETED");
            entity.Property(e => e.FieldRmaNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FIELD_RMA_NUMBER");
            entity.Property(e => e.FinalDisposition1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_1");
            entity.Property(e => e.FinalDisposition2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_2");
            entity.Property(e => e.FinalDisposition3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_3");
            entity.Property(e => e.FinalDisposition4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_4");
            entity.Property(e => e.FinalDisposition5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_5");
            entity.Property(e => e.FinalDisposition6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_6");
            entity.Property(e => e.FinalDisposition7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_7");
            entity.Property(e => e.FinalDisposition8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FINAL_DISPOSITION_8");
            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.InitiatedBy)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("INITIATED_BY");
            entity.Property(e => e.LastProcess)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("LAST_PROCESS");
            entity.Property(e => e.LineRework)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("LINE_REWORK");
            entity.Property(e => e.MdtNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MDT_NUMBER");
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MODEL_NUMBER");
            entity.Property(e => e.NewSerialOrLot1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_1");
            entity.Property(e => e.NewSerialOrLot2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_2");
            entity.Property(e => e.NewSerialOrLot3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_3");
            entity.Property(e => e.NewSerialOrLot4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_4");
            entity.Property(e => e.NewSerialOrLot5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_5");
            entity.Property(e => e.NewSerialOrLot6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_6");
            entity.Property(e => e.NewSerialOrLot7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_7");
            entity.Property(e => e.NewSerialOrLot8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SERIAL_OR_LOT_8");
            entity.Property(e => e.OldSerialOrLot1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_1");
            entity.Property(e => e.OldSerialOrLot2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_2");
            entity.Property(e => e.OldSerialOrLot3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_3");
            entity.Property(e => e.OldSerialOrLot4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_4");
            entity.Property(e => e.OldSerialOrLot5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_5");
            entity.Property(e => e.OldSerialOrLot6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_6");
            entity.Property(e => e.OldSerialOrLot7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_7");
            entity.Property(e => e.OldSerialOrLot8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SERIAL_OR_LOT_8");
            entity.Property(e => e.OracleReceipt)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ORACLE_RECEIPT");
            entity.Property(e => e.PartNumber1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_1");
            entity.Property(e => e.PartNumber2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_2");
            entity.Property(e => e.PartNumber3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_3");
            entity.Property(e => e.PartNumber4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_4");
            entity.Property(e => e.PartNumber5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_5");
            entity.Property(e => e.PartNumber6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_6");
            entity.Property(e => e.PartNumber7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_7");
            entity.Property(e => e.PartNumber8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER_8");
            entity.Property(e => e.ProblemDesc)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESC");
            entity.Property(e => e.ProblemDescNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESC_NOTES");
            entity.Property(e => e.ProcessOption)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROCESS_OPTION");
            entity.Property(e => e.QaNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("QA_NOTES");
            entity.Property(e => e.ReplacedBy1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_1");
            entity.Property(e => e.ReplacedBy2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_2");
            entity.Property(e => e.ReplacedBy3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_3");
            entity.Property(e => e.ReplacedBy4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_4");
            entity.Property(e => e.ReplacedBy5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_5");
            entity.Property(e => e.ReplacedBy6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_6");
            entity.Property(e => e.ReplacedBy7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_7");
            entity.Property(e => e.ReplacedBy8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_BY_8");
            entity.Property(e => e.ReplacedComponent1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_1");
            entity.Property(e => e.ReplacedComponent2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_2");
            entity.Property(e => e.ReplacedComponent3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_3");
            entity.Property(e => e.ReplacedComponent4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_4");
            entity.Property(e => e.ReplacedComponent5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_5");
            entity.Property(e => e.ReplacedComponent6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_6");
            entity.Property(e => e.ReplacedComponent7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_7");
            entity.Property(e => e.ReplacedComponent8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACED_COMPONENT_8");
            entity.Property(e => e.ReplacementGivenBy1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_1");
            entity.Property(e => e.ReplacementGivenBy2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_2");
            entity.Property(e => e.ReplacementGivenBy3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_3");
            entity.Property(e => e.ReplacementGivenBy4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_4");
            entity.Property(e => e.ReplacementGivenBy5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_5");
            entity.Property(e => e.ReplacementGivenBy6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_6");
            entity.Property(e => e.ReplacementGivenBy7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_7");
            entity.Property(e => e.ReplacementGivenBy8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_GIVEN_BY_8");
            entity.Property(e => e.ReplacementTakenFrom1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_1");
            entity.Property(e => e.ReplacementTakenFrom2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_2");
            entity.Property(e => e.ReplacementTakenFrom3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_3");
            entity.Property(e => e.ReplacementTakenFrom4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_4");
            entity.Property(e => e.ReplacementTakenFrom5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_5");
            entity.Property(e => e.ReplacementTakenFrom6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_6");
            entity.Property(e => e.ReplacementTakenFrom7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_7");
            entity.Property(e => e.ReplacementTakenFrom8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPLACEMENT_TAKEN_FROM_8");
            entity.Property(e => e.ReworkRequired)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("REWORK_REQUIRED");
            entity.Property(e => e.ReworkStatus)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REWORK_STATUS");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.ServiceRequestNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TroubleshootingDetails)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("TROUBLESHOOTING_DETAILS");
            entity.Property(e => e.UnitDispBy)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UNIT_DISP_BY");
            entity.Property(e => e.UnitDispDate)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UNIT_DISP_DATE");
            entity.Property(e => e.UnitDisposition)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("UNIT_DISPOSITION");
        });

        modelBuilder.Entity<RideTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ride_Test");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.OverallPassFail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OVERALL_PASS_FAIL");
            entity.Property(e => e.ProblemCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_CODE");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.Tester)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("TESTER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<RmtPivotAssembly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RMT_Pivot_Assembly");

            entity.Property(e => e.BoardsAssigned).HasColumnName("BOARDS_ASSIGNED");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FinishDate)
                .HasColumnType("datetime")
                .HasColumnName("FINISH_DATE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.OpenedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPENED_BY");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StressTests).HasColumnName("STRESS_TESTS");
            entity.Property(e => e.Technician)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN");
        });

        modelBuilder.Entity<RmtPtAssembly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RMT_PT_Assembly");

            entity.Property(e => e.AvailableForSale).HasColumnName("AVAILABLE_FOR_SALE");
            entity.Property(e => e.BatteryCharge).HasColumnName("BATTERY_CHARGE");
            entity.Property(e => e.BsaInstall).HasColumnName("BSA_INSTALL");
            entity.Property(e => e.BsaTest).HasColumnName("BSA_TEST");
            entity.Property(e => e.CodeLoaded).HasColumnName("CODE_LOADED");
            entity.Property(e => e.Controller).HasColumnName("CONTROLLER");
            entity.Property(e => e.CoverPlate).HasColumnName("COVER_PLATE");
            entity.Property(e => e.CuInstall).HasColumnName("CU_INSTALL");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Engrave).HasColumnName("ENGRAVE");
            entity.Property(e => e.FendersInstall).HasColumnName("FENDERS_INSTALL");
            entity.Property(e => e.FinishDate)
                .HasColumnType("datetime")
                .HasColumnName("FINISH_DATE");
            entity.Property(e => e.FobProgrammed).HasColumnName("FOB_PROGRAMMED");
            entity.Property(e => e.GearboxInstall).HasColumnName("GEARBOX_INSTALL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LedTest).HasColumnName("LED_TEST");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.MotorTests).HasColumnName("MOTOR_TESTS");
            entity.Property(e => e.MotorsInstall).HasColumnName("MOTORS_INSTALL");
            entity.Property(e => e.OpenedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPENED_BY");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.PivotInstall).HasColumnName("PIVOT_INSTALL");
            entity.Property(e => e.RadioProgrammed).HasColumnName("RADIO_PROGRAMMED");
            entity.Property(e => e.RideTest).HasColumnName("RIDE_TEST");
            entity.Property(e => e.RiderDetectTest).HasColumnName("RIDER_DETECT_TEST");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Sold).HasColumnName("SOLD");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Technician)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN");
            entity.Property(e => e.WheelsInstall).HasColumnName("WHEELS_INSTALL");
        });

        modelBuilder.Entity<RuntimeLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Runtime_Logs");

            entity.Property(e => e.Counter).HasColumnName("COUNTER");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogLevel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOG_LEVEL");
            entity.Property(e => e.LogName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOG_NAME");
            entity.Property(e => e.MachineName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("MACHINE_NAME");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.MethodName)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("METHOD_NAME");
            entity.Property(e => e.Row).HasColumnName("ROW");
            entity.Property(e => e.Thread).HasColumnName("THREAD");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.ToolName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("TOOL_NAME");
            entity.Property(e => e.ToolVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TOOL_VERSION");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SartBsaTestLimit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_BSA_Test_Limits");

            entity.Property(e => e.AcceptTime).HasColumnName("ACCEPT_TIME");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.FrontPitchCalibration).HasColumnName("FRONT_PITCH_CALIBRATION");
            entity.Property(e => e.FrontRollCalibration).HasColumnName("FRONT_ROLL_CALIBRATION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Pitch).HasColumnName("PITCH");
            entity.Property(e => e.Pitchcalibration).HasColumnName("PITCHCALIBRATION");
            entity.Property(e => e.Pitchvariance).HasColumnName("PITCHVARIANCE");
            entity.Property(e => e.RearPitchCalibration).HasColumnName("REAR_PITCH_CALIBRATION");
            entity.Property(e => e.RearRollCalibration).HasColumnName("REAR_ROLL_CALIBRATION");
            entity.Property(e => e.Roll).HasColumnName("ROLL");
            entity.Property(e => e.Rollcalibration).HasColumnName("ROLLCALIBRATION");
            entity.Property(e => e.Rollvariance).HasColumnName("ROLLVARIANCE");
            entity.Property(e => e.TestTimeout).HasColumnName("TEST_TIMEOUT");
        });

        modelBuilder.Entity<SartCoffFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_COFF_Files");

            entity.Property(e => e.BuildDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BUILD_DATE");
            entity.Property(e => e.BuildNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BUILD_NUMBER");
            entity.Property(e => e.Component)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPONENT");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.FilePath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FILE_PATH");
            entity.Property(e => e.Generation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENERATION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SartCuLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_CU_Logs");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.CuSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL");
            entity.Property(e => e.CuSerialEpic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL_EPIC");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeExtracted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_EXTRACTED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.LogData)
                .HasMaxLength(1300)
                .IsUnicode(false)
                .HasColumnName("LOG_DATA");
            entity.Property(e => e.Odometer).HasColumnName("ODOMETER");
            entity.Property(e => e.OperatingTime).HasColumnName("OPERATING_TIME");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL");
            entity.Property(e => e.SartExtraction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SART_EXTRACTION");
            entity.Property(e => e.Side)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SIDE");
            entity.Property(e => e.SwBuild)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_BUILD");
            entity.Property(e => e.SwPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_PART_NUMBER");
            entity.Property(e => e.SwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_VERSION");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartCuLogsB>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_CU_Logs_B");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.CuSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL");
            entity.Property(e => e.CuSerialEpic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL_EPIC");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeExtracted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_EXTRACTED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.LogData)
                .HasMaxLength(1300)
                .IsUnicode(false)
                .HasColumnName("LOG_DATA");
            entity.Property(e => e.Odometer).HasColumnName("ODOMETER");
            entity.Property(e => e.OperatingTime).HasColumnName("OPERATING_TIME");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL");
            entity.Property(e => e.SartExtraction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SART_EXTRACTION");
            entity.Property(e => e.Side)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SIDE");
            entity.Property(e => e.SwBuild)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_BUILD");
            entity.Property(e => e.SwPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_PART_NUMBER");
            entity.Property(e => e.SwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SW_VERSION");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartDisclaimer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Disclaimer");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_ID");
        });

        modelBuilder.Entity<SartEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Events");

            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EVENT");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ObjectId).HasColumnName("OBJECT_ID");
            entity.Property(e => e.ObjectType).HasColumnName("OBJECT_TYPE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StatusString)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("STATUS_STRING");
            entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_ID");
        });

        modelBuilder.Entity<SartEventLogEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Event_Log_Entry");

            entity.Property(e => e.ErrorDescription)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("ERROR_DESCRIPTION");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ObjectId).HasColumnName("OBJECT_ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TimestampEnd).HasColumnName("TIMESTAMP_END");
            entity.Property(e => e.TimestampStart).HasColumnName("TIMESTAMP_START");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartEventObject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Event_Object");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.EventType).HasColumnName("EVENT_TYPE");
            entity.Property(e => e.EventTypeString)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EVENT_TYPE_STRING");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StatusString)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS_STRING");
            entity.Property(e => e.TimestampEnd).HasColumnName("TIMESTAMP_END");
            entity.Property(e => e.TimestampStart).HasColumnName("TIMESTAMP_START");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WORK_ORDER_ID");
        });

        modelBuilder.Entity<SartEventType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Event_Types");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SartJtagVisibility>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_JTag_Visibility");

            entity.Property(e => e.AuthorityName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHORITY_NAME");
            entity.Property(e => e.DateTimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_END");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeStart)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_START");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrderNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_NUMBER");
        });

        modelBuilder.Entity<SartMotorDiagnosticDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Motor_Diagnostic_Data");

            entity.Property(e => e.CuaLeft)
                .IsUnicode(false)
                .HasColumnName("CUA_LEFT");
            entity.Property(e => e.CuaRight)
                .IsUnicode(false)
                .HasColumnName("CUA_RIGHT");
            entity.Property(e => e.CubLeft)
                .IsUnicode(false)
                .HasColumnName("CUB_LEFT");
            entity.Property(e => e.CubRight)
                .IsUnicode(false)
                .HasColumnName("CUB_RIGHT");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DataKey).HasColumnName("DATA_KEY");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MaxLimit)
                .IsUnicode(false)
                .HasColumnName("MAX_LIMIT");
            entity.Property(e => e.MinLimit)
                .IsUnicode(false)
                .HasColumnName("MIN_LIMIT");
            entity.Property(e => e.RunId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RUN_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.TestComponent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEST_COMPONENT");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEST_NAME");
            entity.Property(e => e.TestRun).HasColumnName("TEST_RUN");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartMotorDiagnosticGraphDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Motor_Diagnostic_Graph_Data");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.GraphKey).HasColumnName("GRAPH_KEY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RunId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RUN_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.TestComponent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEST_COMPONENT");
            entity.Property(e => e.TestKey).HasColumnName("TEST_KEY");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEST_NAME");
            entity.Property(e => e.TestRun).HasColumnName("TEST_RUN");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartMotorDiagnosticGraphTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Motor_Diagnostic_Graph_Test");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RunId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RUN_ID");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.TestKey)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TEST_KEY");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartMotorDiagnosticGraphValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Motor_Diagnostic_Graph_Values");

            entity.Property(e => e.CuALeft).HasColumnName("CU_A_LEFT");
            entity.Property(e => e.CuARight).HasColumnName("CU_A_RIGHT");
            entity.Property(e => e.CuBLeft).HasColumnName("CU_B_LEFT");
            entity.Property(e => e.CuBRight).HasColumnName("CU_B_RIGHT");
            entity.Property(e => e.GraphKey).HasColumnName("GRAPH_KEY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MaxLimit).HasColumnName("MAX_LIMIT");
            entity.Property(e => e.MinLimit).HasColumnName("MIN_LIMIT");
            entity.Property(e => e.Xvalue).HasColumnName("XVALUE");
        });

        modelBuilder.Entity<SartPicture>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Pictures");

            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PictureData).HasColumnName("PICTURE_DATA");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.UniqueName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("UNIQUE_NAME");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_ID");
        });

        modelBuilder.Entity<SartPtConfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_PT_Configuration");

            entity.Property(e => e.BsaADate).HasColumnName("BSA_A_DATE");
            entity.Property(e => e.BsaAPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_A_PART_NUMBER");
            entity.Property(e => e.BsaASerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_A_SERIAL");
            entity.Property(e => e.BsaASwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_A_SW_VERSION");
            entity.Property(e => e.BsaAUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_A_USER");
            entity.Property(e => e.BsaBDate).HasColumnName("BSA_B_DATE");
            entity.Property(e => e.BsaBPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_B_PART_NUMBER");
            entity.Property(e => e.BsaBSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_B_SERIAL");
            entity.Property(e => e.BsaBSwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_B_SW_VERSION");
            entity.Property(e => e.BsaBUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BSA_B_USER");
            entity.Property(e => e.CuaDate).HasColumnName("CUA_DATE");
            entity.Property(e => e.CuaPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUA_PART_NUMBER");
            entity.Property(e => e.CuaSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUA_SERIAL");
            entity.Property(e => e.CuaSwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUA_SW_VERSION");
            entity.Property(e => e.CuaUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUA_USER");
            entity.Property(e => e.CubDate).HasColumnName("CUB_DATE");
            entity.Property(e => e.CubPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUB_PART_NUMBER");
            entity.Property(e => e.CubSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUB_SERIAL");
            entity.Property(e => e.CubSwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUB_SW_VERSION");
            entity.Property(e => e.CubUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUB_USER");
            entity.Property(e => e.DateTimeCreated).HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MotorlDate).HasColumnName("MOTORL_DATE");
            entity.Property(e => e.MotorlPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORL_PART_NUMBER");
            entity.Property(e => e.MotorlSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORL_SERIAL");
            entity.Property(e => e.MotorlType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORL_TYPE");
            entity.Property(e => e.MotorlUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORL_USER");
            entity.Property(e => e.MotorrDate).HasColumnName("MOTORR_DATE");
            entity.Property(e => e.MotorrPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORR_PART_NUMBER");
            entity.Property(e => e.MotorrSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORR_SERIAL");
            entity.Property(e => e.MotorrType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORR_TYPE");
            entity.Property(e => e.MotorrUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOTORR_USER");
            entity.Property(e => e.PivotDate).HasColumnName("PIVOT_DATE");
            entity.Property(e => e.PivotPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PIVOT_PART_NUMBER");
            entity.Property(e => e.PivotSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PIVOT_SERIAL");
            entity.Property(e => e.PivotUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PIVOT_USER");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UicDate).HasColumnName("UIC_DATE");
            entity.Property(e => e.UicPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIC_PART_NUMBER");
            entity.Property(e => e.UicSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIC_SERIAL");
            entity.Property(e => e.UicSid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIC_SID");
            entity.Property(e => e.UicSwVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIC_SW_VERSION");
            entity.Property(e => e.UicType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIC_TYPE");
            entity.Property(e => e.UicUser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIC_USER");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartRepairApprovalCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Repair_Approval_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
        });

        modelBuilder.Entity<SartRepairBillingCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Repair_Billing_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
        });

        modelBuilder.Entity<SartRepairChangeCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Repair_Change_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
        });

        modelBuilder.Entity<SartRepairInstalledCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Repair_Installed_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
        });

        modelBuilder.Entity<SartRepairLocationCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Repair_Location_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("Row_Pointer");
        });

        modelBuilder.Entity<SartRideTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Ride_Test");

            entity.Property(e => e.Accelerate).HasColumnName("ACCELERATE");
            entity.Property(e => e.AxisLeft).HasColumnName("AXIS_LEFT");
            entity.Property(e => e.AxisRight).HasColumnName("AXIS_RIGHT");
            entity.Property(e => e.BalanceOff).HasColumnName("BALANCE_OFF");
            entity.Property(e => e.BalanceOn).HasColumnName("BALANCE_ON");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Decelerate).HasColumnName("DECELERATE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PowerOff).HasColumnName("POWER_OFF");
            entity.Property(e => e.PowerOn).HasColumnName("POWER_ON");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL");
            entity.Property(e => e.Stationary).HasColumnName("STATIONARY");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<SartSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Settings");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DelayDiagnosticWakeup).HasColumnName("DELAY_DIAGNOSTIC_WAKEUP");
            entity.Property(e => e.DelayFullStop)
                .HasDefaultValueSql("((3000))")
                .HasColumnName("DELAY_FULL_STOP");
            entity.Property(e => e.DelayLedtestWakeup)
                .HasDefaultValueSql("((6000))")
                .HasColumnName("DELAY_LEDTEST_WAKEUP");
            entity.Property(e => e.DelayWakeStart).HasColumnName("DELAY_WAKE_START");
            entity.Property(e => e.DelayWakeStartWireless)
                .HasDefaultValueSql("((5000))")
                .HasColumnName("DELAY_WAKE_START_WIRELESS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MotorRampIncrement)
                .HasDefaultValueSql("((20))")
                .HasColumnName("MOTOR_RAMP_INCREMENT");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.TimeoutAppletReady).HasColumnName("TIMEOUT_APPLET_READY");
            entity.Property(e => e.TimeoutBsaSpiEnterBoot)
                .HasDefaultValueSql("((5000))")
                .HasColumnName("TIMEOUT_BSA_SPI_ENTER_BOOT");
            entity.Property(e => e.TimeoutEnterDiagnosticMode)
                .HasDefaultValueSql("((5000))")
                .HasColumnName("TIMEOUT_ENTER_DIAGNOSTIC_MODE");
            entity.Property(e => e.TimeoutHeartbeat).HasColumnName("TIMEOUT_HEARTBEAT");
            entity.Property(e => e.TimeoutRamp)
                .HasDefaultValueSql("((2500))")
                .HasColumnName("TIMEOUT_RAMP");
            entity.Property(e => e.TimeoutStartApplet).HasColumnName("TIMEOUT_START_APPLET");
            entity.Property(e => e.TimeoutStartAppletResponse).HasColumnName("TIMEOUT_START_APPLET_RESPONSE");
            entity.Property(e => e.TimeoutWatchVariables).HasColumnName("TIMEOUT_WATCH_VARIABLES");
        });

        modelBuilder.Entity<SartSroType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_SRO_Types");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SroType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SRO_TYPE");
        });

        modelBuilder.Entity<SartUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Users");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Level)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEVEL");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<SartUserSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_User_Settings");

            entity.Property(e => e.BackgroundBase).HasColumnName("BACKGROUND_BASE");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DefaultDisclaimer).HasColumnName("DEFAULT_DISCLAIMER");
            entity.Property(e => e.DelayWakeStart).HasColumnName("DELAY_WAKE_START");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SartSettingsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SART_SETTINGS_NAME");
            entity.Property(e => e.TimeoutStartApplet).HasColumnName("TIMEOUT_START_APPLET");
            entity.Property(e => e.TimeoutStartAppletResponse).HasColumnName("TIMEOUT_START_APPLET_RESPONSE");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SartWoComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_WO_Components");

            entity.Property(e => e.BillableCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BILLABLE_CODE");
            entity.Property(e => e.ChangeApproval)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHANGE_APPROVAL");
            entity.Property(e => e.ChangeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Installed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.PartName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.Quantity)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QUANTITY");
            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.SerialNumberNew)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER_NEW");
            entity.Property(e => e.SerialNumberOld)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER_OLD");
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERVICE_CODE");
            entity.Property(e => e.UnitOfMeasure)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UNIT_OF_MEASURE");
            entity.Property(e => e.Warranty)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WARRANTY");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_ID");
        });

        modelBuilder.Entity<SartWorkOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SART_Work_Order");

            entity.Property(e => e.ASideTime)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("A_SIDE_TIME");
            entity.Property(e => e.AdditionalNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("ADDITIONAL_NOTES");
            entity.Property(e => e.ApprovalReceived)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_RECEIVED");
            entity.Property(e => e.BSideTime)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("B_SIDE_TIME");
            entity.Property(e => e.BattCommentsFront)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("BATT_COMMENTS_FRONT");
            entity.Property(e => e.BattCommentsRear)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("BATT_COMMENTS_REAR");
            entity.Property(e => e.BatteryRbatFront)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATTERY_RBAT_FRONT");
            entity.Property(e => e.BatteryRbatRear)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATTERY_RBAT_REAR");
            entity.Property(e => e.BatterySerialFront)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_FRONT");
            entity.Property(e => e.BatterySerialRear)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_REAR");
            entity.Property(e => e.BatteryStatusFront)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_STATUS_FRONT");
            entity.Property(e => e.BatteryStatusRear)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_STATUS_REAR");
            entity.Property(e => e.BsaCode).HasColumnName("BSA_CODE");
            entity.Property(e => e.BsaFixed).HasColumnName("BSA_FIXED");
            entity.Property(e => e.ConfigFinalOverride).HasColumnName("CONFIG_FINAL_OVERRIDE");
            entity.Property(e => e.ConfigStartOverride).HasColumnName("CONFIG_START_OVERRIDE");
            entity.Property(e => e.ConfigureFinal).HasColumnName("CONFIGURE_FINAL");
            entity.Property(e => e.ConfigureStart).HasColumnName("CONFIGURE_START");
            entity.Property(e => e.CuACode).HasColumnName("CU_A_CODE");
            entity.Property(e => e.CuALog).HasColumnName("CU_A_LOG");
            entity.Property(e => e.CuALogClear).HasColumnName("CU_A_LOG_CLEAR");
            entity.Property(e => e.CuALogCode).HasColumnName("CU_A_LOG_CODE");
            entity.Property(e => e.CuALogLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CU_A_LOG_LINK");
            entity.Property(e => e.CuBCode).HasColumnName("CU_B_CODE");
            entity.Property(e => e.CuBLog).HasColumnName("CU_B_LOG");
            entity.Property(e => e.CuBLogClear).HasColumnName("CU_B_LOG_CLEAR");
            entity.Property(e => e.CuBLogCode).HasColumnName("CU_B_LOG_CODE");
            entity.Property(e => e.CuBLogLink)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CU_B_LOG_LINK");
            entity.Property(e => e.CustomerComplaint)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_COMPLAINT");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateCompleted1)
                .HasColumnType("datetime")
                .HasColumnName("DATE_COMPLETED_1");
            entity.Property(e => e.DateCompleted2)
                .HasColumnType("datetime")
                .HasColumnName("DATE_COMPLETED_2");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DiagBsaTest).HasColumnName("DIAG_BSA_TEST");
            entity.Property(e => e.DiagCsb).HasColumnName("DIAG_CSB");
            entity.Property(e => e.DiagCsb1).HasColumnName("DIAG_CSB_1");
            entity.Property(e => e.DiagHipot).HasColumnName("DIAG_HIPOT");
            entity.Property(e => e.DiagHipot1).HasColumnName("DIAG_HIPOT_1");
            entity.Property(e => e.DiagLedTest).HasColumnName("DIAG_LED_TEST");
            entity.Property(e => e.DiagMotor).HasColumnName("DIAG_MOTOR");
            entity.Property(e => e.DiagMotor1).HasColumnName("DIAG_MOTOR_1");
            entity.Property(e => e.DiagMotorLeftTest).HasColumnName("DIAG_MOTOR_LEFT_TEST");
            entity.Property(e => e.DiagMotorRightTest).HasColumnName("DIAG_MOTOR_RIGHT_TEST");
            entity.Property(e => e.DiagMotorTest).HasColumnName("DIAG_MOTOR_TEST");
            entity.Property(e => e.DiagNormRatio).HasColumnName("DIAG_NORM_RATIO");
            entity.Property(e => e.DiagNormRatio1).HasColumnName("DIAG_NORM_RATIO_1");
            entity.Property(e => e.DiagPowerbase).HasColumnName("DIAG_POWERBASE");
            entity.Property(e => e.DiagPowerbase1).HasColumnName("DIAG_POWERBASE_1");
            entity.Property(e => e.DiagPowerbaseTest).HasColumnName("DIAG_POWERBASE_TEST");
            entity.Property(e => e.DiagRiderDetectTest).HasColumnName("DIAG_RIDER_DETECT_TEST");
            entity.Property(e => e.DiagUi).HasColumnName("DIAG_UI");
            entity.Property(e => e.DiagUi1).HasColumnName("DIAG_UI_1");
            entity.Property(e => e.DiagUiTest).HasColumnName("DIAG_UI_TEST");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ERROR_CODE");
            entity.Property(e => e.ErrorCodeNoStart).HasColumnName("ERROR_CODE_NO_START");
            entity.Property(e => e.ErrorCodeNone).HasColumnName("ERROR_CODE_NONE");
            entity.Property(e => e.ErrorCodeNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ERROR_CODE_NOTES");
            entity.Property(e => e.FailureReason1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILURE_REASON_1");
            entity.Property(e => e.FailureReason2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILURE_REASON_2");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.Hours)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("HOURS");
            entity.Property(e => e.HyperElcon)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("HYPER_ELCON");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LaborHours).HasColumnName("LABOR_HOURS");
            entity.Property(e => e.LaborHoursPb).HasColumnName("LABOR_HOURS_PB");
            entity.Property(e => e.ManagementApproved)
                .HasColumnType("datetime")
                .HasColumnName("MANAGEMENT_APPROVED");
            entity.Property(e => e.ManagementRejected)
                .HasColumnType("datetime")
                .HasColumnName("MANAGEMENT_REJECTED");
            entity.Property(e => e.Minutes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MINUTES");
            entity.Property(e => e.NewPbPn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_PB_PN");
            entity.Property(e => e.NewPbSn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_PB_SN");
            entity.Property(e => e.OdometerReading)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODOMETER_READING");
            entity.Property(e => e.OpenedBy)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OPENED_BY");
            entity.Property(e => e.OpsComments)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("OPS_COMMENTS");
            entity.Property(e => e.Owner)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.PbServiceRequest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PB_SERVICE_REQUEST");
            entity.Property(e => e.PictureLinks)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PICTURE_LINKS");
            entity.Property(e => e.Priority)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRIORITY");
            entity.Property(e => e.ProblemDescription)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESCRIPTION");
            entity.Property(e => e.ProductReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRODUCT_RECEIVED");
            entity.Property(e => e.ProductShipped).HasColumnName("PRODUCT_SHIPPED");
            entity.Property(e => e.PtModel)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PT_MODEL");
            entity.Property(e => e.PtPartNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PT_PART_NUMBER");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL");
            entity.Property(e => e.QuoteNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("QUOTE_NOTES");
            entity.Property(e => e.QuoteSent)
                .HasColumnType("datetime")
                .HasColumnName("QUOTE_SENT");
            entity.Property(e => e.RecBatteries)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_BATTERIES");
            entity.Property(e => e.RecChargeport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_CHARGEPORT");
            entity.Property(e => e.RecComfortmats)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_COMFORTMATS");
            entity.Property(e => e.RecConsoletrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_CONSOLETRIM");
            entity.Property(e => e.RecDamaged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("REC_DAMAGED");
            entity.Property(e => e.RecFenders)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_FENDERS");
            entity.Property(e => e.RecG1Keys)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_G1_KEYS");
            entity.Property(e => e.RecHubcaps)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_HUBCAPS");
            entity.Property(e => e.RecInfokeys)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_INFOKEYS");
            entity.Property(e => e.RecKickstand)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_KICKSTAND");
            entity.Property(e => e.RecMats)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_MATS");
            entity.Property(e => e.RecNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("REC_NOTES");
            entity.Property(e => e.RecWheels)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REC_WHEELS");
            entity.Property(e => e.RefurbPb)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REFURB_PB");
            entity.Property(e => e.RepairComplete1).HasColumnName("REPAIR_COMPLETE_1");
            entity.Property(e => e.RepairComplete2).HasColumnName("REPAIR_COMPLETE_2");
            entity.Property(e => e.RepairPerformed)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("REPAIR_PERFORMED");
            entity.Property(e => e.RepairType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPAIR_TYPE");
            entity.Property(e => e.ReportNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPORT_NUMBER");
            entity.Property(e => e.RideTest).HasColumnName("RIDE_TEST");
            entity.Property(e => e.RmaNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RMA_NUMBER");
            entity.Property(e => e.Rowpointer).HasColumnName("ROWPOINTER");
            entity.Property(e => e.SalesOrder)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SALES_ORDER");
            entity.Property(e => e.SegwayObservation)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SEGWAY_OBSERVATION");
            entity.Property(e => e.ServiceRequest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST");
            entity.Property(e => e.ServiceRequestId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST_ID");
            entity.Property(e => e.ShippedDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED_DATE");
            entity.Property(e => e.StartDate1)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_1");
            entity.Property(e => e.StartDate2)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_2");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TechnicianName1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN_NAME_1");
            entity.Property(e => e.TechnicianName2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN_NAME_2");
            entity.Property(e => e.TechnicianObservation)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN_OBSERVATION");
            entity.Property(e => e.TirePassFail2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIRE_PASS_FAIL_2");
            entity.Property(e => e.TirePressure).HasColumnName("TIRE_PRESSURE");
            entity.Property(e => e.TirePsiLeft)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIRE_PSI_LEFT");
            entity.Property(e => e.TirePsiLeftRcv)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIRE_PSI_LEFT_RCV");
            entity.Property(e => e.TirePsiLeftShp)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIRE_PSI_LEFT_SHP");
            entity.Property(e => e.TirePsiRight)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIRE_PSI_RIGHT");
            entity.Property(e => e.TirePsiRightRcv)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIRE_PSI_RIGHT_RCV");
            entity.Property(e => e.TirePsiRightShp)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIRE_PSI_RIGHT_SHP");
            entity.Property(e => e.TransactionComplete).HasColumnName("TRANSACTION_COMPLETE");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("TRANSACTION_DATE");
            entity.Property(e => e.UnitCleaned).HasColumnName("UNIT_CLEANED");
            entity.Property(e => e.UnitCondition)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("UNIT_CONDITION");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.WaitCustomerApproval).HasColumnName("WAIT_CUSTOMER_APPROVAL");
            entity.Property(e => e.Warranty).HasColumnName("WARRANTY");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_ID");
            entity.Property(e => e.WorkingStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORKING_STATUS");
        });

        modelBuilder.Entity<Se3OnboardSoftware>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SE3_Onboard_Software");

            entity.Property(e => e.Component)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("File_Path");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VersionNumber).HasColumnName("Version_Number");
        });

        modelBuilder.Entity<Se3OnboardSoftware1>(entity =>
        {
            entity.ToTable("Se3OnboardSoftware");

            entity.Property(e => e.Component)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Se3ThrottleCalibrationValue>(entity =>
        {
            entity.HasKey(e => e.PlaId);

            entity.Property(e => e.PlaId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Security");

            entity.Property(e => e.BsaJtagLock)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_JTAG_LOCK");
            entity.Property(e => e.ConsoleRadioSid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSOLE_RADIO_SID");
            entity.Property(e => e.ConsoleRadioWid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSOLE_RADIO_WID");
            entity.Property(e => e.CuAJtagLock)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_JTAG_LOCK");
            entity.Property(e => e.CuBJtagLock)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_JTAG_LOCK");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FobRadioSid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_RADIO_SID");
            entity.Property(e => e.FobRadioWid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_RADIO_WID");
            entity.Property(e => e.RadioChannelConfiguration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RADIO_CHANNEL_CONFIGURATION");
            entity.Property(e => e.RadioEncryptionKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RADIO_ENCRYPTION_KEY");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.ServiceKeyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_KEY_CODE");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
            entity.Property(e => e.UserKeyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_KEY_CODE");
        });

        modelBuilder.Entity<SegFsSroLineRecTest>(entity =>
        {
            entity.HasKey(e => e.Rowpointer).HasName("PK__Seg_FS_S__8B3A161637E53D9E");

            entity.ToTable("Seg_FS_SRO_Line_Rec_Test");

            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.AdditionalNotes)
                .HasMaxLength(4000)
                .HasColumnName("ADDITIONAL_NOTES");
            entity.Property(e => e.ApprovalReceived)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_RECEIVED");
            entity.Property(e => e.Batteries)
                .HasMaxLength(10)
                .HasColumnName("BATTERIES");
            entity.Property(e => e.Batterya)
                .HasMaxLength(15)
                .HasColumnName("BATTERYA");
            entity.Property(e => e.Batteryb)
                .HasMaxLength(15)
                .HasColumnName("BATTERYB");
            entity.Property(e => e.BsaCode).HasColumnName("BSA_CODE");
            entity.Property(e => e.BsaFixed).HasColumnName("BSA_FIXED");
            entity.Property(e => e.Chargeport)
                .HasMaxLength(10)
                .HasColumnName("CHARGEPORT");
            entity.Property(e => e.Comfortmats)
                .HasMaxLength(10)
                .HasColumnName("COMFORTMATS");
            entity.Property(e => e.ConfigurationOverride).HasColumnName("CONFIGURATION_OVERRIDE");
            entity.Property(e => e.ConfigureFinish).HasColumnName("CONFIGURE_FINISH");
            entity.Property(e => e.ConfigureStart).HasColumnName("CONFIGURE_START");
            entity.Property(e => e.Consoletrim)
                .HasMaxLength(10)
                .HasColumnName("CONSOLETRIM");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(30)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.CsbRcv).HasColumnName("CSB_RCV");
            entity.Property(e => e.CsbShp).HasColumnName("CSB_SHP");
            entity.Property(e => e.CuACode).HasColumnName("CU_A_CODE");
            entity.Property(e => e.CuALog).HasColumnName("CU_A_LOG");
            entity.Property(e => e.CuALogClear).HasColumnName("CU_A_LOG_CLEAR");
            entity.Property(e => e.CuALogCode).HasColumnName("CU_A_LOG_CODE");
            entity.Property(e => e.CuBCode).HasColumnName("CU_B_CODE");
            entity.Property(e => e.CuBLog).HasColumnName("CU_B_LOG");
            entity.Property(e => e.CuBLogClear).HasColumnName("CU_B_LOG_CLEAR");
            entity.Property(e => e.CuBLogCode).HasColumnName("CU_B_LOG_CODE");
            entity.Property(e => e.Datecompleted)
                .HasColumnType("datetime")
                .HasColumnName("DATECOMPLETED");
            entity.Property(e => e.Datequoted)
                .HasColumnType("datetime")
                .HasColumnName("DATEQUOTED");
            entity.Property(e => e.Dateshipped)
                .HasColumnType("datetime")
                .HasColumnName("DATESHIPPED");
            entity.Property(e => e.Datetrans)
                .HasColumnType("datetime")
                .HasColumnName("DATETRANS");
            entity.Property(e => e.DiagBsaTest).HasColumnName("DIAG_BSA_TEST");
            entity.Property(e => e.DiagLedTest).HasColumnName("DIAG_LED_TEST");
            entity.Property(e => e.DiagMotorLeftTest).HasColumnName("DIAG_MOTOR_LEFT_TEST");
            entity.Property(e => e.DiagMotorRightTest).HasColumnName("DIAG_MOTOR_RIGHT_TEST");
            entity.Property(e => e.DiagMotorTest).HasColumnName("DIAG_MOTOR_TEST");
            entity.Property(e => e.DiagOtherTest).HasColumnName("DIAG_OTHER_TEST");
            entity.Property(e => e.DiagPowerbaseTest).HasColumnName("DIAG_POWERBASE_TEST");
            entity.Property(e => e.DiagRiderDefectTest).HasColumnName("DIAG_RIDER_DEFECT_TEST");
            entity.Property(e => e.DiagUiTest).HasColumnName("DIAG_UI_TEST");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(5)
                .HasColumnName("ERROR_CODE");
            entity.Property(e => e.ErrorCodeNoStart).HasColumnName("ERROR_CODE_NO_START");
            entity.Property(e => e.ErrorCodeNone).HasColumnName("ERROR_CODE_NONE");
            entity.Property(e => e.Errorcodenote)
                .HasMaxLength(4000)
                .HasColumnName("ERRORCODENOTE");
            entity.Property(e => e.Failreasona)
                .HasMaxLength(30)
                .HasColumnName("FAILREASONA");
            entity.Property(e => e.Failreasonb)
                .HasMaxLength(30)
                .HasColumnName("FAILREASONB");
            entity.Property(e => e.Faultloga)
                .HasMaxLength(75)
                .HasColumnName("FAULTLOGA");
            entity.Property(e => e.Faultlogb)
                .HasMaxLength(75)
                .HasColumnName("FAULTLOGB");
            entity.Property(e => e.Fenders)
                .HasMaxLength(10)
                .HasColumnName("FENDERS");
            entity.Property(e => e.G1keysBlack).HasColumnName("G1KEYS_BLACK");
            entity.Property(e => e.G1keysBlue).HasColumnName("G1KEYS_BLUE");
            entity.Property(e => e.G1keysLegacy)
                .HasMaxLength(10)
                .HasColumnName("G1KEYS_LEGACY");
            entity.Property(e => e.G1keysRed).HasColumnName("G1KEYS_RED");
            entity.Property(e => e.G1keysYellow).HasColumnName("G1KEYS_YELLOW");
            entity.Property(e => e.HipotRcv).HasColumnName("HIPOT_RCV");
            entity.Property(e => e.HipotShp).HasColumnName("HIPOT_SHP");
            entity.Property(e => e.Hubcaps)
                .HasMaxLength(10)
                .HasColumnName("HUBCAPS");
            entity.Property(e => e.HyperElcon)
                .HasMaxLength(32)
                .HasColumnName("HYPER_ELCON");
            entity.Property(e => e.Infokeys)
                .HasMaxLength(10)
                .HasColumnName("INFOKEYS");
            entity.Property(e => e.Inworkflow).HasColumnName("INWORKFLOW");
            entity.Property(e => e.Kickstand)
                .HasMaxLength(10)
                .HasColumnName("KICKSTAND");
            entity.Property(e => e.LaborHrsPb).HasColumnName("LABOR_HRS_PB");
            entity.Property(e => e.Laborhrs).HasColumnName("LABORHRS");
            entity.Property(e => e.ManagementApproved)
                .HasColumnType("datetime")
                .HasColumnName("MANAGEMENT_APPROVED");
            entity.Property(e => e.ManagementRejected)
                .HasColumnType("datetime")
                .HasColumnName("MANAGEMENT_REJECTED");
            entity.Property(e => e.Mats)
                .HasMaxLength(10)
                .HasColumnName("MATS");
            entity.Property(e => e.Minutes)
                .HasMaxLength(5)
                .HasColumnName("MINUTES");
            entity.Property(e => e.MotordiagRcv).HasColumnName("MOTORDIAG_RCV");
            entity.Property(e => e.MotordiagShp).HasColumnName("MOTORDIAG_SHP");
            entity.Property(e => e.NewPbPn)
                .HasMaxLength(32)
                .HasColumnName("NEW_PB_PN");
            entity.Property(e => e.NewPbSn)
                .HasMaxLength(32)
                .HasColumnName("NEW_PB_SN");
            entity.Property(e => e.NormratiofailRcv).HasColumnName("NORMRATIOFAIL_RCV");
            entity.Property(e => e.NormratiofailShp).HasColumnName("NORMRATIOFAIL_SHP");
            entity.Property(e => e.Noteexistsflag).HasColumnName("NOTEEXISTSFLAG");
            entity.Property(e => e.Observationsnote).HasColumnName("OBSERVATIONSNOTE");
            entity.Property(e => e.OdometerReading)
                .HasMaxLength(10)
                .HasColumnName("ODOMETER_READING");
            entity.Property(e => e.OpsComments)
                .HasMaxLength(4000)
                .HasColumnName("OPS_COMMENTS");
            entity.Property(e => e.Owner)
                .HasMaxLength(50)
                .HasColumnName("OWNER");
            entity.Property(e => e.Passfaila).HasColumnName("PASSFAILA");
            entity.Property(e => e.Passfailb).HasColumnName("PASSFAILB");
            entity.Property(e => e.PbServiceRequest)
                .HasMaxLength(32)
                .HasColumnName("PB_SERVICE_REQUEST");
            entity.Property(e => e.ProblemDescription)
                .HasMaxLength(4000)
                .HasColumnName("PROBLEM_DESCRIPTION");
            entity.Property(e => e.Prodshipped).HasColumnName("PRODSHIPPED");
            entity.Property(e => e.ProductReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRODUCT_RECEIVED");
            entity.Property(e => e.PwrbaseRcv).HasColumnName("PWRBASE_RCV");
            entity.Property(e => e.PwrbaseShp).HasColumnName("PWRBASE_SHP");
            entity.Property(e => e.Quotenote)
                .HasMaxLength(4000)
                .HasColumnName("QUOTENOTE");
            entity.Property(e => e.Rcvdamaged).HasColumnName("RCVDAMAGED");
            entity.Property(e => e.Readytoquote).HasColumnName("READYTOQUOTE");
            entity.Property(e => e.Receivingnote)
                .HasMaxLength(4000)
                .HasColumnName("RECEIVINGNOTE");
            entity.Property(e => e.Recorddate)
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
            entity.Property(e => e.RepairPerformed)
                .HasMaxLength(4000)
                .HasColumnName("REPAIR_PERFORMED");
            entity.Property(e => e.RepairType)
                .HasMaxLength(32)
                .HasColumnName("REPAIR_TYPE");
            entity.Property(e => e.Repaircompleted).HasColumnName("REPAIRCOMPLETED");
            entity.Property(e => e.Repairperformednote)
                .HasMaxLength(4000)
                .HasColumnName("REPAIRPERFORMEDNOTE");
            entity.Property(e => e.ReportNumber)
                .HasMaxLength(32)
                .HasColumnName("REPORT_NUMBER");
            entity.Property(e => e.Reva)
                .HasMaxLength(20)
                .HasColumnName("REVA");
            entity.Property(e => e.Revb)
                .HasMaxLength(20)
                .HasColumnName("REVB");
            entity.Property(e => e.RmaNumber)
                .HasMaxLength(50)
                .HasColumnName("RMA_NUMBER");
            entity.Property(e => e.SalesOrder)
                .HasMaxLength(32)
                .HasColumnName("SALES_ORDER");
            entity.Property(e => e.SegwayObservation)
                .HasMaxLength(4000)
                .HasColumnName("SEGWAY_OBSERVATION");
            entity.Property(e => e.Seriala)
                .HasMaxLength(30)
                .HasColumnName("SERIALA");
            entity.Property(e => e.Serialb)
                .HasMaxLength(30)
                .HasColumnName("SERIALB");
            entity.Property(e => e.SroLine)
                .HasMaxLength(9)
                .HasColumnName("SRO_LINE");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("SRO_NUM");
            entity.Property(e => e.StartDate1)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_1");
            entity.Property(e => e.StartDate2)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_2");
            entity.Property(e => e.Timea)
                .HasMaxLength(12)
                .HasColumnName("TIMEA");
            entity.Property(e => e.Timeb)
                .HasMaxLength(12)
                .HasColumnName("TIMEB");
            entity.Property(e => e.TirePsi)
                .HasMaxLength(15)
                .HasColumnName("TIRE_PSI");
            entity.Property(e => e.TirePsi1)
                .HasMaxLength(15)
                .HasColumnName("TIRE_PSI1");
            entity.Property(e => e.TirePsiLeftRcv).HasColumnName("TIRE_PSI_LEFT_RCV");
            entity.Property(e => e.TirePsiLeftShp).HasColumnName("TIRE_PSI_LEFT_SHP");
            entity.Property(e => e.TirePsiRightRcv).HasColumnName("TIRE_PSI_RIGHT_RCV");
            entity.Property(e => e.TirePsiRightShp).HasColumnName("TIRE_PSI_RIGHT_SHP");
            entity.Property(e => e.TirepsiRcv)
                .HasMaxLength(11)
                .HasColumnName("TIREPSI_RCV");
            entity.Property(e => e.TirepsiShp)
                .HasMaxLength(11)
                .HasColumnName("TIREPSI_SHP");
            entity.Property(e => e.Transcompleted).HasColumnName("TRANSCOMPLETED");
            entity.Property(e => e.UiRcv).HasColumnName("UI_RCV");
            entity.Property(e => e.UiShp).HasColumnName("UI_SHP");
            entity.Property(e => e.UnitCleaned).HasColumnName("UNIT_CLEANED");
            entity.Property(e => e.UnitCondition)
                .HasMaxLength(4000)
                .HasColumnName("UNIT_CONDITION");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(30)
                .HasColumnName("UPDATEDBY");
            entity.Property(e => e.WaitCustomerApproval).HasColumnName("WAIT_CUSTOMER_APPROVAL");
            entity.Property(e => e.Wheels)
                .HasMaxLength(10)
                .HasColumnName("WHEELS");
        });

        modelBuilder.Entity<Segs4VetsUnit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segs4Vets_Units");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.CustType)
                .HasMaxLength(6)
                .HasColumnName("cust_type");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
        });

        modelBuilder.Entity<SegwayBattery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery");

            entity.Property(e => e.BatteryManufacturer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BATTERY_MANUFACTURER");
            entity.Property(e => e.BatteryPartNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("BATTERY_PART_NUMBER");
            entity.Property(e => e.BatteryReadId).HasColumnName("BATTERY_READ_ID");
            entity.Property(e => e.BatterySerialNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_NUMBER");
            entity.Property(e => e.BootLoaderPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BOOT_LOADER_PART_NUMBER");
            entity.Property(e => e.BootLoaderRevisionNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BOOT_LOADER_REVISION_NUMBER");
            entity.Property(e => e.CalibrationPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CALIBRATION_PART_NUMBER");
            entity.Property(e => e.CalibrationRevisionNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CALIBRATION_REVISION_NUMBER");
            entity.Property(e => e.CellChemistry)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CELL_CHEMISTRY");
            entity.Property(e => e.CellDifferential).HasColumnName("CELL_DIFFERENTIAL");
            entity.Property(e => e.ChargeProcessStatus)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CHARGE_PROCESS_STATUS");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.EffectivePackSize).HasColumnName("EFFECTIVE_PACK_SIZE");
            entity.Property(e => e.FaultFlags).HasColumnName("FAULT_FLAGS");
            entity.Property(e => e.FirmwarePartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMWARE_PART_NUMBER");
            entity.Property(e => e.FirmwareRevisionNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMWARE_REVISION_NUMBER");
            entity.Property(e => e.HazardFlags).HasColumnName("HAZARD_FLAGS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Invalid).HasColumnName("INVALID");
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.ManufacturedPackSize).HasColumnName("MANUFACTURED_PACK_SIZE");
            entity.Property(e => e.MfgrLineNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MFGR_LINE_NUMBER");
            entity.Property(e => e.MfgrPartNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("MFGR_PART_NUMBER");
            entity.Property(e => e.MfgrSerialNumber)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("MFGR_SERIAL_NUMBER");
            entity.Property(e => e.MfgrTimestamp).HasColumnName("MFGR_TIMESTAMP");
            entity.Property(e => e.NominalCellVoltage).HasColumnName("NOMINAL_CELL_VOLTAGE");
            entity.Property(e => e.OvervoltageIndicator).HasColumnName("OVERVOLTAGE_INDICATOR");
            entity.Property(e => e.PackCurrent).HasColumnName("PACK_CURRENT");
            entity.Property(e => e.PackRevisionNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PACK_REVISION_NUMBER");
            entity.Property(e => e.PackTemperature).HasColumnName("PACK_TEMPERATURE");
            entity.Property(e => e.PackVoltage).HasColumnName("PACK_VOLTAGE");
            entity.Property(e => e.SessionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SESSION_NAME");
            entity.Property(e => e.SoftwarePartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_PART_NUMBER");
            entity.Property(e => e.SoftwareRevisionNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SOFTWARE_REVISION_NUMBER");
            entity.Property(e => e.StateOfCharge).HasColumnName("STATE_OF_CHARGE");
            entity.Property(e => e.StateOfEnergy).HasColumnName("STATE_OF_ENERGY");
            entity.Property(e => e.StateOfPower).HasColumnName("STATE_OF_POWER");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UndervoltageIndicator).HasColumnName("UNDERVOLTAGE_INDICATOR");
            entity.Property(e => e.UnitSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UNIT_SERIAL_NUMBER");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.WorkOrderId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER_ID");
        });

        modelBuilder.Entity<SegwayBatteryTemperature>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery_Temperatures");

            entity.Property(e => e.BatteryReadId).HasColumnName("BATTERY_READ_ID");
            entity.Property(e => e.BatterySerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL");
            entity.Property(e => e.BlockNumber).HasColumnName("BLOCK_NUMBER");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Temperature).HasColumnName("TEMPERATURE");
        });

        modelBuilder.Entity<SegwayBatteryUserDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery_User_Data");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastListLength).HasColumnName("LAST_LIST_LENGTH");
            entity.Property(e => e.LastSelectedId).HasColumnName("LAST_SELECTED_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SegwayBatteryUserViewed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery_User_Viewed");

            entity.Property(e => e.BatteryId).HasColumnName("BATTERY_ID");
            entity.Property(e => e.BatteryNumber).HasColumnName("BATTERY_NUMBER");
            entity.Property(e => e.BatteryReadId).HasColumnName("BATTERY_READ_ID");
            entity.Property(e => e.BatterySerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastViewed).HasColumnName("LAST_VIEWED");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SegwayBatteryUserViewedNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery_User_Viewed_New");

            entity.Property(e => e.BatteryReadId).HasColumnName("BATTERY_READ_ID");
            entity.Property(e => e.BatterySerial)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastViewed)
                .HasColumnType("datetime")
                .HasColumnName("LAST_VIEWED");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SegwayBatteryValanceFault>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery_Valance_Faults");

            entity.Property(e => e.BatteryReadId).HasColumnName("BATTERY_READ_ID");
            entity.Property(e => e.BatterySerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogCode).HasColumnName("LOG_CODE");
            entity.Property(e => e.LogNumber).HasColumnName("LOG_NUMBER");
        });

        modelBuilder.Entity<SegwayBatteryVoltage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Battery_Voltages");

            entity.Property(e => e.BatteryReadId).HasColumnName("BATTERY_READ_ID");
            entity.Property(e => e.BatterySerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL");
            entity.Property(e => e.CellNumber).HasColumnName("CELL_NUMBER");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Voltage).HasColumnName("VOLTAGE");
        });

        modelBuilder.Entity<SegwayDealerAccountXref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Dealer_Account_XRef");

            entity.Property(e => e.AccountId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AlternateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALTERNATE_ID");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<SegwayInfoKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_InfoKey");

            entity.Property(e => e.Allowed)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ALLOWED");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CUST_NUM");
            entity.Property(e => e.Expiration)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRATION");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Serial1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SERIAL1");
            entity.Property(e => e.Serial2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SERIAL2");
            entity.Property(e => e.Serial3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SERIAL3");
            entity.Property(e => e.Serial4)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SERIAL4");
        });

        modelBuilder.Entity<SegwayLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Logins");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ToolName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOOL_NAME");
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SegwayPartNumberInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Part_Number_Information");

            entity.Property(e => e.BarTenderFileName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BAR_TENDER_FILE_NAME");
            entity.Property(e => e.Category)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsDisplay).HasColumnName("IS_DISPLAY");
            entity.Property(e => e.ItemRevision)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ITEM_REVISION");
            entity.Property(e => e.LabelCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LABEL_CODE");
            entity.Property(e => e.Model)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.PartType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_TYPE");
            entity.Property(e => e.SerialCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SERIAL_CODE");
            entity.Property(e => e.SerialType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SERIAL_TYPE");
            entity.Property(e => e.Sitecode).HasColumnName("SITECODE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SytelineItem)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SYTELINE_ITEM");
            entity.Property(e => e.TravelerCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TRAVELER_CODE");
            entity.Property(e => e.TravelerColor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TRAVELER_COLOR");
            entity.Property(e => e.TravelerWatermark)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRAVELER_WATERMARK");
        });

        modelBuilder.Entity<SegwayPartNumberProductionXref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Part_Number_Production_XRef");

            entity.Property(e => e.FredClassification)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("FRED_CLASSIFICATION");
            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.ProductionPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRODUCTION_PART_NUMBER");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SegwayPartTypeXref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Part_Type_Xref");

            entity.Property(e => e.AssemblyModel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASSEMBLY_MODEL");
            entity.Property(e => e.AssemblyPartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASSEMBLY_PART_NUMBER");
            entity.Property(e => e.AssemblyPartType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASSEMBLY_PART_TYPE");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IgnoreValidation).HasColumnName("IGNORE_VALIDATION");
            entity.Property(e => e.IsConfiguration).HasColumnName("IS_CONFIGURATION");
            entity.Property(e => e.ServicePartNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERVICE_PART_NUMBER");
        });

        modelBuilder.Entity<SegwayReplacementAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Replacement_Addresses");

            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CUST_NUM");
            entity.Property(e => e.CustSeq).HasColumnName("CUST_SEQ");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DealerNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("DEALER_NUM");
            entity.Property(e => e.DealerSeq).HasColumnName("DEALER_SEQ");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.UseAddress)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("USE_ADDRESS");
        });

        modelBuilder.Entity<SegwayRetainer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Retainer");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Comment)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CUST_NUM");
            entity.Property(e => e.DateTimeEntered)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Description)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Item)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ITEM");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<SegwayRmaReturnStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_RMA_Return_Status");

            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.PrimaryCode).HasMaxLength(10);
            entity.Property(e => e.PrimaryDesc).HasMaxLength(80);
            entity.Property(e => e.RmaNum)
                .HasMaxLength(10)
                .HasColumnName("RMA_Num");
            entity.Property(e => e.RowPointer).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SecondaryCode).HasMaxLength(10);
            entity.Property(e => e.SecondaryDesc).HasMaxLength(80);
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<SegwaySaRPrimaryReturnStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_SaR_Primary_Return_Status");

            entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Description).HasMaxLength(80);
            entity.Property(e => e.PrimaryCode).HasMaxLength(10);
            entity.Property(e => e.RowPointer).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<SegwaySaRSecondaryReturnStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_SaR_Secondary_Return_Status");

            entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Description).HasMaxLength(80);
            entity.Property(e => e.PrimaryCode).HasMaxLength(10);
            entity.Property(e => e.RowPointer).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SecondaryCode).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<SegwayServiceMonitor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Service_Monitor");

            entity.Property(e => e.DatabaseDown).HasColumnName("DATABASE_DOWN");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Monitorkey).HasColumnName("MONITORKEY");
            entity.Property(e => e.ServerDown).HasColumnName("SERVER_DOWN");
            entity.Property(e => e.ServiceDown).HasColumnName("SERVICE_DOWN");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.WebserviceDown).HasColumnName("WEBSERVICE_DOWN");
        });

        modelBuilder.Entity<SegwayServiceMonitorArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Service_Monitor_ARCHIVE");

            entity.Property(e => e.DatabaseDown).HasColumnName("DATABASE_DOWN");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Monitorkey).HasColumnName("MONITORKEY");
            entity.Property(e => e.ServerDown).HasColumnName("SERVER_DOWN");
            entity.Property(e => e.ServiceDown).HasColumnName("SERVICE_DOWN");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.WebserviceDown).HasColumnName("WEBSERVICE_DOWN");
        });

        modelBuilder.Entity<SegwayServiceMonitorDataArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Service_Monitor_Data_ARCHIVE");

            entity.Property(e => e.Category)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATABASE_NAME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Monitorkey).HasColumnName("MONITORKEY");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<SegwayServiceMonitorDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Service_Monitor_Data");

            entity.Property(e => e.Category)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATABASE_NAME");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Monitorkey).HasColumnName("MONITORKEY");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<SegwayServiceMonitorNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Service_Monitor_Notification");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NotificationKey).HasColumnName("NOTIFICATION_KEY");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SegwayWarehouseLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Segway_Warehouse_Locations");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSE");
        });

        modelBuilder.Entity<SerialNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Serial_Numbers");

            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SerialNumbersBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Serial_Numbers_Backup");

            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SerialNumbersGenerated>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Serial_Numbers_Generated");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service");

            entity.Property(e => e.BatteryChargeTestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_CHARGE_TEST_STATUS");
            entity.Property(e => e.BsaAPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_PART_NUMBER");
            entity.Property(e => e.BsaASerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_SERIAL_NUMBER");
            entity.Property(e => e.BsaASwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_SW_VERSION");
            entity.Property(e => e.BsaBPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_PART_NUMBER");
            entity.Property(e => e.BsaBSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_SERIAL_NUMBER");
            entity.Property(e => e.BsaBSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_SW_VERSION");
            entity.Property(e => e.ConsoleLedTestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSOLE_LED_TEST_STATUS");
            entity.Property(e => e.ConsolePsupplySerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSOLE_PSUPPLY_SERIAL_NUMBER");
            entity.Property(e => e.ConsoleRadioSid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSOLE_RADIO_SID");
            entity.Property(e => e.CuAPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_PART_NUMBER");
            entity.Property(e => e.CuASerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SERIAL_NUMBER");
            entity.Property(e => e.CuASwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SW_VERSION");
            entity.Property(e => e.CuBPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_PART_NUMBER");
            entity.Property(e => e.CuBSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SERIAL_NUMBER");
            entity.Property(e => e.CuBSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SW_VERSION");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeServiced).HasColumnName("DATE_TIME_SERVICED");
            entity.Property(e => e.Gearbox1SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GEARBOX1_SERIAL_NUMBER");
            entity.Property(e => e.Gearbox2SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GEARBOX2_SERIAL_NUMBER");
            entity.Property(e => e.InertialTestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INERTIAL_TEST_STATUS");
            entity.Property(e => e.MagneticOnOffTestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAGNETIC_ON_OFF_TEST_STATUS");
            entity.Property(e => e.Motor1SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOTOR1_SERIAL_NUMBER");
            entity.Property(e => e.Motor2SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOTOR2_SERIAL_NUMBER");
            entity.Property(e => e.OverallPassFail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OVERALL_PASS_FAIL");
            entity.Property(e => e.PivotBaseSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PIVOT_BASE_SERIAL_NUMBER");
            entity.Property(e => e.PropulsionTestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROPULSION_TEST_STATUS");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.RiderDetectStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_STATUS");
            entity.Property(e => e.UiPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_PART_NUMBER");
            entity.Property(e => e.UiSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SERIAL_NUMBER");
            entity.Property(e => e.UiSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SW_VERSION");
            entity.Property(e => e.UicCurrentDrainTestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UIC_CURRENT_DRAIN_TEST_STATUS");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<ServiceIbutton>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SERVICE_IBUTTON", "SERVMGR");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("CODE");
            entity.Property(e => e.Confirmation)
                .HasMaxLength(20)
                .HasColumnName("CONFIRMATION");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.Representative)
                .HasMaxLength(50)
                .HasColumnName("REPRESENTATIVE");
            entity.Property(e => e.Requestor)
                .HasMaxLength(50)
                .HasColumnName("REQUESTOR");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(20)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<ServiceLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SERVICE_LOOKUPS", "SERVMGR");

            entity.Property(e => e.Attribute1)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE1");
            entity.Property(e => e.Attribute2)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE2");
            entity.Property(e => e.Attribute3)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE3");
            entity.Property(e => e.Attribute4)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE4");
            entity.Property(e => e.Attribute5)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE5");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.LookupDescription)
                .HasMaxLength(100)
                .HasColumnName("LOOKUP_DESCRIPTION");
            entity.Property(e => e.LookupType)
                .HasMaxLength(20)
                .HasColumnName("LOOKUP_TYPE");
            entity.Property(e => e.LookupValue)
                .HasMaxLength(100)
                .HasColumnName("LOOKUP_VALUE");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<ServiceTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service_Table");

            entity.Property(e => e.ALogs)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("A_LOGS");
            entity.Property(e => e.ASideTime)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("A_SIDE_TIME");
            entity.Property(e => e.AdditionalNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("ADDITIONAL_NOTES");
            entity.Property(e => e.ApprovedDeclined1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_1");
            entity.Property(e => e.ApprovedDeclined10)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_10");
            entity.Property(e => e.ApprovedDeclined11)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_11");
            entity.Property(e => e.ApprovedDeclined12)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_12");
            entity.Property(e => e.ApprovedDeclined13)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_13");
            entity.Property(e => e.ApprovedDeclined14)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_14");
            entity.Property(e => e.ApprovedDeclined15)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_15");
            entity.Property(e => e.ApprovedDeclined2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_2");
            entity.Property(e => e.ApprovedDeclined3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_3");
            entity.Property(e => e.ApprovedDeclined4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_4");
            entity.Property(e => e.ApprovedDeclined5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_5");
            entity.Property(e => e.ApprovedDeclined6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_6");
            entity.Property(e => e.ApprovedDeclined7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_7");
            entity.Property(e => e.ApprovedDeclined8)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_8");
            entity.Property(e => e.ApprovedDeclined9)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED_DECLINED_9");
            entity.Property(e => e.BLogs)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("B_LOGS");
            entity.Property(e => e.BSideTime)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("B_SIDE_TIME");
            entity.Property(e => e.Batt1Block0)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_0");
            entity.Property(e => e.Batt1Block1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_1");
            entity.Property(e => e.Batt1Block10)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_10");
            entity.Property(e => e.Batt1Block11)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_11");
            entity.Property(e => e.Batt1Block12)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_12");
            entity.Property(e => e.Batt1Block13)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_13");
            entity.Property(e => e.Batt1Block14)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_14");
            entity.Property(e => e.Batt1Block15)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_15");
            entity.Property(e => e.Batt1Block16)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_16");
            entity.Property(e => e.Batt1Block17)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_17");
            entity.Property(e => e.Batt1Block18)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_18");
            entity.Property(e => e.Batt1Block19)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_19");
            entity.Property(e => e.Batt1Block2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_2");
            entity.Property(e => e.Batt1Block20)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_20");
            entity.Property(e => e.Batt1Block21)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_21");
            entity.Property(e => e.Batt1Block22)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_22");
            entity.Property(e => e.Batt1Block3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_3");
            entity.Property(e => e.Batt1Block4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_4");
            entity.Property(e => e.Batt1Block5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_5");
            entity.Property(e => e.Batt1Block6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_6");
            entity.Property(e => e.Batt1Block7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_7");
            entity.Property(e => e.Batt1Block8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_8");
            entity.Property(e => e.Batt1Block9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_1_BLOCK_9");
            entity.Property(e => e.Batt2Block0)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_0");
            entity.Property(e => e.Batt2Block1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_1");
            entity.Property(e => e.Batt2Block10)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_10");
            entity.Property(e => e.Batt2Block11)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_11");
            entity.Property(e => e.Batt2Block12)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_12");
            entity.Property(e => e.Batt2Block13)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_13");
            entity.Property(e => e.Batt2Block14)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_14");
            entity.Property(e => e.Batt2Block15)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_15");
            entity.Property(e => e.Batt2Block16)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_16");
            entity.Property(e => e.Batt2Block17)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_17");
            entity.Property(e => e.Batt2Block18)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_18");
            entity.Property(e => e.Batt2Block19)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_19");
            entity.Property(e => e.Batt2Block2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_2");
            entity.Property(e => e.Batt2Block20)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_20");
            entity.Property(e => e.Batt2Block21)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_21");
            entity.Property(e => e.Batt2Block22)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_22");
            entity.Property(e => e.Batt2Block3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_3");
            entity.Property(e => e.Batt2Block4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_4");
            entity.Property(e => e.Batt2Block5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_5");
            entity.Property(e => e.Batt2Block6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_6");
            entity.Property(e => e.Batt2Block7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_7");
            entity.Property(e => e.Batt2Block8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_8");
            entity.Property(e => e.Batt2Block9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("BATT_2_BLOCK_9");
            entity.Property(e => e.BattComments1)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("BATT_COMMENTS_1");
            entity.Property(e => e.BattComments2)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("BATT_COMMENTS_2");
            entity.Property(e => e.BattPassFail1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BATT_PASS_FAIL_1");
            entity.Property(e => e.BattPassFail2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BATT_PASS_FAIL_2");
            entity.Property(e => e.BattSerial1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_SERIAL_1");
            entity.Property(e => e.BattSerial2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BATT_SERIAL_2");
            entity.Property(e => e.BsaFix)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BSA_FIX");
            entity.Property(e => e.ClearFormatLogs)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CLEAR_FORMAT_LOGS");
            entity.Property(e => e.CsbDiag)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CSB_DIAG");
            entity.Property(e => e.CsbDiag1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CSB_DIAG1");
            entity.Property(e => e.Customer)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.DateCompleted1)
                .HasColumnType("datetime")
                .HasColumnName("DATE_COMPLETED_1");
            entity.Property(e => e.DateCompleted2)
                .HasColumnType("datetime")
                .HasColumnName("DATE_COMPLETED_2");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.FailureReason1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILURE_REASON_1");
            entity.Property(e => e.FailureReason2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILURE_REASON_2");
            entity.Property(e => e.HipotDiag)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("HIPOT_DIAG");
            entity.Property(e => e.HipotDiag1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("HIPOT_DIAG1");
            entity.Property(e => e.Hours)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("HOURS");
            entity.Property(e => e.HyperElcon)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("HYPER_ELCON");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InstalledYn1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_1");
            entity.Property(e => e.InstalledYn10)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_10");
            entity.Property(e => e.InstalledYn11)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_11");
            entity.Property(e => e.InstalledYn12)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_12");
            entity.Property(e => e.InstalledYn13)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_13");
            entity.Property(e => e.InstalledYn14)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_14");
            entity.Property(e => e.InstalledYn15)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_15");
            entity.Property(e => e.InstalledYn2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_2");
            entity.Property(e => e.InstalledYn3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_3");
            entity.Property(e => e.InstalledYn4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_4");
            entity.Property(e => e.InstalledYn5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_5");
            entity.Property(e => e.InstalledYn6)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_6");
            entity.Property(e => e.InstalledYn7)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_7");
            entity.Property(e => e.InstalledYn8)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_8");
            entity.Property(e => e.InstalledYn9)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("INSTALLED_YN_9");
            entity.Property(e => e.KitPn1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_1");
            entity.Property(e => e.KitPn10)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_10");
            entity.Property(e => e.KitPn11)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_11");
            entity.Property(e => e.KitPn12)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_12");
            entity.Property(e => e.KitPn13)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_13");
            entity.Property(e => e.KitPn14)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_14");
            entity.Property(e => e.KitPn15)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_15");
            entity.Property(e => e.KitPn2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_2");
            entity.Property(e => e.KitPn3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_3");
            entity.Property(e => e.KitPn4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_4");
            entity.Property(e => e.KitPn5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_5");
            entity.Property(e => e.KitPn6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_6");
            entity.Property(e => e.KitPn7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_7");
            entity.Property(e => e.KitPn8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_8");
            entity.Property(e => e.KitPn9)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("KIT_PN_9");
            entity.Property(e => e.LaborHours)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("LABOR_HOURS");
            entity.Property(e => e.LaborHoursPb)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("LABOR_HOURS_PB");
            entity.Property(e => e.MachinePn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MACHINE_PN");
            entity.Property(e => e.MachineSn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MACHINE_SN");
            entity.Property(e => e.Minutes)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MINUTES");
            entity.Property(e => e.MotorDiag)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MOTOR_DIAG");
            entity.Property(e => e.MotorDiag1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("MOTOR_DIAG1");
            entity.Property(e => e.MotorDiagTest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("MOTOR_DIAG_TEST");
            entity.Property(e => e.NewPbPn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_PB_PN");
            entity.Property(e => e.NewPbSn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_PB_SN");
            entity.Property(e => e.NewSn1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_1");
            entity.Property(e => e.NewSn10)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_10");
            entity.Property(e => e.NewSn11)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_11");
            entity.Property(e => e.NewSn12)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_12");
            entity.Property(e => e.NewSn13)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_13");
            entity.Property(e => e.NewSn14)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_14");
            entity.Property(e => e.NewSn15)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_15");
            entity.Property(e => e.NewSn2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_2");
            entity.Property(e => e.NewSn3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_3");
            entity.Property(e => e.NewSn4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_4");
            entity.Property(e => e.NewSn5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_5");
            entity.Property(e => e.NewSn6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_6");
            entity.Property(e => e.NewSn7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_7");
            entity.Property(e => e.NewSn8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_8");
            entity.Property(e => e.NewSn9)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_SN_9");
            entity.Property(e => e.NormRatio)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NORM_RATIO");
            entity.Property(e => e.NormRatio1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NORM_RATIO1");
            entity.Property(e => e.Observations)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("OBSERVATIONS");
            entity.Property(e => e.OdometerReading)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODOMETER_READING");
            entity.Property(e => e.OldSn1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_1");
            entity.Property(e => e.OldSn10)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_10");
            entity.Property(e => e.OldSn11)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_11");
            entity.Property(e => e.OldSn12)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_12");
            entity.Property(e => e.OldSn13)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_13");
            entity.Property(e => e.OldSn14)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_14");
            entity.Property(e => e.OldSn15)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_15");
            entity.Property(e => e.OldSn2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_2");
            entity.Property(e => e.OldSn3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_3");
            entity.Property(e => e.OldSn4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_4");
            entity.Property(e => e.OldSn5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_5");
            entity.Property(e => e.OldSn6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_6");
            entity.Property(e => e.OldSn7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_7");
            entity.Property(e => e.OldSn8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_8");
            entity.Property(e => e.OldSn9)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OLD_SN_9");
            entity.Property(e => e.OpsComments)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("OPS_COMMENTS");
            entity.Property(e => e.OpsRep)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OPS_REP");
            entity.Property(e => e.Owner)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.PartName1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_1");
            entity.Property(e => e.PartName10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_10");
            entity.Property(e => e.PartName11)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_11");
            entity.Property(e => e.PartName12)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_12");
            entity.Property(e => e.PartName13)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_13");
            entity.Property(e => e.PartName14)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_14");
            entity.Property(e => e.PartName15)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_15");
            entity.Property(e => e.PartName2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_2");
            entity.Property(e => e.PartName3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_3");
            entity.Property(e => e.PartName4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_4");
            entity.Property(e => e.PartName5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_5");
            entity.Property(e => e.PartName6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_6");
            entity.Property(e => e.PartName7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_7");
            entity.Property(e => e.PartName8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_8");
            entity.Property(e => e.PartName9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PART_NAME_9");
            entity.Property(e => e.PbServiceRequest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PB_SERVICE_REQUEST");
            entity.Property(e => e.PictureLinks)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PICTURE_LINKS");
            entity.Property(e => e.PowerBaseTest)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("POWER_BASE_TEST");
            entity.Property(e => e.PowerbaseDiag)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("POWERBASE_DIAG");
            entity.Property(e => e.PowerbaseDiag1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("POWERBASE_DIAG1");
            entity.Property(e => e.ProblemDesc)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESC");
            entity.Property(e => e.ProductShipped)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_SHIPPED");
            entity.Property(e => e.ProgrammedBsa)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROGRAMMED_BSA");
            entity.Property(e => e.ProgrammedCu)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROGRAMMED_CU");
            entity.Property(e => e.Qty1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_1");
            entity.Property(e => e.Qty10)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_10");
            entity.Property(e => e.Qty11)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_11");
            entity.Property(e => e.Qty12)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_12");
            entity.Property(e => e.Qty13)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_13");
            entity.Property(e => e.Qty14)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_14");
            entity.Property(e => e.Qty15)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_15");
            entity.Property(e => e.Qty2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_2");
            entity.Property(e => e.Qty3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_3");
            entity.Property(e => e.Qty4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_4");
            entity.Property(e => e.Qty5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_5");
            entity.Property(e => e.Qty6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_6");
            entity.Property(e => e.Qty7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_7");
            entity.Property(e => e.Qty8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_8");
            entity.Property(e => e.Qty9)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("QTY_9");
            entity.Property(e => e.QuoteNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("QUOTE_NOTES");
            entity.Property(e => e.Rbatt1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RBATT_1");
            entity.Property(e => e.Rbatt2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RBATT_2");
            entity.Property(e => e.ReceivedDamaged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("RECEIVED_DAMAGED");
            entity.Property(e => e.ReceivingBatteries)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_BATTERIES");
            entity.Property(e => e.ReceivingChargeport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_CHARGEPORT");
            entity.Property(e => e.ReceivingComfortmats)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_COMFORTMATS");
            entity.Property(e => e.ReceivingConsoletrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_CONSOLETRIM");
            entity.Property(e => e.ReceivingFenders)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_FENDERS");
            entity.Property(e => e.ReceivingG1keys)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_G1KEYS");
            entity.Property(e => e.ReceivingHubcaps)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_HUBCAPS");
            entity.Property(e => e.ReceivingInfokeys)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_INFOKEYS");
            entity.Property(e => e.ReceivingKickstand)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_KICKSTAND");
            entity.Property(e => e.ReceivingMats)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_MATS");
            entity.Property(e => e.ReceivingNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_NOTES");
            entity.Property(e => e.ReceivingWheels)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIVING_WHEELS");
            entity.Property(e => e.RefurbPb)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REFURB_PB");
            entity.Property(e => e.RepairComplete1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPAIR_COMPLETE_1");
            entity.Property(e => e.RepairComplete2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPAIR_COMPLETE_2");
            entity.Property(e => e.RepairPerformed)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("REPAIR_PERFORMED");
            entity.Property(e => e.RepairType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPAIR_TYPE");
            entity.Property(e => e.ReportNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPORT_NUMBER");
            entity.Property(e => e.RequiredSuggested1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_1");
            entity.Property(e => e.RequiredSuggested10)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_10");
            entity.Property(e => e.RequiredSuggested11)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_11");
            entity.Property(e => e.RequiredSuggested12)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_12");
            entity.Property(e => e.RequiredSuggested13)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_13");
            entity.Property(e => e.RequiredSuggested14)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_14");
            entity.Property(e => e.RequiredSuggested15)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_15");
            entity.Property(e => e.RequiredSuggested2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_2");
            entity.Property(e => e.RequiredSuggested3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_3");
            entity.Property(e => e.RequiredSuggested4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_4");
            entity.Property(e => e.RequiredSuggested5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_5");
            entity.Property(e => e.RequiredSuggested6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_6");
            entity.Property(e => e.RequiredSuggested7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_7");
            entity.Property(e => e.RequiredSuggested8)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_8");
            entity.Property(e => e.RequiredSuggested9)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REQUIRED_SUGGESTED_9");
            entity.Property(e => e.RmaNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RMA_NUMBER");
            entity.Property(e => e.SalesOrder)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SALES_ORDER");
            entity.Property(e => e.ServiceActCode1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_1");
            entity.Property(e => e.ServiceActCode10)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_10");
            entity.Property(e => e.ServiceActCode11)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_11");
            entity.Property(e => e.ServiceActCode12)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_12");
            entity.Property(e => e.ServiceActCode13)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_13");
            entity.Property(e => e.ServiceActCode14)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_14");
            entity.Property(e => e.ServiceActCode15)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_15");
            entity.Property(e => e.ServiceActCode2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_2");
            entity.Property(e => e.ServiceActCode3)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_3");
            entity.Property(e => e.ServiceActCode4)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_4");
            entity.Property(e => e.ServiceActCode5)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_5");
            entity.Property(e => e.ServiceActCode6)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_6");
            entity.Property(e => e.ServiceActCode7)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_7");
            entity.Property(e => e.ServiceActCode8)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_8");
            entity.Property(e => e.ServiceActCode9)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_ACT_CODE_9");
            entity.Property(e => e.ServiceRequest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST");
            entity.Property(e => e.ShippedDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPPED_DATE");
            entity.Property(e => e.StartDate1)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_1");
            entity.Property(e => e.StartDate2)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_2");
            entity.Property(e => e.Tech1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TECH_1");
            entity.Property(e => e.Tech2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TECH_2");
            entity.Property(e => e.TirePassFail2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIRE_PASS_FAIL_2");
            entity.Property(e => e.TirePressure)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TIRE_PRESSURE");
            entity.Property(e => e.TirePressure1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIRE_PRESSURE1");
            entity.Property(e => e.TirePressure2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIRE_PRESSURE2");
            entity.Property(e => e.TirePsi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIRE_PSI");
            entity.Property(e => e.TirePsi1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIRE_PSI1");
            entity.Property(e => e.TransComplete)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TRANS_COMPLETE");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("TRANSACTION_DATE");
            entity.Property(e => e.UiDiag)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UI_DIAG");
            entity.Property(e => e.UiDiag1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UI_DIAG1");
            entity.Property(e => e.UiTest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UI_TEST");
            entity.Property(e => e.UnitCleaned)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UNIT_CLEANED");
            entity.Property(e => e.WaitCustApprov)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("WAIT_CUST_APPROV");
            entity.Property(e => e.Warr1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_1");
            entity.Property(e => e.Warr10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_10");
            entity.Property(e => e.Warr11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_11");
            entity.Property(e => e.Warr12)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_12");
            entity.Property(e => e.Warr13)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_13");
            entity.Property(e => e.Warr14)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_14");
            entity.Property(e => e.Warr15)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_15");
            entity.Property(e => e.Warr2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_2");
            entity.Property(e => e.Warr3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_3");
            entity.Property(e => e.Warr4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_4");
            entity.Property(e => e.Warr5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_5");
            entity.Property(e => e.Warr6)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_6");
            entity.Property(e => e.Warr7)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_7");
            entity.Property(e => e.Warr8)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WARR_8");
            entity.Property(e => e.Warr9)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WARR_9");
        });

        modelBuilder.Entity<ServiceTech>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SERVICE_TECH", "TESTMSTR");

            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("END_DATE");
            entity.Property(e => e.ServiceTech1)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_TECH");
            entity.Property(e => e.ServiceTechName)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_TECH_NAME");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<ServiceTool>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service_Tools");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ToolCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TOOL_CATEGORY");
            entity.Property(e => e.ToolName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOOL_NAME");
            entity.Property(e => e.ToolType)
                .HasDefaultValueSql("((3))")
                .HasColumnName("TOOL_TYPE");
        });

        modelBuilder.Entity<ServiceToolsAuthenticationToken>(entity =>
        {
            entity.ToTable("Service_Tools_Authentication_Tokens");

            entity.Property(e => e.Expires).HasColumnType("datetime");
            entity.Property(e => e.ServiceToolId).HasColumnName("Service_Tool_Id");
            entity.Property(e => e.ServiceUserId).HasColumnName("Service_User_Id");
            entity.Property(e => e.Token)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ServiceUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service_Users");

            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CustAccountId).HasColumnName("CUST_ACCOUNT_ID");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RealName)
                .HasMaxLength(255)
                .HasColumnName("Real_Name");
            entity.Property(e => e.SytelineAccountId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SYTELINE_ACCOUNT_ID");
            entity.Property(e => e.SytelineEmployeeId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("SYTELINE_EMPLOYEE_ID");
            entity.Property(e => e.SytelinePartnerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SYTELINE_PARTNER_ID");
            entity.Property(e => e.UserDisplay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_DISPLAY");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USER_EMAIL");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_PASSWORD");
            entity.Property(e => e.UserPasswordHash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("User_Password_Hash");
            entity.Property(e => e.UserPasswordSalt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("User_Password_Salt");
            entity.Property(e => e.UserReplacementPasswordHash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("User_Replacement_Password_Hash");
            entity.Property(e => e.UserReplacementPasswordHashExpires)
                .HasColumnType("datetime")
                .HasColumnName("User_Replacement_Password_Hash_Expires");
            entity.Property(e => e.UserStatus).HasColumnName("USER_STATUS");
        });

        modelBuilder.Entity<ServiceUserAccess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Service_User_Access");

            entity.Property(e => e.AccessLevel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCESS_LEVEL");
            entity.Property(e => e.CurrentVersion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CURRENT_VERSION");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InstallDate).HasColumnName("INSTALL_DATE");
            entity.Property(e => e.LastLogin).HasColumnName("LAST_LOGIN");
            entity.Property(e => e.LoginCount).HasColumnName("LOGIN_COUNT");
            entity.Property(e => e.MandatoryUpdate).HasColumnName("MANDATORY_UPDATE");
            entity.Property(e => e.NewUserId).HasColumnName("NEW_USER_ID");
            entity.Property(e => e.Ordinal).HasColumnName("ORDINAL");
            entity.Property(e => e.ToolName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOOL_NAME");
            entity.Property(e => e.UpdateVersion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UPDATE_VERSION");
            entity.Property(e => e.UserAccessId).HasColumnName("USER_ACCESS_ID");
            entity.Property(e => e.UserDefaultLevel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_DEFAULT_LEVEL");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
        });

        modelBuilder.Entity<ShippingInstructionsComment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shipping_Instructions_Comments");

            entity.Property(e => e.Comment)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
        });

        modelBuilder.Entity<ShippingInstructionsDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shipping_Instructions_Data");

            entity.Property(e => e.Batteries).HasColumnName("BATTERIES");
            entity.Property(e => e.Comments)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.ConsumerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONSUMER_ID");
            entity.Property(e => e.ConsumerShipto).HasColumnName("CONSUMER_SHIPTO");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.DealerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DEALER_ID");
            entity.Property(e => e.DealerShipto).HasColumnName("DEALER_SHIPTO");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.NoBatteries).HasColumnName("NO_BATTERIES");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.Other).HasColumnName("OTHER");
            entity.Property(e => e.Register).HasColumnName("REGISTER");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<ShippingInstructionsSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shipping_Instructions_Serials");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTERED_BY");
            entity.Property(e => e.FrontBattery)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("FRONT_BATTERY");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.Ordinal).HasColumnName("ORDINAL");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL");
            entity.Property(e => e.RearBattery)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REAR_BATTERY");
        });

        modelBuilder.Entity<SmpVddOperationsTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDD_OPERATIONS_TABLE", "TESTMSTR");

            entity.Property(e => e.Callback)
                .HasMaxLength(128)
                .HasColumnName("CALLBACK");
            entity.Property(e => e.Node)
                .HasMaxLength(128)
                .HasColumnName("NODE");
            entity.Property(e => e.Outgoing)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("OUTGOING");
            entity.Property(e => e.Owner)
                .HasMaxLength(128)
                .HasColumnName("OWNER");
            entity.Property(e => e.RequestId)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("REQUEST_ID");
            entity.Property(e => e.RequestSubtype)
                .HasMaxLength(128)
                .HasColumnName("REQUEST_SUBTYPE");
            entity.Property(e => e.RequestType)
                .HasMaxLength(128)
                .HasColumnName("REQUEST_TYPE");
            entity.Property(e => e.SequenceNum)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SEQUENCE_NUM");
            entity.Property(e => e.Target)
                .HasMaxLength(128)
                .HasColumnName("TARGET");
            entity.Property(e => e.Timestamp)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.UserName)
                .HasMaxLength(128)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<SmpVdfMaslist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDF_MASLIST", "TESTMSTR");

            entity.Property(e => e.MasName)
                .HasMaxLength(128)
                .HasColumnName("MAS_NAME");
            entity.Property(e => e.Timestamp)
                .HasColumnType("date")
                .HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<SmpVdmAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_ADDRESS", "TESTMSTR");

            entity.Property(e => e.AppName)
                .HasMaxLength(256)
                .HasColumnName("APP_NAME");
            entity.Property(e => e.EnhancedNotification)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("ENHANCED_NOTIFICATION");
            entity.Property(e => e.Proxy)
                .HasMaxLength(256)
                .HasColumnName("PROXY");
            entity.Property(e => e.SequenceNum)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SEQUENCE_NUM");
            entity.Property(e => e.Slotretrievaltime)
                .HasColumnType("date")
                .HasColumnName("SLOTRETRIEVALTIME");
            entity.Property(e => e.Username)
                .HasMaxLength(256)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<SmpVdmGlobalInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_GLOBAL_INFO", "TESTMSTR");

            entity.Property(e => e.PropertyName)
                .HasMaxLength(128)
                .HasColumnName("PROPERTY_NAME");
            entity.Property(e => e.PropertyValue)
                .HasMaxLength(256)
                .HasColumnName("PROPERTY_VALUE");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(128)
                .HasColumnName("SERVICE_NAME");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(128)
                .HasColumnName("SERVICE_TYPE");
        });

        modelBuilder.Entity<SmpVdmLastNotifSeqPertype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_LAST_NOTIF_SEQ_PERTYPE", "TESTMSTR");

            entity.Property(e => e.LastNotifSequence)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("LAST_NOTIF_SEQUENCE");
            entity.Property(e => e.NotificationType)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("NOTIFICATION_TYPE");
        });

        modelBuilder.Entity<SmpVdmNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_NOTIFICATION", "TESTMSTR");

            entity.Property(e => e.Domain)
                .HasMaxLength(256)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.NodeName)
                .HasMaxLength(256)
                .HasColumnName("NODE_NAME");
            entity.Property(e => e.NotificationId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("NOTIFICATION_ID");
            entity.Property(e => e.NotificationType)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("NOTIFICATION_TYPE");
            entity.Property(e => e.NumClients)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("NUM_CLIENTS");
            entity.Property(e => e.SequenceNum)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SEQUENCE_NUM");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(256)
                .HasColumnName("SERVICE_NAME");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(256)
                .HasColumnName("SERVICE_TYPE");
            entity.Property(e => e.Subtype)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SUBTYPE");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TIME_STAMP");
            entity.Property(e => e.TimeZone)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TIME_ZONE");
            entity.Property(e => e.Verbose)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("VERBOSE");
        });

        modelBuilder.Entity<SmpVdmNotificationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_NOTIFICATION_DETAILS", "TESTMSTR");

            entity.Property(e => e.Execnum)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("EXECNUM");
            entity.Property(e => e.Message)
                .HasMaxLength(2000)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Method)
                .HasMaxLength(256)
                .HasColumnName("METHOD");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("NAME");
            entity.Property(e => e.OperationStatus)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("OPERATION_STATUS");
            entity.Property(e => e.Owner)
                .HasMaxLength(256)
                .HasColumnName("OWNER");
            entity.Property(e => e.Status)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("STATUS");
            entity.Property(e => e.Target)
                .HasMaxLength(256)
                .HasColumnName("TARGET");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("date")
                .HasColumnName("TIME_STAMP");
            entity.Property(e => e.TimeZone)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TIME_ZONE");
            entity.Property(e => e.Type)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SmpVdmNotificationNvpair>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_NOTIFICATION_NVPAIRS", "TESTMSTR");

            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .HasColumnName("NAME");
            entity.Property(e => e.SequenceNum)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SEQUENCE_NUM");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.ValueLength)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("VALUE_LENGTH");
        });

        modelBuilder.Entity<SmpVdmNotificationService>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_NOTIFICATION_SERVICES", "TESTMSTR");

            entity.Property(e => e.Ior)
                .HasMaxLength(2000)
                .HasColumnName("IOR");
            entity.Property(e => e.Nodename)
                .HasMaxLength(255)
                .HasColumnName("NODENAME");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(255)
                .HasColumnName("SERVICE_TYPE");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("date")
                .HasColumnName("TIME_STAMP");
        });

        modelBuilder.Entity<SmpVdmPagingCarrierInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_PAGING_CARRIER_INFO", "TESTMSTR");

            entity.Property(e => e.PagingCarrierConnDelay)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PAGING_CARRIER_CONN_DELAY");
            entity.Property(e => e.PagingCarrierId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("PAGING_CARRIER_ID");
            entity.Property(e => e.PagingCarrierName)
                .HasMaxLength(128)
                .HasColumnName("PAGING_CARRIER_NAME");
            entity.Property(e => e.PagingCarrierProtocol)
                .HasMaxLength(128)
                .HasColumnName("PAGING_CARRIER_PROTOCOL");
            entity.Property(e => e.PagingCarrierTimeout)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PAGING_CARRIER_TIMEOUT");
            entity.Property(e => e.PagingCarrierType)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("PAGING_CARRIER_TYPE");
            entity.Property(e => e.PagingServerName)
                .HasMaxLength(255)
                .HasColumnName("PAGING_SERVER_NAME");
            entity.Property(e => e.PhoneAreaCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PHONE_AREA_CODE");
            entity.Property(e => e.PhoneCountryCode)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PHONE_COUNTRY_CODE");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(128)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.PhoneNumberSuffix)
                .HasMaxLength(128)
                .HasColumnName("PHONE_NUMBER_SUFFIX");
        });

        modelBuilder.Entity<SmpVdmSessionNotiftypePair>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDM_SESSION_NOTIFTYPE_PAIR", "TESTMSTR");

            entity.Property(e => e.LastNotifSequence)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("LAST_NOTIF_SEQUENCE");
            entity.Property(e => e.NotificationType)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("NOTIFICATION_TYPE");
            entity.Property(e => e.SessionId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SESSION_ID");
        });

        modelBuilder.Entity<SmpVdsReposVersion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDS_REPOS_VERSION", "TESTMSTR");

            entity.Property(e => e.AppName)
                .HasMaxLength(512)
                .HasColumnName("APP_NAME");
            entity.Property(e => e.Standalone)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("STANDALONE");
            entity.Property(e => e.UpdInProgress)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("UPD_IN_PROGRESS");
            entity.Property(e => e.Version)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("VERSION");
        });

        modelBuilder.Entity<SmpVdsSessionsTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDS_SESSIONS_TABLE", "TESTMSTR");

            entity.Property(e => e.LoginTime)
                .HasColumnType("date")
                .HasColumnName("LOGIN_TIME");
            entity.Property(e => e.Oms)
                .HasMaxLength(128)
                .HasColumnName("OMS");
            entity.Property(e => e.PrincipalIor)
                .HasMaxLength(2000)
                .HasColumnName("PRINCIPAL_IOR");
            entity.Property(e => e.PrincipalName)
                .HasMaxLength(128)
                .HasColumnName("PRINCIPAL_NAME");
            entity.Property(e => e.PrincipalType)
                .HasMaxLength(128)
                .HasColumnName("PRINCIPAL_TYPE");
            entity.Property(e => e.SessionId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SESSION_ID");
        });

        modelBuilder.Entity<SmpVduCallbackTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDU_CALLBACK_TABLE", "TESTMSTR");

            entity.Property(e => e.MasManager)
                .HasMaxLength(32)
                .HasColumnName("MAS_MANAGER");
        });

        modelBuilder.Entity<SmpVduObjectsTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDU_OBJECTS_TABLE", "TESTMSTR");

            entity.Property(e => e.ObjectId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("OBJECT_ID");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(128)
                .HasColumnName("OBJECT_NAME");
            entity.Property(e => e.Owner)
                .HasMaxLength(128)
                .HasColumnName("OWNER");
            entity.Property(e => e.Type)
                .HasMaxLength(128)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SmpVduPrincipalsTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDU_PRINCIPALS_TABLE", "TESTMSTR");

            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PrincipalId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("PRINCIPAL_ID");
            entity.Property(e => e.PrincipalName)
                .HasMaxLength(128)
                .HasColumnName("PRINCIPAL_NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(128)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<SmpVduPrivilegeTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDU_PRIVILEGE_TABLE", "TESTMSTR");

            entity.Property(e => e.ObjectOid)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("OBJECT_OID");
            entity.Property(e => e.PrincipalOid)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("PRINCIPAL_OID");
            entity.Property(e => e.PrivilegeString)
                .HasMaxLength(128)
                .HasColumnName("PRIVILEGE_STRING");
        });

        modelBuilder.Entity<SmpVdvUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SMP_VDV_USER", "TESTMSTR");

            entity.Property(e => e.DisplayName)
                .HasMaxLength(256)
                .HasColumnName("DISPLAY_NAME");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(256)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<Stage1BsaSecurity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_BSA_Security");

            entity.Property(e => e.BsaJtagLock)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_JTAG_LOCK");
            entity.Property(e => e.BsaSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.ServiceKeyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_KEY_CODE");
            entity.Property(e => e.UserKeyCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_KEY_CODE");
        });

        modelBuilder.Entity<Stage1CuSecurity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_CU_Security");

            entity.Property(e => e.CuJtagLock)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_JTAG_LOCK");
            entity.Property(e => e.CuSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<Stage1FunctionalDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_Functional_Data");

            entity.Property(e => e.ArsData1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_DATA1");
            entity.Property(e => e.ArsData2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_DATA2");
            entity.Property(e => e.ArsData3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_DATA3");
            entity.Property(e => e.ArsData4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_DATA4");
            entity.Property(e => e.ArsData5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_DATA5");
            entity.Property(e => e.ClMotorLHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorLHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorLHighVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_VOLT_A");
            entity.Property(e => e.ClMotorLHighVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_HIGH_VOLT_B");
            entity.Property(e => e.ClMotorLLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_SPEED_A");
            entity.Property(e => e.ClMotorLLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_SPEED_B");
            entity.Property(e => e.ClMotorLLowVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_VOLT_A");
            entity.Property(e => e.ClMotorLLowVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_LOW_VOLT_B");
            entity.Property(e => e.ClMotorLNegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorLNegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorLNegHighVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_VOLT_A");
            entity.Property(e => e.ClMotorLNegHighVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_HIGH_VOLT_B");
            entity.Property(e => e.ClMotorLNegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_SPEED_A");
            entity.Property(e => e.ClMotorLNegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_SPEED_B");
            entity.Property(e => e.ClMotorLNegLowVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_VOLT_A");
            entity.Property(e => e.ClMotorLNegLowVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_NEG_LOW_VOLT_B");
            entity.Property(e => e.ClMotorLOffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_SPEED_A");
            entity.Property(e => e.ClMotorLOffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_SPEED_B");
            entity.Property(e => e.ClMotorLOffVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_VOLT_A");
            entity.Property(e => e.ClMotorLOffVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_L_OFF_VOLT_B");
            entity.Property(e => e.ClMotorRHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorRHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorRHighVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_VOLT_A");
            entity.Property(e => e.ClMotorRHighVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_HIGH_VOLT_B");
            entity.Property(e => e.ClMotorRLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_SPEED_A");
            entity.Property(e => e.ClMotorRLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_SPEED_B");
            entity.Property(e => e.ClMotorRLowVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_VOLT_A");
            entity.Property(e => e.ClMotorRLowVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_LOW_VOLT_B");
            entity.Property(e => e.ClMotorRNegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_SPEED_A");
            entity.Property(e => e.ClMotorRNegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_SPEED_B");
            entity.Property(e => e.ClMotorRNegHighVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_VOLT_A");
            entity.Property(e => e.ClMotorRNegHighVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_HIGH_VOLT_B");
            entity.Property(e => e.ClMotorRNegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_SPEED_A");
            entity.Property(e => e.ClMotorRNegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_SPEED_B");
            entity.Property(e => e.ClMotorRNegLowVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_VOLT_A");
            entity.Property(e => e.ClMotorRNegLowVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_NEG_LOW_VOLT_B");
            entity.Property(e => e.ClMotorROffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_SPEED_A");
            entity.Property(e => e.ClMotorROffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_SPEED_B");
            entity.Property(e => e.ClMotorROffVoltA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_VOLT_A");
            entity.Property(e => e.ClMotorROffVoltB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_MOTOR_R_OFF_VOLT_B");
            entity.Property(e => e.CuAEmbeddedFaultStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_EMBEDDED_FAULT_STATUS");
            entity.Property(e => e.CuB72vMeas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_72V_MEAS");
            entity.Property(e => e.CuBEmbeddedFaultStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_EMBEDDED_FAULT_STATUS");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeTested).HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.OlAmp1HighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp1HighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp1HighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp1HighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp1LowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp1LowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp1LowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp1LowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp1LowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_SPEED_A");
            entity.Property(e => e.OlAmp1LowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_LOW_SPEED_B");
            entity.Property(e => e.OlAmp1NegHighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp1NegHighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp1NegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp1NegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp1NegLowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp1NegLowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp1NegLowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp1NegLowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp1NegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_SPEED_A");
            entity.Property(e => e.OlAmp1NegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_NEG_LOW_SPEED_B");
            entity.Property(e => e.OlAmp1OffCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_CURRENT_A");
            entity.Property(e => e.OlAmp1OffCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_CURRENT_B");
            entity.Property(e => e.OlAmp1OffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_SPEED_A");
            entity.Property(e => e.OlAmp1OffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_1_OFF_SPEED_B");
            entity.Property(e => e.OlAmp2HighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp2HighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp2HighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp2HighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp2LowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp2LowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp2LowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp2LowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp2LowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_SPEED_A");
            entity.Property(e => e.OlAmp2LowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_LOW_SPEED_B");
            entity.Property(e => e.OlAmp2NegHighCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_CURRENT_A");
            entity.Property(e => e.OlAmp2NegHighCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_CURRENT_B");
            entity.Property(e => e.OlAmp2NegHighSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_SPEED_A");
            entity.Property(e => e.OlAmp2NegHighSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_HIGH_SPEED_B");
            entity.Property(e => e.OlAmp2NegLowCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_CURRENT_A");
            entity.Property(e => e.OlAmp2NegLowCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_CURRENT_B");
            entity.Property(e => e.OlAmp2NegLowNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_NORM_RATIO_A");
            entity.Property(e => e.OlAmp2NegLowNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_NORM_RATIO_B");
            entity.Property(e => e.OlAmp2NegLowSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_SPEED_A");
            entity.Property(e => e.OlAmp2NegLowSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_NEG_LOW_SPEED_B");
            entity.Property(e => e.OlAmp2OffCurrentA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_CURRENT_A");
            entity.Property(e => e.OlAmp2OffCurrentB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_CURRENT_B");
            entity.Property(e => e.OlAmp2OffSpeedA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_SPEED_A");
            entity.Property(e => e.OlAmp2OffSpeedB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_AMP_2_OFF_SPEED_B");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.TestId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TEST_ID");
            entity.Property(e => e.TiltPosATiltX)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_A_TILT_X");
            entity.Property(e => e.TiltPosATiltY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_A_TILT_Y");
            entity.Property(e => e.TiltPosBTiltX)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_B_TILT_X");
            entity.Property(e => e.TiltPosBTiltY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POS_B_TILT_Y");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1FunctionalInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_Functional_Info");

            entity.Property(e => e.BsaAPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_PART_NUMBER");
            entity.Property(e => e.BsaASerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_SERIAL_NUMBER");
            entity.Property(e => e.BsaASwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_SW_VERSION");
            entity.Property(e => e.BsaBPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_PART_NUMBER");
            entity.Property(e => e.BsaBSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_SERIAL_NUMBER");
            entity.Property(e => e.BsaBSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_SW_VERSION");
            entity.Property(e => e.CimioDllSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIMIO_DLL_SW_VERSION");
            entity.Property(e => e.CuAPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_PART_NUMBER");
            entity.Property(e => e.CuASerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SERIAL_NUMBER");
            entity.Property(e => e.CuASwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_SW_VERSION");
            entity.Property(e => e.CuBPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_PART_NUMBER");
            entity.Property(e => e.CuBSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SERIAL_NUMBER");
            entity.Property(e => e.CuBSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_SW_VERSION");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeTested).HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.FirstTest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRST_TEST");
            entity.Property(e => e.G2iDbDllSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("G2I_DB_DLL_SW_VERSION");
            entity.Property(e => e.G2iDllSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("G2I_DLL_SW_VERSION");
            entity.Property(e => e.G2stSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("G2ST_SW_VERSION");
            entity.Property(e => e.MutSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUT_SW_VERSION");
            entity.Property(e => e.OperatorLoginName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERATOR_LOGIN_NAME");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.TestConfigurationFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_CONFIGURATION_FILE_NAME");
            entity.Property(e => e.TestId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("TEST_ID");
            entity.Property(e => e.TotalTestDurationSeconds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOTAL_TEST_DURATION_SECONDS");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1FunctionalTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_Functional_Test");

            entity.Property(e => e.Amp1NegNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP1_NEG_NORM_RATIO_A");
            entity.Property(e => e.Amp1NegNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP1_NEG_NORM_RATIO_B");
            entity.Property(e => e.Amp1NormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP1_NORM_RATIO_A");
            entity.Property(e => e.Amp1NormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP1_NORM_RATIO_B");
            entity.Property(e => e.Amp2NegNormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP2_NEG_NORM_RATIO_A");
            entity.Property(e => e.Amp2NegNormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP2_NEG_NORM_RATIO_B");
            entity.Property(e => e.Amp2NormRatioA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP2_NORM_RATIO_A");
            entity.Property(e => e.Amp2NormRatioB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AMP2_NORM_RATIO_B");
            entity.Property(e => e.ArsStableResult)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARS_STABLE_RESULT");
            entity.Property(e => e.BsaConfigurationValidation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_CONFIGURATION_VALIDATION");
            entity.Property(e => e.BsaJtagLockFlashed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_JTAG_LOCK_FLASHED");
            entity.Property(e => e.BsaProductCodeFlashed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_PRODUCT_CODE_FLASHED");
            entity.Property(e => e.BsaUserKeyFlashed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_USER_KEY_FLASHED");
            entity.Property(e => e.ClTestMotorLHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_HIGH");
            entity.Property(e => e.ClTestMotorLLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_LOW");
            entity.Property(e => e.ClTestMotorLNegHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_NEG_HIGH");
            entity.Property(e => e.ClTestMotorLNegLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_NEG_LOW");
            entity.Property(e => e.ClTestMotorLOff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_L_OFF");
            entity.Property(e => e.ClTestMotorRHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_HIGH");
            entity.Property(e => e.ClTestMotorRLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_LOW");
            entity.Property(e => e.ClTestMotorRNegHigh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_NEG_HIGH");
            entity.Property(e => e.ClTestMotorRNegLow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_NEG_LOW");
            entity.Property(e => e.ClTestMotorROff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_TEST_MOTOR_R_OFF");
            entity.Property(e => e.CuACanCommunication)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_CAN_COMMUNICATION");
            entity.Property(e => e.CuAConfigurationValidation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_CONFIGURATION_VALIDATION");
            entity.Property(e => e.CuAProductCodeFlashed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_PRODUCT_CODE_FLASHED");
            entity.Property(e => e.CuB72v)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_72V");
            entity.Property(e => e.CuBCanCommunication)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_CAN_COMMUNICATION");
            entity.Property(e => e.CuBConfigurationValidation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_CONFIGURATION_VALIDATION");
            entity.Property(e => e.CuBProductCodeFlashed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_PRODUCT_CODE_FLASHED");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeTested).HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.EmbeddedSoftwareFaultStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMBEDDED_SOFTWARE_FAULT_STATUS");
            entity.Property(e => e.OlTestAmp1HighA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_HIGH_A");
            entity.Property(e => e.OlTestAmp1HighB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_HIGH_B");
            entity.Property(e => e.OlTestAmp1LowA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_LOW_A");
            entity.Property(e => e.OlTestAmp1LowB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_LOW_B");
            entity.Property(e => e.OlTestAmp1NegHighA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_HIGH_A");
            entity.Property(e => e.OlTestAmp1NegHighB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_HIGH_B");
            entity.Property(e => e.OlTestAmp1NegLowA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_LOW_A");
            entity.Property(e => e.OlTestAmp1NegLowB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_NEG_LOW_B");
            entity.Property(e => e.OlTestAmp1OffA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_OFF_A");
            entity.Property(e => e.OlTestAmp1OffB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_1_OFF_B");
            entity.Property(e => e.OlTestAmp2HighA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_HIGH_A");
            entity.Property(e => e.OlTestAmp2HighB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_HIGH_B");
            entity.Property(e => e.OlTestAmp2LowA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_LOW_A");
            entity.Property(e => e.OlTestAmp2LowB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_LOW_B");
            entity.Property(e => e.OlTestAmp2NegHighA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_HIGH_A");
            entity.Property(e => e.OlTestAmp2NegHighB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_HIGH_B");
            entity.Property(e => e.OlTestAmp2NegLowA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_LOW_A");
            entity.Property(e => e.OlTestAmp2NegLowB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_NEG_LOW_B");
            entity.Property(e => e.OlTestAmp2OffA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_OFF_A");
            entity.Property(e => e.OlTestAmp2OffB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OL_TEST_AMP_2_OFF_B");
            entity.Property(e => e.OverallPassFail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OVERALL_PASS_FAIL");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.TestId)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TEST_ID");
            entity.Property(e => e.TiltPosition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TILT_POSITION");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1Gearbox1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE1_GEARBOX1", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Gearbox1SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("GEARBOX1_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1Gearbox2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE1_GEARBOX2", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Gearbox2SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("GEARBOX2_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1Motor1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE1_MOTOR1", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Motor1SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("MOTOR1_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1Motor2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE1_MOTOR2", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Motor2SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("MOTOR2_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1PartNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_Part_Number");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdPartnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PARTNUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage1Partnum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage1_Partnum");

            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdPartnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PARTNUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage2Console>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE2_CONSOLE", "GENII");

            entity.Property(e => e.ConsolePsupplySerialNumber)
                .HasMaxLength(50)
                .HasColumnName("CONSOLE_PSUPPLY_SERIAL_NUMBER");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage2Cover>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE2_COVER", "GENII");

            entity.Property(e => e.CoverLotCode)
                .HasMaxLength(50)
                .HasColumnName("COVER_LOT_CODE");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage2FunctionalDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage2_Functional_Data");

            entity.Property(e => e.BatChrgBotLedGreenFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_BOT_LED_GREEN_FDBK");
            entity.Property(e => e.BatChrgBotLedRedFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_BOT_LED_RED_FDBK");
            entity.Property(e => e.BatChrgCurrentSideA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_CURRENT_SIDE_A");
            entity.Property(e => e.BatChrgCurrentSideB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_CURRENT_SIDE_B");
            entity.Property(e => e.BatChrgTopLedGreenFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_TOP_LED_GREEN_FDBK");
            entity.Property(e => e.BatChrgTopLedRedFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_TOP_LED_RED_FDBK");
            entity.Property(e => e.BatChrgVoltageSideA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_VOLTAGE_SIDE_A");
            entity.Property(e => e.BatChrgVoltageSideB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BAT_CHRG_VOLTAGE_SIDE_B");
            entity.Property(e => e.BotLedGreenOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOT_LED_GREEN_ON_FDBK");
            entity.Property(e => e.BotLedOffFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOT_LED_OFF_FDBK");
            entity.Property(e => e.BotLedRedOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOT_LED_RED_ON_FDBK");
            entity.Property(e => e.CuAEmbeddedFaultStat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_EMBEDDED_FAULT_STAT");
            entity.Property(e => e.CuBEmbeddedFaultStat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_EMBEDDED_FAULT_STAT");
            entity.Property(e => e.CurrentDrainSideA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CURRENT_DRAIN_SIDE_A");
            entity.Property(e => e.CurrentDrainSideB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CURRENT_DRAIN_SIDE_B");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeTested)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.LLedGreenOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("L_LED_GREEN_ON_FDBK");
            entity.Property(e => e.LLedOffFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("L_LED_OFF_FDBK");
            entity.Property(e => e.LLedRedOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("L_LED_RED_ON_FDBK");
            entity.Property(e => e.MidLedGreenOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MID_LED_GREEN_ON_FDBK");
            entity.Property(e => e.MidLedOffFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MID_LED_OFF_FDBK");
            entity.Property(e => e.MidLedRedOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MID_LED_RED_ON_FDBK");
            entity.Property(e => e.NumRiderDetectSwitches)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_RIDER_DETECT_SWITCHES");
            entity.Property(e => e.RLedGreenOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("R_LED_GREEN_ON_FDBK");
            entity.Property(e => e.RLedOffFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("R_LED_OFF_FDBK");
            entity.Property(e => e.RLedRedOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("R_LED_RED_ON_FDBK");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.SpeakerOffFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPEAKER_OFF_FDBK");
            entity.Property(e => e.SpeakerOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPEAKER_ON_FDBK");
            entity.Property(e => e.TestId).HasColumnName("TEST_ID");
            entity.Property(e => e.TopLedGreenOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOP_LED_GREEN_ON_FDBK");
            entity.Property(e => e.TopLedOffFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOP_LED_OFF_FDBK");
            entity.Property(e => e.TopLedRedOnFdbk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOP_LED_RED_ON_FDBK");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage2FunctionalInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage2_Functional_Info");

            entity.Property(e => e.CimioDllSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIMIO_DLL_SW_VERSION");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeTested)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.FirstTest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRST_TEST");
            entity.Property(e => e.G2iDbDllSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("G2I_DB_DLL_SW_VERSION");
            entity.Property(e => e.G2iDllSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("G2I_DLL_SW_VERSION");
            entity.Property(e => e.G2stSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("G2ST_SW_VERSION");
            entity.Property(e => e.MutSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUT_SW_VERSION");
            entity.Property(e => e.OperatorLoginName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPERATOR_LOGIN_NAME");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.TestConfigurationFileName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_CONFIGURATION_FILE_NAME");
            entity.Property(e => e.TestId).HasColumnName("TEST_ID");
            entity.Property(e => e.TotalTestDurationSeconds)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TOTAL_TEST_DURATION_SECONDS");
            entity.Property(e => e.UiPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_PART_NUMBER");
            entity.Property(e => e.UiSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SERIAL_NUMBER");
            entity.Property(e => e.UiSwVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UI_SW_VERSION");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<Stage2FunctionalTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Stage2_Functional_Test");

            entity.Property(e => e.BatteryCharging)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_CHARGING");
            entity.Property(e => e.BatteryLedOperation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATTERY_LED_OPERATION");
            entity.Property(e => e.BsaABlackBoxFormatted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_A_BLACK_BOX_FORMATTED");
            entity.Property(e => e.BsaBBlackBoxFormatted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BSA_B_BLACK_BOX_FORMATTED");
            entity.Property(e => e.ConsoleConfigValidation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONSOLE_CONFIG_VALIDATION");
            entity.Property(e => e.CuALogFormatted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_A_LOG_FORMATTED");
            entity.Property(e => e.CuBLogFormatted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CU_B_LOG_FORMATTED");
            entity.Property(e => e.CurrentDrainSideA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CURRENT_DRAIN_SIDE_A");
            entity.Property(e => e.CurrentDrainSideB)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CURRENT_DRAIN_SIDE_B");
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeTested)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_TESTED");
            entity.Property(e => e.EmbeddedSoftwareFaultStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMBEDDED_SOFTWARE_FAULT_STATUS");
            entity.Property(e => e.FobRadioConfig)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_RADIO_CONFIG");
            entity.Property(e => e.LedOperation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LED_OPERATION");
            entity.Property(e => e.OverallPassFail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OVERALL_PASS_FAIL");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.RiderDetectOperation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIDER_DETECT_OPERATION");
            entity.Property(e => e.SpeakerOperation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPEAKER_OPERATION");
            entity.Property(e => e.TestId).HasColumnName("TEST_ID");
            entity.Property(e => e.UicRadioConfig)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UIC_RADIO_CONFIG");
            entity.Property(e => e.UnitFobStartupAfterBinding)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_FOB_STARTUP_AFTER_BINDING");
            entity.Property(e => e.UnitIdPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_PART_NUMBER");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
            entity.Property(e => e.UnitIdStoredInConsole)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_STORED_IN_CONSOLE");
            entity.Property(e => e.WirelessCommToConsole)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WIRELESS_COMM_TO_CONSOLE");
        });

        modelBuilder.Entity<Stage2Pivot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STAGE2_PIVOT", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.PivotBaseSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PIVOT_BASE_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<SteeringFunctionalDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("STEERING_FUNCTIONAL_DATA", "GENII");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.MaxCcwTorque)
                .HasMaxLength(50)
                .HasColumnName("MAX_CCW_TORQUE");
            entity.Property(e => e.MaxCwTorque)
                .HasMaxLength(50)
                .HasColumnName("MAX_CW_TORQUE");
            entity.Property(e => e.OverallPassFail)
                .HasMaxLength(50)
                .HasColumnName("OVERALL_PASS_FAIL");
            entity.Property(e => e.PivotBaseSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PIVOT_BASE_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
            entity.Property(e => e.YawACenter)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_CENTER");
            entity.Property(e => e.YawALeftMaxCw)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_LEFT_MAX_CW");
            entity.Property(e => e.YawALeftMidCw)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_LEFT_MID_CW");
            entity.Property(e => e.YawALeftRtcTimeCw)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_LEFT_RTC_TIME_CW");
            entity.Property(e => e.YawARightMaxCcw)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_RIGHT_MAX_CCW");
            entity.Property(e => e.YawARightMidCcw)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_RIGHT_MID_CCW");
            entity.Property(e => e.YawARightRtcTimeCcw)
                .HasMaxLength(50)
                .HasColumnName("YAW_A_RIGHT_RTC_TIME_CCW");
            entity.Property(e => e.YawBCenter)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_CENTER");
            entity.Property(e => e.YawBLeftMaxCw)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_LEFT_MAX_CW");
            entity.Property(e => e.YawBLeftMidCw)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_LEFT_MID_CW");
            entity.Property(e => e.YawBLeftRtcTimeCw)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_LEFT_RTC_TIME_CW");
            entity.Property(e => e.YawBRightMaxCcw)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_RIGHT_MAX_CCW");
            entity.Property(e => e.YawBRightMidCcw)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_RIGHT_MID_CCW");
            entity.Property(e => e.YawBRightRtcTimeCcw)
                .HasMaxLength(50)
                .HasColumnName("YAW_B_RIGHT_RTC_TIME_CCW");
        });

        modelBuilder.Entity<SupportTicketDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Support_Ticket_Data");

            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.CauseOfTheIssue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CAUSE_OF_THE_ISSUE");
            entity.Property(e => e.ClientsRequestType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENTS_REQUEST_TYPE");
            entity.Property(e => e.Complain)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COMPLAIN");
            entity.Property(e => e.ContactChannel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_CHANNEL");
            entity.Property(e => e.ContactInformation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_INFORMATION");
            entity.Property(e => e.DateForService).HasColumnName("DATE_FOR_SERVICE");
            entity.Property(e => e.ErrorPhenomenon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ERROR_PHENOMENON");
            entity.Property(e => e.ExpressCompany)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXPRESS_COMPANY");
            entity.Property(e => e.ExpressFee)
                .HasColumnType("money")
                .HasColumnName("EXPRESS_FEE");
            entity.Property(e => e.ExpressFeeCurrency)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EXPRESS_FEE_CURRENCY");
            entity.Property(e => e.ExpressTrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXPRESS_TRACKING_NUMBER");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.InWarrantyOrNot).HasColumnName("IN_WARRANTY_OR_NOT");
            entity.Property(e => e.KeySparePartsSn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KEY_SPARE_PARTS_SN");
            entity.Property(e => e.NameOfUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME_OF_USER");
            entity.Property(e => e.Note)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.ProductSubCategory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_SUB_CATEGORY");
            entity.Property(e => e.Recorder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RECORDER");
            entity.Property(e => e.ResolutionInDetails)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("RESOLUTION_IN_DETAILS");
            entity.Property(e => e.ResolutionReplacementCategory)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("RESOLUTION_REPLACEMENT_CATEGORY");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.TicketNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TICKET_NUMBER");
            entity.Property(e => e.UnitOrign)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UNIT_ORIGN");
            entity.Property(e => e.UserCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_COUNTRY");
            entity.Property(e => e.WarrantyStartTime).HasColumnName("WARRANTY_START_TIME");
        });

        modelBuilder.Entity<SytelineSroMaterialLineApprovalCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Syteline_SRO_Material_Line_Approval_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("ROW_POINTER");
        });

        modelBuilder.Entity<SytelineSroMaterialLineBillingCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Syteline_SRO_Material_Line_Billing_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("ROW_POINTER");
        });

        modelBuilder.Entity<SytelineSroMaterialLineChangeCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Syteline_SRO_Material_Line_Change_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("ROW_POINTER");
        });

        modelBuilder.Entity<SytelineSroMaterialLineInstalledCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Syteline_SRO_Material_Line_Installed_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("ROW_POINTER");
        });

        modelBuilder.Entity<SytelineSroMaterialLineLocationCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Syteline_SRO_Material_Line_Location_Codes");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Entered");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("datetime")
                .HasColumnName("Date_Time_Updated");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowPointer).HasColumnName("ROW_POINTER");
        });

        modelBuilder.Entity<TableSize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TABLE_SIZES", "GENII");

            entity.Property(e => e.AvgRowLen)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("AVG_ROW_LEN");
            entity.Property(e => e.NumRows)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("NUM_ROWS");
            entity.Property(e => e.Owner)
                .HasMaxLength(30)
                .HasColumnName("OWNER");
            entity.Property(e => e.TableName)
                .HasMaxLength(30)
                .HasColumnName("TABLE_NAME");
            entity.Property(e => e.Tsize)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TSIZE");
        });

        modelBuilder.Entity<TempServiceUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_Service_Users");

            entity.Property(e => e.CustAccountId).HasColumnName("CUST_ACCOUNT_ID");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.DateTimeUpdated).HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SytelineAccountId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SYTELINE_ACCOUNT_ID");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USER_EMAIL");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_PASSWORD");
            entity.Property(e => e.UserStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_STATUS");
        });

        modelBuilder.Entity<Ticketindex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TICKETINDEX", "REWORK");

            entity.Property(e => e.Tindex)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TINDEX");
        });

        modelBuilder.Entity<TicketindexBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TICKETINDEX_BACKUP", "REWORK");

            entity.Property(e => e.Tindex)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("TINDEX");
        });

        modelBuilder.Entity<UiConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UI_CONFIG", "SERVMGR");

            entity.Property(e => e.DateEntered)
                .HasColumnType("date")
                .HasColumnName("DATE_ENTERED");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("MODEL");
            entity.Property(e => e.ProductSerialNumber)
                .HasMaxLength(50)
                .HasColumnName("PRODUCT_SERIAL_NUMBER");
            entity.Property(e => e.UiAPartnumRev)
                .HasMaxLength(50)
                .HasColumnName("UI_A_PARTNUM_REV");
            entity.Property(e => e.UiASerialnumRev)
                .HasMaxLength(50)
                .HasColumnName("UI_A_SERIALNUM_REV");
            entity.Property(e => e.UiASoftwareRev)
                .HasMaxLength(50)
                .HasColumnName("UI_A_SOFTWARE_REV");
            entity.Property(e => e.UiBPartnumRev)
                .HasMaxLength(50)
                .HasColumnName("UI_B_PARTNUM_REV");
            entity.Property(e => e.UiBSerialnumRev)
                .HasMaxLength(50)
                .HasColumnName("UI_B_SERIALNUM_REV");
            entity.Property(e => e.UiBSoftwareRev)
                .HasMaxLength(50)
                .HasColumnName("UI_B_SOFTWARE_REV");
        });

        modelBuilder.Entity<UicConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UIC_Config");

            entity.Property(e => e.DateTimeEntered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.FobSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FOB_SERIAL_NUMBER");
            entity.Property(e => e.PivotSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PIVOT_SERIAL_NUMBER");
            entity.Property(e => e.PtSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PT_SERIAL_NUMBER");
            entity.Property(e => e.RadioBoardSerialNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RADIO_BOARD_SERIAL_NUMBER");
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.UicSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UIC_SERIAL_NUMBER");
            entity.Property(e => e.UicSid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UIC_SID");
        });

        modelBuilder.Entity<UicConfigurationTestResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UIC_Configuration_Test_Results");

            entity.Property(e => e.DatabaseFobsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATABASE_FOBSID");
            entity.Property(e => e.DatabaseUicsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATABASE_UICSID");
            entity.Property(e => e.DateTimeEntered).HasColumnName("DATE_TIME_ENTERED");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Operator)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("OPERATOR");
            entity.Property(e => e.ScannedFobsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCANNED_FOBSID");
            entity.Property(e => e.ScannedUicsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCANNED_UICSID");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UnitIdSerialNumber)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UNIT_ID_SERIAL_NUMBER");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USERS", "SERVMGR");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Valence_Battery_Master>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Valence_Battery_Master");

            entity.Property(e => e.Battery_Serial_Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BATTERY_SERIAL_NUMBER");
            entity.Property(e => e.Create_Date).HasColumnType("datetime");
            entity.Property(e => e.Created_By).HasMaxLength(30);
            entity.Property(e => e.Customer_Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.Date_Time_Created)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.Date_Time_Updated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.Failure_Battery_Location)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("FAILURE_BATTERY_LOCATION");
            entity.Property(e => e.Failure_Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAILURE_NOTES");
            entity.Property(e => e.Failure_Notification_Date)
                .HasColumnType("datetime")
                .HasColumnName("FAILURE_NOTIFICATION_DATE");
            entity.Property(e => e.Failure_Reason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAILURE_REASON");
            entity.Property(e => e.Failure_User)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAILURE_USER");
            entity.Property(e => e.NCM_Date)
                .HasColumnType("datetime")
                .HasColumnName("NCM_DATE");
            entity.Property(e => e.Part_Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PART_NUMBER");
            entity.Property(e => e.Rec_ID)
                .ValueGeneratedOnAdd()
                .HasColumnName("REC_ID");
            entity.Property(e => e.Receipt_Date)
                .HasColumnType("datetime")
                .HasColumnName("RECEIPT_DATE");
            entity.Property(e => e.Receipt_Location)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIPT_LOCATION");
            entity.Property(e => e.Receipt_Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RECEIPT_NOTES");
            entity.Property(e => e.Receipt_User)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECEIPT_USER");
            entity.Property(e => e.Record_Date).HasColumnType("datetime");
            entity.Property(e => e.RMA_Request_Date)
                .HasColumnType("datetime")
                .HasColumnName("RMA_REQUEST_DATE");
            entity.Property(e => e.RMA_Request_User)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RMA_REQUEST_USER");
            entity.Property(e => e.Seg_Lot_ID)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEG_LOT_ID");
            entity.Property(e => e.Seg_Ship_Date)
                .HasColumnType("datetime")
                .HasColumnName("SEG_SHIP_DATE");
            entity.Property(e => e.Seg_Warr_End_Date)
                .HasColumnType("datetime")
                .HasColumnName("SEG_WARR_END_DATE");
            entity.Property(e => e.Seg_Warr_Months).HasColumnName("SEG_WARR_MONTHS");
            entity.Property(e => e.Service_Request_Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST_NUMBER");
            entity.Property(e => e.Under_Warranty_YN)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UNDER_WARRANTY_YN");
            entity.Property(e => e.Updated_By).HasMaxLength(30);
            entity.Property(e => e.Valence_File_Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VALENCE_FILE_NAME");
            entity.Property(e => e.Valence_Manufacture_Date)
                .HasColumnType("datetime")
                .HasColumnName("VALENCE_MANUFACTURE_DATE");
            entity.Property(e => e.Valence_Number)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VALENCE_NUMBER");
            entity.Property(e => e.Valence_RMA_Date)
                .HasColumnType("datetime")
                .HasColumnName("VALENCE_RMA_DATE");
            entity.Property(e => e.Valence_RMA_Number)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VALENCE_RMA_NUMBER");
            entity.Property(e => e.Valence_Ship_Date)
                .HasColumnType("datetime")
                .HasColumnName("VALENCE_SHIP_DATE");
            entity.Property(e => e.Warranty_End_Date)
                .HasColumnType("datetime")
                .HasColumnName("WARRANTY_END_DATE");
        });

        modelBuilder.Entity<ValidationMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Validation_Messages");

            entity.Property(e => e.ApplicationType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APPLICATION_TYPE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MessageId).HasColumnName("MESSAGE_ID");
            entity.Property(e => e.MessageType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_TYPE");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("STATUS_MESSAGE");
        });

        modelBuilder.Entity<VbatteryLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VBATTERY_LOOKUPS", "SERVMGR");

            entity.Property(e => e.Attribute1)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE1");
            entity.Property(e => e.Attribute2)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE2");
            entity.Property(e => e.Attribute3)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE3");
            entity.Property(e => e.Attribute4)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE4");
            entity.Property(e => e.Attribute5)
                .HasMaxLength(100)
                .HasColumnName("ATTRIBUTE5");
            entity.Property(e => e.DateTimeCreated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_CREATED");
            entity.Property(e => e.DateTimeUpdated)
                .HasColumnType("date")
                .HasColumnName("DATE_TIME_UPDATED");
            entity.Property(e => e.LookupDescription)
                .HasMaxLength(100)
                .HasColumnName("LOOKUP_DESCRIPTION");
            entity.Property(e => e.LookupType)
                .HasMaxLength(20)
                .HasColumnName("LOOKUP_TYPE");
            entity.Property(e => e.LookupValue)
                .HasMaxLength(100)
                .HasColumnName("LOOKUP_VALUE");
            entity.Property(e => e.RecId)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("REC_ID");
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Work_Orders", "GENII");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.PtSerial)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PT_Serial");
            entity.Property(e => e.WorkOrder1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Work_Order");
        });

        modelBuilder.Entity<XxxCustAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Xxx_Cust_Addresses");

            entity.Property(e => e.Address1)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS1");
            entity.Property(e => e.Address2)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS2");
            entity.Property(e => e.Address3)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS3");
            entity.Property(e => e.Address4)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasColumnName("ADDRESS4");
            entity.Property(e => e.AddressKey)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_KEY");
            entity.Property(e => e.AddressStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ADDRESS_STATUS");
            entity.Property(e => e.Addressee)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADDRESSEE");
            entity.Property(e => e.CareOf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARE_OF");
            entity.Property(e => e.City)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Contact)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACT");
            entity.Property(e => e.Country)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.County)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("COUNTY");
            entity.Property(e => e.CustomerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(360)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.CustomerNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NUMBER");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Instructions)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("INSTRUCTIONS");
            entity.Property(e => e.LocationId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("LOCATION_ID");
            entity.Property(e => e.PartyId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PARTY_ID");
            entity.Property(e => e.PartyName)
                .HasMaxLength(360)
                .IsUnicode(false)
                .HasColumnName("PARTY_NAME");
            entity.Property(e => e.PartySiteId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PARTY_SITE_ID");
            entity.Property(e => e.PartyType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PARTY_TYPE");
            entity.Property(e => e.PaymentTermBillToTab)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TERM_BILL_TO_TAB");
            entity.Property(e => e.PaymentTermOnUsageTab)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TERM_ON_USAGE_TAB");
            entity.Property(e => e.PersonFirstName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PERSON_FIRST_NAME");
            entity.Property(e => e.PersonLastName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PERSON_LAST_NAME");
            entity.Property(e => e.PersonMiddleName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PERSON_MIDDLE_NAME");
            entity.Property(e => e.PersonTitle)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PERSON_TITLE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.PrimaryFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_FLAG");
            entity.Property(e => e.PrimaryPhoneExtension)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_PHONE_EXTENSION");
            entity.Property(e => e.PrimaryPhoneNumber)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_PHONE_NUMBER");
            entity.Property(e => e.SiteNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SITE_NUMBER");
            entity.Property(e => e.SiteUseCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SITE_USE_CODE");
            entity.Property(e => e.State)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_CODE");
            entity.Property(e => e.TaxReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_REFERENCE");
            entity.Property(e => e.Usage)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("USAGE");
            entity.Property(e => e.UsageStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("USAGE_STATUS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

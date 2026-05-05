using System;
using System.Collections.Generic;
using dotnet9_TestAPI.Entities.Anderson_Road;
using Microsoft.EntityFrameworkCore;

namespace Anderson_Road.Entities;

public partial class Anderson_RoadDbContext : DbContext
{
    public Anderson_RoadDbContext()
    {
    }

    public Anderson_RoadDbContext(DbContextOptions<Anderson_RoadDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessAlarmDefinition> AccessAlarmDefinitions { get; set; }

    public virtual DbSet<AccessAlarmEventNotifiyEmailAddress> AccessAlarmEventNotifiyEmailAddresses { get; set; }

    public virtual DbSet<AccessAntiBackGroup> AccessAntiBackGroups { get; set; }

    public virtual DbSet<AccessAntiBackGroupDetail> AccessAntiBackGroupDetails { get; set; }

    public virtual DbSet<AccessCtrlParament> AccessCtrlParaments { get; set; }

    public virtual DbSet<AccessCtrlTimezone> AccessCtrlTimezones { get; set; }

    public virtual DbSet<AccessDoorGroup> AccessDoorGroups { get; set; }

    public virtual DbSet<AccessDoorGroupDetail> AccessDoorGroupDetails { get; set; }

    public virtual DbSet<AccessEntryRecord> AccessEntryRecords { get; set; }

    public virtual DbSet<AccessEntryTimezone> AccessEntryTimezones { get; set; }

    public virtual DbSet<AccessEventMailAddress> AccessEventMailAddresses { get; set; }

    public virtual DbSet<AccessEventNotifiyInfo> AccessEventNotifiyInfos { get; set; }

    public virtual DbSet<AccessEventRecord> AccessEventRecords { get; set; }

    public virtual DbSet<AccessEventTypeDiction> AccessEventTypeDictions { get; set; }

    public virtual DbSet<AccessFaceDevice> AccessFaceDevices { get; set; }

    public virtual DbSet<AccessFingerprintCard> AccessFingerprintCards { get; set; }

    public virtual DbSet<AccessFingerprintDevice> AccessFingerprintDevices { get; set; }

    public virtual DbSet<AccessFireAlarmGroup> AccessFireAlarmGroups { get; set; }

    public virtual DbSet<AccessFireAlarmGroupDetail> AccessFireAlarmGroupDetails { get; set; }

    public virtual DbSet<AccessHidreaderParameter> AccessHidreaderParameters { get; set; }

    public virtual DbSet<AccessHoliday> AccessHolidays { get; set; }

    public virtual DbSet<AccessIndCtrlHoliday> AccessIndCtrlHolidays { get; set; }

    public virtual DbSet<AccessIndCtrlParament> AccessIndCtrlParaments { get; set; }

    public virtual DbSet<AccessIndCtrlTimezone> AccessIndCtrlTimezones { get; set; }

    public virtual DbSet<AccessIndEntryTimezone> AccessIndEntryTimezones { get; set; }

    public virtual DbSet<AccessIndReaderDisplayTimezone> AccessIndReaderDisplayTimezones { get; set; }

    public virtual DbSet<AccessIndReaderParameter> AccessIndReaderParameters { get; set; }

    public virtual DbSet<AccessIostatusDiction> AccessIostatusDictions { get; set; }

    public virtual DbSet<AccessMulitCardhold> AccessMulitCardholds { get; set; }

    public virtual DbSet<AccessMultiDoorGroup> AccessMultiDoorGroups { get; set; }

    public virtual DbSet<AccessPalmSecureDatum> AccessPalmSecureData { get; set; }

    public virtual DbSet<AccessPalmSecureDevice> AccessPalmSecureDevices { get; set; }

    public virtual DbSet<AccessPanelMonitorParam> AccessPanelMonitorParams { get; set; }

    public virtual DbSet<AccessQrcode> AccessQrcodes { get; set; }

    public virtual DbSet<AccessReaderDisplayTimezone> AccessReaderDisplayTimezones { get; set; }

    public virtual DbSet<AccessReaderIddiction> AccessReaderIddictions { get; set; }

    public virtual DbSet<AccessReaderParameter> AccessReaderParameters { get; set; }

    public virtual DbSet<AccessRecTypeDiction> AccessRecTypeDictions { get; set; }

    public virtual DbSet<AccessRight> AccessRights { get; set; }

    public virtual DbSet<AccessSpecialRightGroup> AccessSpecialRightGroups { get; set; }

    public virtual DbSet<AccessSpecialRightGroupDetail> AccessSpecialRightGroupDetails { get; set; }

    public virtual DbSet<AccessThermalParam> AccessThermalParams { get; set; }

    public virtual DbSet<AttendanceDayReport> AttendanceDayReports { get; set; }

    public virtual DbSet<AttendanceEmailInfo> AttendanceEmailInfos { get; set; }

    public virtual DbSet<AttendanceEmailManager> AttendanceEmailManagers { get; set; }

    public virtual DbSet<AttendanceEmailSendInfo> AttendanceEmailSendInfos { get; set; }

    public virtual DbSet<AttendanceLeaveRecord> AttendanceLeaveRecords { get; set; }

    public virtual DbSet<AttendanceLeaveType> AttendanceLeaveTypes { get; set; }

    public virtual DbSet<AttendanceManualRecord> AttendanceManualRecords { get; set; }

    public virtual DbSet<AttendanceRecordsTemp> AttendanceRecordsTemps { get; set; }

    public virtual DbSet<AttendanceRostCode> AttendanceRostCodes { get; set; }

    public virtual DbSet<AttendanceRoster> AttendanceRosters { get; set; }

    public virtual DbSet<AttendanceServerCalcDate> AttendanceServerCalcDates { get; set; }

    public virtual DbSet<AttendanceShift> AttendanceShifts { get; set; }

    public virtual DbSet<BuildingFloorsAuthorityGroup> BuildingFloorsAuthorityGroups { get; set; }

    public virtual DbSet<BuildingFloorsAuthorityGroupDetail> BuildingFloorsAuthorityGroupDetails { get; set; }

    public virtual DbSet<BuildingFloorsInfo> BuildingFloorsInfos { get; set; }

    public virtual DbSet<BuildingFloorsUnitInfo> BuildingFloorsUnitInfos { get; set; }

    public virtual DbSet<BuildingInfo> BuildingInfos { get; set; }

    public virtual DbSet<CardInfo> CardInfos { get; set; }

    public virtual DbSet<ControlStatusModbu> ControlStatusModbus { get; set; }

    public virtual DbSet<DeviceCardformat> DeviceCardformats { get; set; }

    public virtual DbSet<DeviceGroupCode> DeviceGroupCodes { get; set; }

    public virtual DbSet<DeviceInfo> DeviceInfos { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<ElectronicMapAlarmLog> ElectronicMapAlarmLogs { get; set; }

    public virtual DbSet<ElectronicMapBuilding> ElectronicMapBuildings { get; set; }

    public virtual DbSet<ElectronicMapFloor> ElectronicMapFloors { get; set; }

    public virtual DbSet<ElectronicMapFloorDevice> ElectronicMapFloorDevices { get; set; }

    public virtual DbSet<Holidate> Holidates { get; set; }

    public virtual DbSet<HumanCardholder> HumanCardholders { get; set; }

    public virtual DbSet<HumanCardholdersDetail> HumanCardholdersDetails { get; set; }

    public virtual DbSet<HumanCardholdersFloorInfo> HumanCardholdersFloorInfos { get; set; }

    public virtual DbSet<HumanCategory> HumanCategories { get; set; }

    public virtual DbSet<HumanCompany> HumanCompanies { get; set; }

    public virtual DbSet<HumanDepartMultiDoorGroup> HumanDepartMultiDoorGroups { get; set; }

    public virtual DbSet<HumanDepartment> HumanDepartments { get; set; }

    public virtual DbSet<HumanDiviMultiDoorGroup> HumanDiviMultiDoorGroups { get; set; }

    public virtual DbSet<HumanDivision> HumanDivisions { get; set; }

    public virtual DbSet<IoControllerView> IoControllerViews { get; set; }

    public virtual DbSet<IocontrolParam> IocontrolParams { get; set; }

    public virtual DbSet<IoemergencyChannelGroup> IoemergencyChannelGroups { get; set; }

    public virtual DbSet<IoeventDefinition> IoeventDefinitions { get; set; }

    public virtual DbSet<IogroupAccessControl> IogroupAccessControls { get; set; }

    public virtual DbSet<IogroupCode> IogroupCodes { get; set; }

    public virtual DbSet<IoinputParam> IoinputParams { get; set; }

    public virtual DbSet<IooutputParam> IooutputParams { get; set; }

    public virtual DbSet<Iotimezone> Iotimezones { get; set; }

    public virtual DbSet<LiftAccessRight> LiftAccessRights { get; set; }

    public virtual DbSet<LiftControlFloor> LiftControlFloors { get; set; }

    public virtual DbSet<LiftEntryTimezone> LiftEntryTimezones { get; set; }

    public virtual DbSet<LiftFinderPanelInfo> LiftFinderPanelInfos { get; set; }

    public virtual DbSet<LiftTimezone> LiftTimezones { get; set; }

    public virtual DbSet<LilfControlParam> LilfControlParams { get; set; }

    public virtual DbSet<LoginUser> LoginUsers { get; set; }

    public virtual DbSet<MailboxControlParam> MailboxControlParams { get; set; }

    public virtual DbSet<ModbusMap> ModbusMaps { get; set; }

    public virtual DbSet<NistServer> NistServers { get; set; }

    public virtual DbSet<NvrcameraDeviceInfo> NvrcameraDeviceInfos { get; set; }

    public virtual DbSet<NvrdeviceInfo> NvrdeviceInfos { get; set; }

    public virtual DbSet<SysDbprocessing> SysDbprocessings { get; set; }

    public virtual DbSet<SysEventLog> SysEventLogs { get; set; }

    public virtual DbSet<SysInfo> SysInfos { get; set; }

    public virtual DbSet<TblCommServerCmd> TblCommServerCmds { get; set; }

    public virtual DbSet<TblSyncCommandLog> TblSyncCommandLogs { get; set; }

    public virtual DbSet<TblSyncIndex> TblSyncIndices { get; set; }

    public virtual DbSet<TblTmpSendLiftFinderCommand> TblTmpSendLiftFinderCommands { get; set; }

    public virtual DbSet<TenantVisitRecord> TenantVisitRecords { get; set; }

    public virtual DbSet<Timezone> Timezones { get; set; }

    public virtual DbSet<TmpsendSenseLinkServer> TmpsendSenseLinkServers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCategoryGroup> UserCategoryGroups { get; set; }

    public virtual DbSet<UserCtrlGroup> UserCtrlGroups { get; set; }

    public virtual DbSet<UserElectronicMapGroup> UserElectronicMapGroups { get; set; }

    public virtual DbSet<UserFunctionGroup> UserFunctionGroups { get; set; }

    public virtual DbSet<ViewAccessEntryRecord> ViewAccessEntryRecords { get; set; }

    public virtual DbSet<ViewCardStaffInfo> ViewCardStaffInfos { get; set; }

    public virtual DbSet<ViewEMail> ViewEMails { get; set; }

    public virtual DbSet<ViewVisitorAccessRecord> ViewVisitorAccessRecords { get; set; }

    public virtual DbSet<ViewVisitorAccessReport> ViewVisitorAccessReports { get; set; }

    public virtual DbSet<ViewVisitorBooking> ViewVisitorBookings { get; set; }

    public virtual DbSet<VisionEntryReport> VisionEntryReports { get; set; }

    public virtual DbSet<VisitCardInfo> VisitCardInfos { get; set; }

    public virtual DbSet<VisitRecord> VisitRecords { get; set; }

    public virtual DbSet<VisitorAccessRecord> VisitorAccessRecords { get; set; }

    public virtual DbSet<VwLiftCtrlCardholderDestFloor> VwLiftCtrlCardholderDestFloors { get; set; }

    public virtual DbSet<WaterLeakageControlParam> WaterLeakageControlParams { get; set; }

    public virtual DbSet<WaterLeakageDeviceInfo> WaterLeakageDeviceInfos { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=MorrisComputer;Database=Anderson_Road;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Chinese_PRC_CI_AS");

        modelBuilder.Entity<AccessAlarmDefinition>(entity =>
        {
            entity.HasKey(e => e.AlarmType);

            entity.ToTable("AccessAlarmDefinition");

            entity.Property(e => e.AlarmType)
                .ValueGeneratedNever()
                .HasColumnName("Alarm_type");
            entity.Property(e => e.AlarmEnable).HasColumnName("Alarm_enable");
            entity.Property(e => e.AlarmStatue).HasColumnName("Alarm_statue");
            entity.Property(e => e.AlarmTimeFrom).HasColumnName("AlarmTime_from");
            entity.Property(e => e.AlarmTimeTo).HasColumnName("AlarmTime_to");
        });

        modelBuilder.Entity<AccessAlarmEventNotifiyEmailAddress>(entity =>
        {
            entity.HasKey(e => e.EmailAddress);

            entity.ToTable("AccessAlarmEventNotifiyEmailAddress");

            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.DoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Door_group");
        });

        modelBuilder.Entity<AccessAntiBackGroup>(entity =>
        {
            entity.HasKey(e => e.AntiBackGroup).HasName("PK_AntiBack_group");

            entity.ToTable("AccessAntiBackGroup");

            entity.Property(e => e.AntiBackGroup)
                .HasMaxLength(20)
                .HasColumnName("AntiBack_group");
            entity.Property(e => e.AntiBackGroupDesc)
                .HasMaxLength(50)
                .HasColumnName("AntiBack_group_desc");
        });

        modelBuilder.Entity<AccessAntiBackGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.AntiBackGroup, e.DeviceId, e.PanelId });

            entity.ToTable("AccessAntiBackGroupDetail");

            entity.Property(e => e.AntiBackGroup)
                .HasMaxLength(20)
                .HasColumnName("AntiBack_group");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<AccessCtrlParament>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.AcAlarmBuzzerEnable).HasColumnName("AC_alarm_buzzer_enable");
            entity.Property(e => e.AcAlarmEnable).HasColumnName("AC_alarm_enable");
            entity.Property(e => e.AntiEnable).HasColumnName("Anti_enable");
            entity.Property(e => e.BreakinAutoResetEnable).HasColumnName("Breakin_auto_reset_enable");
            entity.Property(e => e.BreakinAutoResetTime).HasColumnName("Breakin_auto_reset_time");
            entity.Property(e => e.CardholderCapacity)
                .HasDefaultValue((short)3000)
                .HasColumnName("cardholder_capacity");
            entity.Property(e => e.CoercionPassword)
                .HasMaxLength(4)
                .HasColumnName("Coercion_password");
            entity.Property(e => e.CoercionPasswordEnable).HasColumnName("Coercion_password_enable");
            entity.Property(e => e.CommonPassword)
                .HasMaxLength(4)
                .HasColumnName("Common_password");
            entity.Property(e => e.CommonPasswordEnable).HasColumnName("Common_password_enable");
            entity.Property(e => e.CtrlBoxBreakinEnable).HasColumnName("Ctrl_box_breakin_enable");
            entity.Property(e => e.CtrllerOrReaderAnti)
                .HasDefaultValue((short)0)
                .HasColumnName("ctrller_or_reader_anti");
            entity.Property(e => e.DcAlarmBuzzerEnable).HasColumnName("DC_alarm_buzzer_enable");
            entity.Property(e => e.DcAlarmEnable).HasColumnName("DC_alarm_enable");
            entity.Property(e => e.DoorAjarBuzzerEnable).HasColumnName("Door_ajar_buzzer_enable");
            entity.Property(e => e.DoorBreakinBuzzerEnable).HasColumnName("Door_breakin_buzzer_enable");
            entity.Property(e => e.DoorBreakinEnable).HasColumnName("Door_breakin_enable");
            entity.Property(e => e.DoorBreakinTzEnable).HasColumnName("Door_breakin_tz_enable");
            entity.Property(e => e.DoubleDoorLockEnable).HasColumnName("Double_door_lock_enable");
            entity.Property(e => e.ElockTzEnable).HasColumnName("Elock_tz_enable");
            entity.Property(e => e.FireAlarmDoorOpen).HasColumnName("Fire_alarm_door_open");
            entity.Property(e => e.FireAlarmEnable).HasColumnName("Fire_alarm_enable");
            entity.Property(e => e.FireAlarmOuput).HasColumnName("Fire_alarm_ouput");
            entity.Property(e => e.LinkCardOpenEnable).HasColumnName("Link_card_open_enable");
            entity.Property(e => e.LinkCardOpenOutPasswordEnable).HasColumnName("Link_card_open_out_password_enable");
            entity.Property(e => e.LinkCardOpenPasswordEnable).HasColumnName("Link_card_open_password_enable");
            entity.Property(e => e.LinkCardOpenTime).HasColumnName("Link_card_open_time");
            entity.Property(e => e.LinkCardOpenTzEnable).HasColumnName("Link_card_open_tz_enable");
            entity.Property(e => e.MagneticAlrmBuzzerEnable).HasColumnName("Magnetic_alrm_buzzer_enable");
            entity.Property(e => e.MagneticAlrmEnable).HasColumnName("Magnetic_alrm_enable");
            entity.Property(e => e.MoLineAlarmBuzzerEnable).HasColumnName("MO_line_alarm_buzzer_enable");
            entity.Property(e => e.MoLineAlarmEnable).HasColumnName("MO_line_alarm_enable");
            entity.Property(e => e.NormalCardTimeout)
                .HasDefaultValue((short)5)
                .HasColumnName("normal_card_timeout");
            entity.Property(e => e.OpenLongEnable).HasColumnName("Open_long_enable");
            entity.Property(e => e.OpenLongTime).HasColumnName("Open_long_time");
            entity.Property(e => e.OpenLongTzEnable).HasColumnName("Open_long_tz_enable");
            entity.Property(e => e.OutAccessTzEnable).HasColumnName("Out_access_tz__enable");
            entity.Property(e => e.PanelTamperBreakinBuzzerEnable).HasColumnName("PanelTamper_breakin_buzzer_enable");
            entity.Property(e => e.PasswordAccessInEnable).HasColumnName("Password_access_in_enable");
            entity.Property(e => e.PasswordAccessOutEnable).HasColumnName("Password_access_out_enable");
            entity.Property(e => e.PasswordRetryEnable).HasColumnName("Password_retry_enable");
            entity.Property(e => e.PasswordRetryTimes).HasColumnName("Password_retry_times");
            entity.Property(e => e.PasswordTzEnable).HasColumnName("Password_tz_enable");
            entity.Property(e => e.ReaderAntidisassemblyBuzzerEnable).HasColumnName("Reader_antidisassembly_buzzer_enable");
            entity.Property(e => e.ReaderAntidisassemblyEnable).HasColumnName("Reader_antidisassembly_enable");
            entity.Property(e => e.ReleButtonTzEnable).HasColumnName("Rele_button_tz_enable");
            entity.Property(e => e.ReleaseLockTime).HasColumnName("Release_lock_time");
            entity.Property(e => e.TransferBreakinEnable).HasColumnName("Transfer_breakin_enable");
            entity.Property(e => e.TransferBreakinTime).HasColumnName("Transfer_breakin_time");
        });

        modelBuilder.Entity<AccessCtrlTimezone>(entity =>
        {
            entity.HasKey(e => e.TzType);

            entity.ToTable("AccessCtrlTimezone");

            entity.Property(e => e.TzType)
                .ValueGeneratedNever()
                .HasColumnName("Tz_type");
            entity.Property(e => e.Fri1From)
                .HasMaxLength(4)
                .HasColumnName("Fri1_from");
            entity.Property(e => e.Fri1To)
                .HasMaxLength(4)
                .HasColumnName("Fri1_to");
            entity.Property(e => e.Fri2From)
                .HasMaxLength(4)
                .HasColumnName("Fri2_from");
            entity.Property(e => e.Fri2To)
                .HasMaxLength(4)
                .HasColumnName("Fri2_to");
            entity.Property(e => e.Fri3From)
                .HasMaxLength(4)
                .HasColumnName("Fri3_from");
            entity.Property(e => e.Fri3To)
                .HasMaxLength(4)
                .HasColumnName("Fri3_to");
            entity.Property(e => e.Fri4From)
                .HasMaxLength(4)
                .HasColumnName("Fri4_from");
            entity.Property(e => e.Fri4To)
                .HasMaxLength(4)
                .HasColumnName("Fri4_to");
            entity.Property(e => e.Hol1From)
                .HasMaxLength(4)
                .HasColumnName("Hol1_from");
            entity.Property(e => e.Hol1To)
                .HasMaxLength(4)
                .HasColumnName("Hol1_to");
            entity.Property(e => e.Hol2From)
                .HasMaxLength(4)
                .HasColumnName("Hol2_from");
            entity.Property(e => e.Hol2To)
                .HasMaxLength(4)
                .HasColumnName("Hol2_to");
            entity.Property(e => e.Hol3From)
                .HasMaxLength(4)
                .HasColumnName("Hol3_from");
            entity.Property(e => e.Hol3To)
                .HasMaxLength(4)
                .HasColumnName("Hol3_to");
            entity.Property(e => e.Hol4From)
                .HasMaxLength(4)
                .HasColumnName("Hol4_from");
            entity.Property(e => e.Hol4To)
                .HasMaxLength(4)
                .HasColumnName("Hol4_to");
            entity.Property(e => e.Mon1From)
                .HasMaxLength(4)
                .HasColumnName("Mon1_from");
            entity.Property(e => e.Mon1To)
                .HasMaxLength(4)
                .HasColumnName("Mon1_to");
            entity.Property(e => e.Mon2From)
                .HasMaxLength(4)
                .HasColumnName("Mon2_from");
            entity.Property(e => e.Mon2To)
                .HasMaxLength(4)
                .HasColumnName("Mon2_to");
            entity.Property(e => e.Mon3From)
                .HasMaxLength(4)
                .HasColumnName("Mon3_from");
            entity.Property(e => e.Mon3To)
                .HasMaxLength(4)
                .HasColumnName("Mon3_to");
            entity.Property(e => e.Mon4From)
                .HasMaxLength(4)
                .HasColumnName("Mon4_from");
            entity.Property(e => e.Mon4To)
                .HasMaxLength(4)
                .HasColumnName("Mon4_to");
            entity.Property(e => e.Sat1From)
                .HasMaxLength(4)
                .HasColumnName("Sat1_from");
            entity.Property(e => e.Sat1To)
                .HasMaxLength(4)
                .HasColumnName("Sat1_to");
            entity.Property(e => e.Sat2From)
                .HasMaxLength(4)
                .HasColumnName("Sat2_from");
            entity.Property(e => e.Sat2To)
                .HasMaxLength(4)
                .HasColumnName("Sat2_to");
            entity.Property(e => e.Sat3From)
                .HasMaxLength(4)
                .HasColumnName("Sat3_from");
            entity.Property(e => e.Sat3To)
                .HasMaxLength(4)
                .HasColumnName("Sat3_to");
            entity.Property(e => e.Sat4From)
                .HasMaxLength(4)
                .HasColumnName("Sat4_from");
            entity.Property(e => e.Sat4To)
                .HasMaxLength(4)
                .HasColumnName("Sat4_to");
            entity.Property(e => e.Sun1From)
                .HasMaxLength(4)
                .HasColumnName("Sun1_from");
            entity.Property(e => e.Sun1To)
                .HasMaxLength(4)
                .HasColumnName("Sun1_to");
            entity.Property(e => e.Sun2From)
                .HasMaxLength(4)
                .HasColumnName("Sun2_from");
            entity.Property(e => e.Sun2To)
                .HasMaxLength(4)
                .HasColumnName("Sun2_to");
            entity.Property(e => e.Sun3From)
                .HasMaxLength(4)
                .HasColumnName("Sun3_from");
            entity.Property(e => e.Sun3To)
                .HasMaxLength(4)
                .HasColumnName("Sun3_to");
            entity.Property(e => e.Sun4From)
                .HasMaxLength(4)
                .HasColumnName("Sun4_from");
            entity.Property(e => e.Sun4To)
                .HasMaxLength(4)
                .HasColumnName("Sun4_to");
            entity.Property(e => e.Thu1From)
                .HasMaxLength(4)
                .HasColumnName("Thu1_from");
            entity.Property(e => e.Thu1To)
                .HasMaxLength(4)
                .HasColumnName("Thu1_to");
            entity.Property(e => e.Thu2From)
                .HasMaxLength(4)
                .HasColumnName("Thu2_from");
            entity.Property(e => e.Thu2To)
                .HasMaxLength(4)
                .HasColumnName("Thu2_to");
            entity.Property(e => e.Thu3From)
                .HasMaxLength(4)
                .HasColumnName("Thu3_from");
            entity.Property(e => e.Thu3To)
                .HasMaxLength(4)
                .HasColumnName("Thu3_to");
            entity.Property(e => e.Thu4From)
                .HasMaxLength(4)
                .HasColumnName("Thu4_from");
            entity.Property(e => e.Thu4To)
                .HasMaxLength(4)
                .HasColumnName("Thu4_to");
            entity.Property(e => e.Tue1From)
                .HasMaxLength(4)
                .HasColumnName("Tue1_from");
            entity.Property(e => e.Tue1To)
                .HasMaxLength(4)
                .HasColumnName("Tue1_to");
            entity.Property(e => e.Tue2From)
                .HasMaxLength(4)
                .HasColumnName("Tue2_from");
            entity.Property(e => e.Tue2To)
                .HasMaxLength(4)
                .HasColumnName("Tue2_to");
            entity.Property(e => e.Tue3From)
                .HasMaxLength(4)
                .HasColumnName("Tue3_from");
            entity.Property(e => e.Tue3To)
                .HasMaxLength(4)
                .HasColumnName("Tue3_to");
            entity.Property(e => e.Tue4From)
                .HasMaxLength(4)
                .HasColumnName("Tue4_from");
            entity.Property(e => e.Tue4To)
                .HasMaxLength(4)
                .HasColumnName("Tue4_to");
            entity.Property(e => e.Wed1From)
                .HasMaxLength(4)
                .HasColumnName("Wed1_from");
            entity.Property(e => e.Wed1To)
                .HasMaxLength(4)
                .HasColumnName("Wed1_to");
            entity.Property(e => e.Wed2From)
                .HasMaxLength(4)
                .HasColumnName("Wed2_from");
            entity.Property(e => e.Wed2To)
                .HasMaxLength(4)
                .HasColumnName("Wed2_to");
            entity.Property(e => e.Wed3From)
                .HasMaxLength(4)
                .HasColumnName("Wed3_from");
            entity.Property(e => e.Wed3To)
                .HasMaxLength(4)
                .HasColumnName("Wed3_to");
            entity.Property(e => e.Wed4From)
                .HasMaxLength(4)
                .HasColumnName("Wed4_from");
            entity.Property(e => e.Wed4To)
                .HasMaxLength(4)
                .HasColumnName("Wed4_to");
        });

        modelBuilder.Entity<AccessDoorGroup>(entity =>
        {
            entity.HasKey(e => e.DoorGroup);

            entity.ToTable("AccessDoorGroup");

            entity.Property(e => e.DoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Door_group");
            entity.Property(e => e.DoorGroupDesc)
                .HasMaxLength(50)
                .HasColumnName("Door_group_desc");
            entity.Property(e => e.GroupType)
                .HasDefaultValue(0)
                .HasColumnName("Group_type");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateData).HasColumnName("Update_data");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
        });

        modelBuilder.Entity<AccessDoorGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.DoorGroup, e.DeviceId, e.PanelId });

            entity.ToTable("AccessDoorGroupDetail");

            entity.Property(e => e.DoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Door_group");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.TzIndex).HasColumnName("Tz_index");

            entity.HasOne(d => d.DoorGroupNavigation).WithMany(p => p.AccessDoorGroupDetails)
                .HasForeignKey(d => d.DoorGroup)
                .HasConstraintName("FK_AccessDoorGroupDetail_AccessDoorGroup");
        });

        modelBuilder.Entity<AccessEntryRecord>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.CardInteNoHex)
                .HasMaxLength(16)
                .HasColumnName("Card_inte_no_hex");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(30)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.DepaDesc)
                .HasMaxLength(50)
                .HasColumnName("Depa_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.DeviceType).HasColumnName("Device_type");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.GpsLat)
                .HasMaxLength(50)
                .HasColumnName("GPS_lat");
            entity.Property(e => e.GpsLong)
                .HasMaxLength(50)
                .HasColumnName("GPS_long");
            entity.Property(e => e.IoStatus).HasColumnName("IO_status");
            entity.Property(e => e.IsMask).HasColumnName("isMask");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
            entity.Property(e => e.RecType)
                .HasMaxLength(1)
                .HasColumnName("Rec_type");
            entity.Property(e => e.Remark).HasMaxLength(1024);
        });

        modelBuilder.Entity<AccessEntryTimezone>(entity =>
        {
            entity.HasKey(e => e.TzIndex).HasName("PK_AccessEntryTimezone_1");

            entity.ToTable("AccessEntryTimezone");

            entity.Property(e => e.TzIndex)
                .ValueGeneratedNever()
                .HasColumnName("Tz_index");
            entity.Property(e => e.TzDesc)
                .HasMaxLength(30)
                .HasColumnName("Tz_desc");
        });

        modelBuilder.Entity<AccessEventMailAddress>(entity =>
        {
            entity.HasKey(e => new { e.EventType, e.MailAddress });

            entity.ToTable("AccessEventMailAddress");

            entity.Property(e => e.EventType)
                .HasMaxLength(10)
                .HasColumnName("Event_type");
            entity.Property(e => e.MailAddress)
                .HasMaxLength(50)
                .HasColumnName("Mail_address");
        });

        modelBuilder.Entity<AccessEventNotifiyInfo>(entity =>
        {
            entity.HasKey(e => e.EventType);

            entity.ToTable("AccessEventNotifiyInfo");

            entity.Property(e => e.EventType)
                .HasMaxLength(10)
                .HasColumnName("Event_type");
            entity.Property(e => e.DoorGroups).HasColumnName("Door_groups");
            entity.Property(e => e.EventTimeFrom)
                .HasColumnType("datetime")
                .HasColumnName("EventTime_from");
            entity.Property(e => e.EventTimeTo)
                .HasColumnType("datetime")
                .HasColumnName("EventTime_to");
        });

        modelBuilder.Entity<AccessEventRecord>(entity =>
        {
            entity.HasKey(e => e.Recno).HasName("PK_AccessAlarmRecords");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.ConfirmDt)
                .HasColumnType("datetime")
                .HasColumnName("Confirm_DT");
            entity.Property(e => e.ConfirmUser)
                .HasMaxLength(15)
                .HasColumnName("Confirm_user");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.EventDt)
                .HasColumnType("datetime")
                .HasColumnName("Event_dt");
            entity.Property(e => e.EventType).HasColumnName("Event_type");
            entity.Property(e => e.IoIndex).HasColumnName("IO_index");
            entity.Property(e => e.IsConfirm).HasColumnName("Is_confirm");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<AccessEventTypeDiction>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.ToTable("AccessEventTypeDiction");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.English).HasMaxLength(50);
            entity.Property(e => e.EventType)
                .HasMaxLength(3)
                .HasColumnName("Event_type");
            entity.Property(e => e.Other).HasMaxLength(50);
            entity.Property(e => e.SimplifiedChinese)
                .HasMaxLength(50)
                .HasColumnName("Simplified_Chinese");
            entity.Property(e => e.TraditionalChinese)
                .HasMaxLength(50)
                .HasColumnName("Traditional_Chinese");
        });

        modelBuilder.Entity<AccessFaceDevice>(entity =>
        {
            entity.HasKey(e => e.FaceDesc).HasName("PK_AccessFace");

            entity.ToTable("AccessFaceDevice");

            entity.Property(e => e.FaceDesc)
                .HasMaxLength(30)
                .HasColumnName("Face_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.DeviceType)
                .HasMaxLength(30)
                .HasColumnName("Device_type");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(25)
                .HasColumnName("Ip_address");
            entity.Property(e => e.IpPort).HasColumnName("Ip_port");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<AccessFingerprintCard>(entity =>
        {
            entity.HasKey(e => new { e.FpDesc, e.CardExtNo, e.FpId });

            entity.ToTable("AccessFingerprintCard");

            entity.Property(e => e.FpDesc)
                .HasMaxLength(30)
                .HasColumnName("FP_desc");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.FpId).HasColumnName("FP_ID");
        });

        modelBuilder.Entity<AccessFingerprintDevice>(entity =>
        {
            entity.HasKey(e => e.FpDesc).HasName("PK_AccessFingerprint");

            entity.ToTable("AccessFingerprintDevice");

            entity.Property(e => e.FpDesc)
                .HasMaxLength(30)
                .HasColumnName("FP_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(25)
                .HasColumnName("Ip_address");
            entity.Property(e => e.IpPort).HasColumnName("Ip_port");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<AccessFireAlarmGroup>(entity =>
        {
            entity.HasKey(e => e.FireAlarmGroup);

            entity.ToTable("AccessFireAlarmGroup");

            entity.Property(e => e.FireAlarmGroup)
                .HasMaxLength(50)
                .HasColumnName("Fire_alarm_group");
        });

        modelBuilder.Entity<AccessFireAlarmGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.FireAlarmGroup, e.DeviceId, e.PanelId });

            entity.ToTable("AccessFireAlarmGroupDetail");

            entity.Property(e => e.FireAlarmGroup)
                .HasMaxLength(50)
                .HasColumnName("Fire_alarm_group");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<AccessHidreaderParameter>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId });

            entity.ToTable("AccessHIDReaderParameters");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.CardType).HasColumnName("Card_type");
            entity.Property(e => e.CheckInOut).HasColumnName("Check_in_out");
            entity.Property(e => e.CsnLangth).HasColumnName("CSN_langth");
            entity.Property(e => e.CsnReversal).HasColumnName("CSN_reversal");
            entity.Property(e => e.DisplayCardNoEnable).HasColumnName("Display_card_no_enable");
            entity.Property(e => e.DisplayDateFormat).HasColumnName("Display_date_format");
            entity.Property(e => e.DisplayFcCodeEnable).HasColumnName("Display_fc_code_enable");
            entity.Property(e => e.DisplayFormatHex).HasColumnName("Display_format_hex");
            entity.Property(e => e.DisplaySystemMsg).HasColumnName("Display_system_msg");
            entity.Property(e => e.DoorInOut).HasColumnName("Door_in_out");
            entity.Property(e => e.LcdContrast).HasColumnName("LCD_contrast");
            entity.Property(e => e.LeadingZeroEnable).HasColumnName("Leading_zero_enable");
            entity.Property(e => e.MsgAccept)
                .HasMaxLength(100)
                .HasColumnName("Msg_accept");
            entity.Property(e => e.MsgLine1)
                .HasMaxLength(100)
                .HasColumnName("Msg_line1");
            entity.Property(e => e.MsgLine4)
                .HasMaxLength(100)
                .HasColumnName("Msg_line4");
            entity.Property(e => e.MsgReject)
                .HasMaxLength(100)
                .HasColumnName("Msg_reject");
            entity.Property(e => e.MsgTimeout).HasColumnName("Msg_timeout");
            entity.Property(e => e.ReaderType).HasColumnName("Reader_type");
        });

        modelBuilder.Entity<AccessHoliday>(entity =>
        {
            entity.ToTable("AccessHoliday");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Holiday).HasColumnType("datetime");
            entity.Property(e => e.HolidayDesc)
                .HasMaxLength(30)
                .HasColumnName("Holiday_desc");
        });

        modelBuilder.Entity<AccessIndCtrlHoliday>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.DeviceId, e.PanelId }).HasName("PK_AccessIndCtrlHolidate");

            entity.ToTable("AccessIndCtrlHoliday");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.Holiday).HasColumnType("datetime");
            entity.Property(e => e.HolidayDesc)
                .HasMaxLength(30)
                .HasColumnName("Holiday_desc");
            entity.Property(e => e.IndEnable).HasColumnName("Ind_enable");
        });

        modelBuilder.Entity<AccessIndCtrlParament>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.AcAlarmBuzzerEnable).HasColumnName("AC_alarm_buzzer_enable");
            entity.Property(e => e.AcAlarmEnable).HasColumnName("AC_alarm_enable");
            entity.Property(e => e.AntiEnable).HasColumnName("Anti_enable");
            entity.Property(e => e.BreakinAutoResetEnable).HasColumnName("Breakin_auto_reset_enable");
            entity.Property(e => e.BreakinAutoResetTime).HasColumnName("Breakin_auto_reset_time");
            entity.Property(e => e.CardholderCapacity)
                .HasDefaultValue((short)3000)
                .HasColumnName("cardholder_capacity");
            entity.Property(e => e.CoercionPassword)
                .HasMaxLength(4)
                .HasColumnName("Coercion_password");
            entity.Property(e => e.CoercionPasswordEnable).HasColumnName("Coercion_password_enable");
            entity.Property(e => e.CommonPassword)
                .HasMaxLength(4)
                .HasColumnName("Common_password");
            entity.Property(e => e.CommonPasswordEnable).HasColumnName("Common_password_enable");
            entity.Property(e => e.CtrlBoxBreakinEnable).HasColumnName("Ctrl_box_breakin_enable");
            entity.Property(e => e.CtrllerOrReaderAnti)
                .HasDefaultValue((short)0)
                .HasColumnName("ctrller_or_reader_anti");
            entity.Property(e => e.DcAlarmBuzzerEnable).HasColumnName("DC_alarm_buzzer_enable");
            entity.Property(e => e.DcAlarmEnable).HasColumnName("DC_alarm_enable");
            entity.Property(e => e.DoorAjarBuzzerEnable).HasColumnName("Door_ajar_buzzer_enable");
            entity.Property(e => e.DoorBreakinBuzzerEnable).HasColumnName("Door_breakin_buzzer_enable");
            entity.Property(e => e.DoorBreakinEnable).HasColumnName("Door_breakin_enable");
            entity.Property(e => e.DoorBreakinTzEnable).HasColumnName("Door_breakin_tz_enable");
            entity.Property(e => e.DoubleDoorLockEnable).HasColumnName("Double_door_lock_enable");
            entity.Property(e => e.ElockTzEnable).HasColumnName("Elock_tz_enable");
            entity.Property(e => e.FireAlarmDoorOpen).HasColumnName("Fire_alarm_door_open");
            entity.Property(e => e.FireAlarmEnable).HasColumnName("Fire_alarm_enable");
            entity.Property(e => e.FireAlarmOuput).HasColumnName("Fire_alarm_ouput");
            entity.Property(e => e.IndEnable).HasColumnName("Ind_enable");
            entity.Property(e => e.LinkCardOpenEnable).HasColumnName("Link_card_open_enable");
            entity.Property(e => e.LinkCardOpenOutPasswordEnable).HasColumnName("Link_card_open_out_password_enable");
            entity.Property(e => e.LinkCardOpenPasswordEnable).HasColumnName("Link_card_open_password_enable");
            entity.Property(e => e.LinkCardOpenTime).HasColumnName("Link_card_open_time");
            entity.Property(e => e.LinkCardOpenTzEnable).HasColumnName("Link_card_open_tz_enable");
            entity.Property(e => e.MagneticAlrmBuzzerEnable).HasColumnName("Magnetic_alrm_buzzer_enable");
            entity.Property(e => e.MagneticAlrmEnable).HasColumnName("Magnetic_alrm_enable");
            entity.Property(e => e.MoLineAlarmBuzzerEnable).HasColumnName("MO_line_alarm_buzzer_enable");
            entity.Property(e => e.MoLineAlarmEnable).HasColumnName("MO_line_alarm_enable");
            entity.Property(e => e.NormalCardTimeout)
                .HasDefaultValue((short)5)
                .HasColumnName("normal_card_timeout");
            entity.Property(e => e.OpenLongEnable).HasColumnName("Open_long_enable");
            entity.Property(e => e.OpenLongTime).HasColumnName("Open_long_time");
            entity.Property(e => e.OpenLongTzEnable).HasColumnName("Open_long_tz_enable");
            entity.Property(e => e.OutAccessTzEnable).HasColumnName("Out_access_tz__enable");
            entity.Property(e => e.PanelTamperBreakinBuzzerEnable).HasColumnName("PanelTamper_breakin_buzzer_enable");
            entity.Property(e => e.PasswordAccessInEnable).HasColumnName("Password_access_in_enable");
            entity.Property(e => e.PasswordAccessOutEnable).HasColumnName("Password_access_out_enable");
            entity.Property(e => e.PasswordRetryEnable).HasColumnName("Password_retry_enable");
            entity.Property(e => e.PasswordRetryTimes).HasColumnName("Password_retry_times");
            entity.Property(e => e.PasswordTzEnable).HasColumnName("Password_tz_enable");
            entity.Property(e => e.ReaderAntidisassemblyBuzzerEnable).HasColumnName("Reader_antidisassembly_buzzer_enable");
            entity.Property(e => e.ReaderAntidisassemblyEnable).HasColumnName("Reader_antidisassembly_enable");
            entity.Property(e => e.ReleButtonTzEnable).HasColumnName("Rele_button_tz_enable");
            entity.Property(e => e.ReleaseLockTime).HasColumnName("Release_lock_time");
            entity.Property(e => e.TransferBreakinEnable).HasColumnName("Transfer_breakin_enable");
            entity.Property(e => e.TransferBreakinTime).HasColumnName("Transfer_breakin_time");
        });

        modelBuilder.Entity<AccessIndCtrlTimezone>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.TzType });

            entity.ToTable("AccessIndCtrlTimezone");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.TzType).HasColumnName("Tz_type");
            entity.Property(e => e.Fri1From)
                .HasMaxLength(4)
                .HasColumnName("Fri1_from");
            entity.Property(e => e.Fri1To)
                .HasMaxLength(4)
                .HasColumnName("Fri1_to");
            entity.Property(e => e.Fri2From)
                .HasMaxLength(4)
                .HasColumnName("Fri2_from");
            entity.Property(e => e.Fri2To)
                .HasMaxLength(4)
                .HasColumnName("Fri2_to");
            entity.Property(e => e.Fri3From)
                .HasMaxLength(4)
                .HasColumnName("Fri3_from");
            entity.Property(e => e.Fri3To)
                .HasMaxLength(4)
                .HasColumnName("Fri3_to");
            entity.Property(e => e.Fri4From)
                .HasMaxLength(4)
                .HasColumnName("Fri4_from");
            entity.Property(e => e.Fri4To)
                .HasMaxLength(4)
                .HasColumnName("Fri4_to");
            entity.Property(e => e.Hol1From)
                .HasMaxLength(4)
                .HasColumnName("Hol1_from");
            entity.Property(e => e.Hol1To)
                .HasMaxLength(4)
                .HasColumnName("Hol1_to");
            entity.Property(e => e.Hol2From)
                .HasMaxLength(4)
                .HasColumnName("Hol2_from");
            entity.Property(e => e.Hol2To)
                .HasMaxLength(4)
                .HasColumnName("Hol2_to");
            entity.Property(e => e.Hol3From)
                .HasMaxLength(4)
                .HasColumnName("Hol3_from");
            entity.Property(e => e.Hol3To)
                .HasMaxLength(4)
                .HasColumnName("Hol3_to");
            entity.Property(e => e.Hol4From)
                .HasMaxLength(4)
                .HasColumnName("Hol4_from");
            entity.Property(e => e.Hol4To)
                .HasMaxLength(4)
                .HasColumnName("Hol4_to");
            entity.Property(e => e.IndEnable).HasColumnName("Ind_enable");
            entity.Property(e => e.Mon1From)
                .HasMaxLength(4)
                .HasColumnName("Mon1_from");
            entity.Property(e => e.Mon1To)
                .HasMaxLength(4)
                .HasColumnName("Mon1_to");
            entity.Property(e => e.Mon2From)
                .HasMaxLength(4)
                .HasColumnName("Mon2_from");
            entity.Property(e => e.Mon2To)
                .HasMaxLength(4)
                .HasColumnName("Mon2_to");
            entity.Property(e => e.Mon3From)
                .HasMaxLength(4)
                .HasColumnName("Mon3_from");
            entity.Property(e => e.Mon3To)
                .HasMaxLength(4)
                .HasColumnName("Mon3_to");
            entity.Property(e => e.Mon4From)
                .HasMaxLength(4)
                .HasColumnName("Mon4_from");
            entity.Property(e => e.Mon4To)
                .HasMaxLength(4)
                .HasColumnName("Mon4_to");
            entity.Property(e => e.Sat1From)
                .HasMaxLength(4)
                .HasColumnName("Sat1_from");
            entity.Property(e => e.Sat1To)
                .HasMaxLength(4)
                .HasColumnName("Sat1_to");
            entity.Property(e => e.Sat2From)
                .HasMaxLength(4)
                .HasColumnName("Sat2_from");
            entity.Property(e => e.Sat2To)
                .HasMaxLength(4)
                .HasColumnName("Sat2_to");
            entity.Property(e => e.Sat3From)
                .HasMaxLength(4)
                .HasColumnName("Sat3_from");
            entity.Property(e => e.Sat3To)
                .HasMaxLength(4)
                .HasColumnName("Sat3_to");
            entity.Property(e => e.Sat4From)
                .HasMaxLength(4)
                .HasColumnName("Sat4_from");
            entity.Property(e => e.Sat4To)
                .HasMaxLength(4)
                .HasColumnName("Sat4_to");
            entity.Property(e => e.Sun1From)
                .HasMaxLength(4)
                .HasColumnName("Sun1_from");
            entity.Property(e => e.Sun1To)
                .HasMaxLength(4)
                .HasColumnName("Sun1_to");
            entity.Property(e => e.Sun2From)
                .HasMaxLength(4)
                .HasColumnName("Sun2_from");
            entity.Property(e => e.Sun2To)
                .HasMaxLength(4)
                .HasColumnName("Sun2_to");
            entity.Property(e => e.Sun3From)
                .HasMaxLength(4)
                .HasColumnName("Sun3_from");
            entity.Property(e => e.Sun3To)
                .HasMaxLength(4)
                .HasColumnName("Sun3_to");
            entity.Property(e => e.Sun4From)
                .HasMaxLength(4)
                .HasColumnName("Sun4_from");
            entity.Property(e => e.Sun4To)
                .HasMaxLength(4)
                .HasColumnName("Sun4_to");
            entity.Property(e => e.Thu1From)
                .HasMaxLength(4)
                .HasColumnName("Thu1_from");
            entity.Property(e => e.Thu1To)
                .HasMaxLength(4)
                .HasColumnName("Thu1_to");
            entity.Property(e => e.Thu2From)
                .HasMaxLength(4)
                .HasColumnName("Thu2_from");
            entity.Property(e => e.Thu2To)
                .HasMaxLength(4)
                .HasColumnName("Thu2_to");
            entity.Property(e => e.Thu3From)
                .HasMaxLength(4)
                .HasColumnName("Thu3_from");
            entity.Property(e => e.Thu3To)
                .HasMaxLength(4)
                .HasColumnName("Thu3_to");
            entity.Property(e => e.Thu4From)
                .HasMaxLength(4)
                .HasColumnName("Thu4_from");
            entity.Property(e => e.Thu4To)
                .HasMaxLength(4)
                .HasColumnName("Thu4_to");
            entity.Property(e => e.Tue1From)
                .HasMaxLength(4)
                .HasColumnName("Tue1_from");
            entity.Property(e => e.Tue1To)
                .HasMaxLength(4)
                .HasColumnName("Tue1_to");
            entity.Property(e => e.Tue2From)
                .HasMaxLength(4)
                .HasColumnName("Tue2_from");
            entity.Property(e => e.Tue2To)
                .HasMaxLength(4)
                .HasColumnName("Tue2_to");
            entity.Property(e => e.Tue3From)
                .HasMaxLength(4)
                .HasColumnName("Tue3_from");
            entity.Property(e => e.Tue3To)
                .HasMaxLength(4)
                .HasColumnName("Tue3_to");
            entity.Property(e => e.Tue4From)
                .HasMaxLength(4)
                .HasColumnName("Tue4_from");
            entity.Property(e => e.Tue4To)
                .HasMaxLength(4)
                .HasColumnName("Tue4_to");
            entity.Property(e => e.Wed1From)
                .HasMaxLength(4)
                .HasColumnName("Wed1_from");
            entity.Property(e => e.Wed1To)
                .HasMaxLength(4)
                .HasColumnName("Wed1_to");
            entity.Property(e => e.Wed2From)
                .HasMaxLength(4)
                .HasColumnName("Wed2_from");
            entity.Property(e => e.Wed2To)
                .HasMaxLength(4)
                .HasColumnName("Wed2_to");
            entity.Property(e => e.Wed3From)
                .HasMaxLength(4)
                .HasColumnName("Wed3_from");
            entity.Property(e => e.Wed3To)
                .HasMaxLength(4)
                .HasColumnName("Wed3_to");
            entity.Property(e => e.Wed4From)
                .HasMaxLength(4)
                .HasColumnName("Wed4_from");
            entity.Property(e => e.Wed4To)
                .HasMaxLength(4)
                .HasColumnName("Wed4_to");
        });

        modelBuilder.Entity<AccessIndEntryTimezone>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.TzIndex });

            entity.ToTable("AccessIndEntryTimezone");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.TzIndex).HasColumnName("Tz_index");
            entity.Property(e => e.IndEnable).HasColumnName("Ind_enable");
            entity.Property(e => e.TzDesc)
                .HasMaxLength(30)
                .HasColumnName("Tz_desc");
        });

        modelBuilder.Entity<AccessIndReaderDisplayTimezone>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.LineNum, e.ReaderId }).HasName("PK_AccessReaderDisplayTimezone");

            entity.ToTable("AccessIndReaderDisplayTimezone");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.LineNum).HasColumnName("Line_num");
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
            entity.Property(e => e.Fri1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri1_display_text");
            entity.Property(e => e.Fri1From)
                .HasMaxLength(4)
                .HasColumnName("Fri1_from");
            entity.Property(e => e.Fri1To)
                .HasMaxLength(4)
                .HasColumnName("Fri1_to");
            entity.Property(e => e.Fri2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri2_display_text");
            entity.Property(e => e.Fri2From)
                .HasMaxLength(4)
                .HasColumnName("Fri2_from");
            entity.Property(e => e.Fri2To)
                .HasMaxLength(4)
                .HasColumnName("Fri2_to");
            entity.Property(e => e.Fri3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri3_display_text");
            entity.Property(e => e.Fri3From)
                .HasMaxLength(4)
                .HasColumnName("Fri3_from");
            entity.Property(e => e.Fri3To)
                .HasMaxLength(4)
                .HasColumnName("Fri3_to");
            entity.Property(e => e.Fri4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri4_display_text");
            entity.Property(e => e.Fri4From)
                .HasMaxLength(4)
                .HasColumnName("Fri4_from");
            entity.Property(e => e.Fri4To)
                .HasMaxLength(4)
                .HasColumnName("Fri4_to");
            entity.Property(e => e.Hol1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol1_display_text");
            entity.Property(e => e.Hol1From)
                .HasMaxLength(4)
                .HasColumnName("Hol1_from");
            entity.Property(e => e.Hol1To)
                .HasMaxLength(4)
                .HasColumnName("Hol1_to");
            entity.Property(e => e.Hol2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol2_display_text");
            entity.Property(e => e.Hol2From)
                .HasMaxLength(4)
                .HasColumnName("Hol2_from");
            entity.Property(e => e.Hol2To)
                .HasMaxLength(4)
                .HasColumnName("Hol2_to");
            entity.Property(e => e.Hol3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol3_display_text");
            entity.Property(e => e.Hol3From)
                .HasMaxLength(4)
                .HasColumnName("Hol3_from");
            entity.Property(e => e.Hol3To)
                .HasMaxLength(4)
                .HasColumnName("Hol3_to");
            entity.Property(e => e.Hol4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol4_display_text");
            entity.Property(e => e.Hol4From)
                .HasMaxLength(4)
                .HasColumnName("Hol4_from");
            entity.Property(e => e.Hol4To)
                .HasMaxLength(4)
                .HasColumnName("Hol4_to");
            entity.Property(e => e.IndEnable).HasColumnName("Ind_enable");
            entity.Property(e => e.Mon1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon1_display_text");
            entity.Property(e => e.Mon1From)
                .HasMaxLength(4)
                .HasColumnName("Mon1_from");
            entity.Property(e => e.Mon1To)
                .HasMaxLength(4)
                .HasColumnName("Mon1_to");
            entity.Property(e => e.Mon2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon2_display_text");
            entity.Property(e => e.Mon2From)
                .HasMaxLength(4)
                .HasColumnName("Mon2_from");
            entity.Property(e => e.Mon2To)
                .HasMaxLength(4)
                .HasColumnName("Mon2_to");
            entity.Property(e => e.Mon3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon3_display_text");
            entity.Property(e => e.Mon3From)
                .HasMaxLength(4)
                .HasColumnName("Mon3_from");
            entity.Property(e => e.Mon3To)
                .HasMaxLength(4)
                .HasColumnName("Mon3_to");
            entity.Property(e => e.Mon4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon4_display_text");
            entity.Property(e => e.Mon4From)
                .HasMaxLength(4)
                .HasColumnName("Mon4_from");
            entity.Property(e => e.Mon4To)
                .HasMaxLength(4)
                .HasColumnName("Mon4_to");
            entity.Property(e => e.Sat1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat1_display_text");
            entity.Property(e => e.Sat1From)
                .HasMaxLength(4)
                .HasColumnName("Sat1_from");
            entity.Property(e => e.Sat1To)
                .HasMaxLength(4)
                .HasColumnName("Sat1_to");
            entity.Property(e => e.Sat2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat2_display_text");
            entity.Property(e => e.Sat2From)
                .HasMaxLength(4)
                .HasColumnName("Sat2_from");
            entity.Property(e => e.Sat2To)
                .HasMaxLength(4)
                .HasColumnName("Sat2_to");
            entity.Property(e => e.Sat3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat3_display_text");
            entity.Property(e => e.Sat3From)
                .HasMaxLength(4)
                .HasColumnName("Sat3_from");
            entity.Property(e => e.Sat3To)
                .HasMaxLength(4)
                .HasColumnName("Sat3_to");
            entity.Property(e => e.Sat4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat4_display_text");
            entity.Property(e => e.Sat4From)
                .HasMaxLength(4)
                .HasColumnName("Sat4_from");
            entity.Property(e => e.Sat4To)
                .HasMaxLength(4)
                .HasColumnName("Sat4_to");
            entity.Property(e => e.Sun1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun1_display_text");
            entity.Property(e => e.Sun1From)
                .HasMaxLength(4)
                .HasColumnName("Sun1_from");
            entity.Property(e => e.Sun1To)
                .HasMaxLength(4)
                .HasColumnName("Sun1_to");
            entity.Property(e => e.Sun2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun2_display_text");
            entity.Property(e => e.Sun2From)
                .HasMaxLength(4)
                .HasColumnName("Sun2_from");
            entity.Property(e => e.Sun2To)
                .HasMaxLength(4)
                .HasColumnName("Sun2_to");
            entity.Property(e => e.Sun3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun3_display_text");
            entity.Property(e => e.Sun3From)
                .HasMaxLength(4)
                .HasColumnName("Sun3_from");
            entity.Property(e => e.Sun3To)
                .HasMaxLength(4)
                .HasColumnName("Sun3_to");
            entity.Property(e => e.Sun4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun4_display_text");
            entity.Property(e => e.Sun4From)
                .HasMaxLength(4)
                .HasColumnName("Sun4_from");
            entity.Property(e => e.Sun4To)
                .HasMaxLength(4)
                .HasColumnName("Sun4_to");
            entity.Property(e => e.Thu1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu1_display_text");
            entity.Property(e => e.Thu1From)
                .HasMaxLength(4)
                .HasColumnName("Thu1_from");
            entity.Property(e => e.Thu1To)
                .HasMaxLength(4)
                .HasColumnName("Thu1_to");
            entity.Property(e => e.Thu2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu2_display_text");
            entity.Property(e => e.Thu2From)
                .HasMaxLength(4)
                .HasColumnName("Thu2_from");
            entity.Property(e => e.Thu2To)
                .HasMaxLength(4)
                .HasColumnName("Thu2_to");
            entity.Property(e => e.Thu3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu3_display_text");
            entity.Property(e => e.Thu3From)
                .HasMaxLength(4)
                .HasColumnName("Thu3_from");
            entity.Property(e => e.Thu3To)
                .HasMaxLength(4)
                .HasColumnName("Thu3_to");
            entity.Property(e => e.Thu4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu4_display_text");
            entity.Property(e => e.Thu4From)
                .HasMaxLength(4)
                .HasColumnName("Thu4_from");
            entity.Property(e => e.Thu4To)
                .HasMaxLength(4)
                .HasColumnName("Thu4_to");
            entity.Property(e => e.Tue1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue1_display_text");
            entity.Property(e => e.Tue1From)
                .HasMaxLength(4)
                .HasColumnName("Tue1_from");
            entity.Property(e => e.Tue1To)
                .HasMaxLength(4)
                .HasColumnName("Tue1_to");
            entity.Property(e => e.Tue2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue2_display_text");
            entity.Property(e => e.Tue2From)
                .HasMaxLength(4)
                .HasColumnName("Tue2_from");
            entity.Property(e => e.Tue2To)
                .HasMaxLength(4)
                .HasColumnName("Tue2_to");
            entity.Property(e => e.Tue3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue3_display_text");
            entity.Property(e => e.Tue3From)
                .HasMaxLength(4)
                .HasColumnName("Tue3_from");
            entity.Property(e => e.Tue3To)
                .HasMaxLength(4)
                .HasColumnName("Tue3_to");
            entity.Property(e => e.Tue4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue4_display_text");
            entity.Property(e => e.Tue4From)
                .HasMaxLength(4)
                .HasColumnName("Tue4_from");
            entity.Property(e => e.Tue4To)
                .HasMaxLength(4)
                .HasColumnName("Tue4_to");
            entity.Property(e => e.Wed1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed1_display_text");
            entity.Property(e => e.Wed1From)
                .HasMaxLength(4)
                .HasColumnName("Wed1_from");
            entity.Property(e => e.Wed1To)
                .HasMaxLength(4)
                .HasColumnName("Wed1_to");
            entity.Property(e => e.Wed2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed2_display_text");
            entity.Property(e => e.Wed2From)
                .HasMaxLength(4)
                .HasColumnName("Wed2_from");
            entity.Property(e => e.Wed2To)
                .HasMaxLength(4)
                .HasColumnName("Wed2_to");
            entity.Property(e => e.Wed3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed3_display_text");
            entity.Property(e => e.Wed3From)
                .HasMaxLength(4)
                .HasColumnName("Wed3_from");
            entity.Property(e => e.Wed3To)
                .HasMaxLength(4)
                .HasColumnName("Wed3_to");
            entity.Property(e => e.Wed4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed4_display_text");
            entity.Property(e => e.Wed4From)
                .HasMaxLength(4)
                .HasColumnName("Wed4_from");
            entity.Property(e => e.Wed4To)
                .HasMaxLength(4)
                .HasColumnName("Wed4_to");
        });

        modelBuilder.Entity<AccessIndReaderParameter>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.AccessDeniedStatus).HasColumnName("Access_denied_status");
            entity.Property(e => e.AccessGrantedStatus).HasColumnName("Access_granted_status");
            entity.Property(e => e.Baudrate).HasColumnName("baudrate");
            entity.Property(e => e.BuzzerTime).HasColumnName("Buzzer_time");
            entity.Property(e => e.CardBits).HasColumnName("Card_bits");
            entity.Property(e => e.CardIdLength).HasColumnName("Card_id_length");
            entity.Property(e => e.CardIdPos).HasColumnName("Card_id_pos");
            entity.Property(e => e.CardKeyData)
                .HasMaxLength(32)
                .HasColumnName("Card_key_data");
            entity.Property(e => e.CardKeyType).HasColumnName("Card_key_type");
            entity.Property(e => e.CardNoBlock).HasColumnName("Card_no_block");
            entity.Property(e => e.CardNoLength).HasColumnName("Card_no_length");
            entity.Property(e => e.CardNoPosStart).HasColumnName("Card_no_pos_start");
            entity.Property(e => e.CardNoSector).HasColumnName("Card_no_sector");
            entity.Property(e => e.CardSiteEnable).HasColumnName("Card_site_enable");
            entity.Property(e => e.CardType).HasColumnName("Card_type");
            entity.Property(e => e.CloseBuzzerTime).HasColumnName("Close_buzzer_time");
            entity.Property(e => e.CloseTwinkleTime).HasColumnName("Close_twinkle_time");
            entity.Property(e => e.CsnReserve).HasColumnName("CSN_reserve");
            entity.Property(e => e.DeniedBuzzerCount).HasColumnName("Denied_buzzer_count");
            entity.Property(e => e.DeniedTwinkleCount).HasColumnName("Denied_twinkle_count");
            entity.Property(e => e.DisplayCardNoEnable).HasColumnName("Display_card_no_enable");
            entity.Property(e => e.DisplayDateFormat).HasColumnName("Display_date_format");
            entity.Property(e => e.DisplayFcCodeEnable).HasColumnName("Display_fc_code_enable");
            entity.Property(e => e.DisplayFormatHex).HasColumnName("Display_format_hex");
            entity.Property(e => e.EvenEnable).HasColumnName("Even_enable");
            entity.Property(e => e.EvenPLength).HasColumnName("Even_p_length");
            entity.Property(e => e.EvenPPos).HasColumnName("Even_p_pos");
            entity.Property(e => e.EvenPStart).HasColumnName("Even_p_start");
            entity.Property(e => e.GrantedBuzzerCount).HasColumnName("Granted_buzzer_count");
            entity.Property(e => e.GrantedTwinkleCount).HasColumnName("Granted_twinkle_count");
            entity.Property(e => e.InMsgAccept)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_accept");
            entity.Property(e => e.InMsgIdle)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_idle");
            entity.Property(e => e.InMsgLog)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_log");
            entity.Property(e => e.InMsgReject)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_reject");
            entity.Property(e => e.InReaderBluetoothEnable).HasColumnName("InReader_bluetooth_enable");
            entity.Property(e => e.IndEnable).HasColumnName("Ind_enable");
            entity.Property(e => e.LcdContrast).HasColumnName("LCD_contrast");
            entity.Property(e => e.LeadingZeroEnable).HasColumnName("Leading_zero_enable");
            entity.Property(e => e.LightingDelayTime).HasColumnName("Lighting_delay_time");
            entity.Property(e => e.MsgTimeout).HasColumnName("Msg_timeout");
            entity.Property(e => e.NormalStatus).HasColumnName("Normal_status");
            entity.Property(e => e.OddEnable).HasColumnName("Odd_enable");
            entity.Property(e => e.OddPLength).HasColumnName("Odd_p_length");
            entity.Property(e => e.OddPPos).HasColumnName("Odd_p_pos");
            entity.Property(e => e.OddPStart).HasColumnName("Odd_p_start");
            entity.Property(e => e.OutMsgAccept)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_accept");
            entity.Property(e => e.OutMsgIdle)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_idle");
            entity.Property(e => e.OutMsgLog)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_log");
            entity.Property(e => e.OutMsgReject)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_reject");
            entity.Property(e => e.OutReaderBluetoothEnable1).HasColumnName("OutReader_bluetooth_enable1");
            entity.Property(e => e.PasswordInputMode).HasColumnName("Password_input_mode");
            entity.Property(e => e.ReadCardType).HasColumnName("Read_card_type");
            entity.Property(e => e.ReaderCommKey)
                .HasMaxLength(48)
                .HasColumnName("Reader_comm_key");
            entity.Property(e => e.SiteCode1).HasColumnName("Site_code1");
            entity.Property(e => e.SiteCode2).HasColumnName("Site_code2");
            entity.Property(e => e.SiteCode3).HasColumnName("Site_code3");
            entity.Property(e => e.SiteLength).HasColumnName("Site_length");
            entity.Property(e => e.SitePos).HasColumnName("Site_pos");
        });

        modelBuilder.Entity<AccessIostatusDiction>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.ToTable("AccessIOStatusDiction");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.English).HasMaxLength(50);
            entity.Property(e => e.IoStatus).HasColumnName("IO_Status");
            entity.Property(e => e.Others).HasMaxLength(50);
            entity.Property(e => e.SimplifiedChinese)
                .HasMaxLength(50)
                .HasColumnName("Simplified_Chinese");
            entity.Property(e => e.TraditionalChinese)
                .HasMaxLength(50)
                .HasColumnName("Traditional_Chinese");
        });

        modelBuilder.Entity<AccessMulitCardhold>(entity =>
        {
            entity.HasKey(e => new { e.CardExtNo1, e.CardExtNo2 });

            entity.ToTable("AccessMulitCardhold");

            entity.Property(e => e.CardExtNo1)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no1");
            entity.Property(e => e.CardExtNo2)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no2");
            entity.Property(e => e.DoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Door_group");
            entity.Property(e => e.EmpNo1)
                .HasMaxLength(20)
                .HasColumnName("Emp_no1");
            entity.Property(e => e.EmpNo2)
                .HasMaxLength(20)
                .HasColumnName("Emp_no2");
        });

        modelBuilder.Entity<AccessMultiDoorGroup>(entity =>
        {
            entity.HasKey(e => new { e.CardInteNo, e.DoorGroup }).HasName("PK_AccessMultiDoorGroup_1");

            entity.ToTable("AccessMultiDoorGroup");

            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.DoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Door_group");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccessPalmSecureDatum>(entity =>
        {
            entity.HasKey(e => e.CardInteNo);

            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.PsData).HasColumnName("PS_data");
        });

        modelBuilder.Entity<AccessPalmSecureDevice>(entity =>
        {
            entity.HasKey(e => e.PalmSecureDesc).HasName("PK_AccessPalmSecure");

            entity.ToTable("AccessPalmSecureDevice");

            entity.Property(e => e.PalmSecureDesc)
                .HasMaxLength(30)
                .HasColumnName("PalmSecure_desc");
            entity.Property(e => e.CardFormat).HasColumnName("Card_format");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.Fccode).HasColumnName("FCCode");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(25)
                .HasColumnName("Ip_address");
            entity.Property(e => e.IpPort).HasColumnName("Ip_port");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<AccessPanelMonitorParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.UserId });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
        });

        modelBuilder.Entity<AccessQrcode>(entity =>
        {
            entity.HasKey(e => e.QrCodeDesc);

            entity.ToTable("AccessQRCode");

            entity.Property(e => e.QrCodeDesc)
                .HasMaxLength(30)
                .HasColumnName("QR_Code_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(15)
                .HasColumnName("Ip_address");
            entity.Property(e => e.IpPort).HasColumnName("Ip_port");
            entity.Property(e => e.LimitType)
                .HasDefaultValue(1)
                .HasColumnName("Limit_type");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.ReaderType)
                .HasDefaultValue(1)
                .HasColumnName("Reader_type");
        });

        modelBuilder.Entity<AccessReaderDisplayTimezone>(entity =>
        {
            entity.HasKey(e => new { e.LineNum, e.ReaderId }).HasName("PK_AccessReaderDisplayTimezone_1");

            entity.ToTable("AccessReaderDisplayTimezone");

            entity.Property(e => e.LineNum).HasColumnName("Line_num");
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
            entity.Property(e => e.Fri1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri1_display_text");
            entity.Property(e => e.Fri1From)
                .HasMaxLength(4)
                .HasColumnName("Fri1_from");
            entity.Property(e => e.Fri1To)
                .HasMaxLength(4)
                .HasColumnName("Fri1_to");
            entity.Property(e => e.Fri2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri2_display_text");
            entity.Property(e => e.Fri2From)
                .HasMaxLength(4)
                .HasColumnName("Fri2_from");
            entity.Property(e => e.Fri2To)
                .HasMaxLength(4)
                .HasColumnName("Fri2_to");
            entity.Property(e => e.Fri3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri3_display_text");
            entity.Property(e => e.Fri3From)
                .HasMaxLength(4)
                .HasColumnName("Fri3_from");
            entity.Property(e => e.Fri3To)
                .HasMaxLength(4)
                .HasColumnName("Fri3_to");
            entity.Property(e => e.Fri4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Fri4_display_text");
            entity.Property(e => e.Fri4From)
                .HasMaxLength(4)
                .HasColumnName("Fri4_from");
            entity.Property(e => e.Fri4To)
                .HasMaxLength(4)
                .HasColumnName("Fri4_to");
            entity.Property(e => e.Hol1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol1_display_text");
            entity.Property(e => e.Hol1From)
                .HasMaxLength(4)
                .HasColumnName("Hol1_from");
            entity.Property(e => e.Hol1To)
                .HasMaxLength(4)
                .HasColumnName("Hol1_to");
            entity.Property(e => e.Hol2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol2_display_text");
            entity.Property(e => e.Hol2From)
                .HasMaxLength(4)
                .HasColumnName("Hol2_from");
            entity.Property(e => e.Hol2To)
                .HasMaxLength(4)
                .HasColumnName("Hol2_to");
            entity.Property(e => e.Hol3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol3_display_text");
            entity.Property(e => e.Hol3From)
                .HasMaxLength(4)
                .HasColumnName("Hol3_from");
            entity.Property(e => e.Hol3To)
                .HasMaxLength(4)
                .HasColumnName("Hol3_to");
            entity.Property(e => e.Hol4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Hol4_display_text");
            entity.Property(e => e.Hol4From)
                .HasMaxLength(4)
                .HasColumnName("Hol4_from");
            entity.Property(e => e.Hol4To)
                .HasMaxLength(4)
                .HasColumnName("Hol4_to");
            entity.Property(e => e.Mon1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon1_display_text");
            entity.Property(e => e.Mon1From)
                .HasMaxLength(4)
                .HasColumnName("Mon1_from");
            entity.Property(e => e.Mon1To)
                .HasMaxLength(4)
                .HasColumnName("Mon1_to");
            entity.Property(e => e.Mon2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon2_display_text");
            entity.Property(e => e.Mon2From)
                .HasMaxLength(4)
                .HasColumnName("Mon2_from");
            entity.Property(e => e.Mon2To)
                .HasMaxLength(4)
                .HasColumnName("Mon2_to");
            entity.Property(e => e.Mon3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon3_display_text");
            entity.Property(e => e.Mon3From)
                .HasMaxLength(4)
                .HasColumnName("Mon3_from");
            entity.Property(e => e.Mon3To)
                .HasMaxLength(4)
                .HasColumnName("Mon3_to");
            entity.Property(e => e.Mon4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Mon4_display_text");
            entity.Property(e => e.Mon4From)
                .HasMaxLength(4)
                .HasColumnName("Mon4_from");
            entity.Property(e => e.Mon4To)
                .HasMaxLength(4)
                .HasColumnName("Mon4_to");
            entity.Property(e => e.Sat1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat1_display_text");
            entity.Property(e => e.Sat1From)
                .HasMaxLength(4)
                .HasColumnName("Sat1_from");
            entity.Property(e => e.Sat1To)
                .HasMaxLength(4)
                .HasColumnName("Sat1_to");
            entity.Property(e => e.Sat2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat2_display_text");
            entity.Property(e => e.Sat2From)
                .HasMaxLength(4)
                .HasColumnName("Sat2_from");
            entity.Property(e => e.Sat2To)
                .HasMaxLength(4)
                .HasColumnName("Sat2_to");
            entity.Property(e => e.Sat3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat3_display_text");
            entity.Property(e => e.Sat3From)
                .HasMaxLength(4)
                .HasColumnName("Sat3_from");
            entity.Property(e => e.Sat3To)
                .HasMaxLength(4)
                .HasColumnName("Sat3_to");
            entity.Property(e => e.Sat4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sat4_display_text");
            entity.Property(e => e.Sat4From)
                .HasMaxLength(4)
                .HasColumnName("Sat4_from");
            entity.Property(e => e.Sat4To)
                .HasMaxLength(4)
                .HasColumnName("Sat4_to");
            entity.Property(e => e.Sun1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun1_display_text");
            entity.Property(e => e.Sun1From)
                .HasMaxLength(4)
                .HasColumnName("Sun1_from");
            entity.Property(e => e.Sun1To)
                .HasMaxLength(4)
                .HasColumnName("Sun1_to");
            entity.Property(e => e.Sun2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun2_display_text");
            entity.Property(e => e.Sun2From)
                .HasMaxLength(4)
                .HasColumnName("Sun2_from");
            entity.Property(e => e.Sun2To)
                .HasMaxLength(4)
                .HasColumnName("Sun2_to");
            entity.Property(e => e.Sun3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun3_display_text");
            entity.Property(e => e.Sun3From)
                .HasMaxLength(4)
                .HasColumnName("Sun3_from");
            entity.Property(e => e.Sun3To)
                .HasMaxLength(4)
                .HasColumnName("Sun3_to");
            entity.Property(e => e.Sun4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Sun4_display_text");
            entity.Property(e => e.Sun4From)
                .HasMaxLength(4)
                .HasColumnName("Sun4_from");
            entity.Property(e => e.Sun4To)
                .HasMaxLength(4)
                .HasColumnName("Sun4_to");
            entity.Property(e => e.Thu1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu1_display_text");
            entity.Property(e => e.Thu1From)
                .HasMaxLength(4)
                .HasColumnName("Thu1_from");
            entity.Property(e => e.Thu1To)
                .HasMaxLength(4)
                .HasColumnName("Thu1_to");
            entity.Property(e => e.Thu2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu2_display_text");
            entity.Property(e => e.Thu2From)
                .HasMaxLength(4)
                .HasColumnName("Thu2_from");
            entity.Property(e => e.Thu2To)
                .HasMaxLength(4)
                .HasColumnName("Thu2_to");
            entity.Property(e => e.Thu3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu3_display_text");
            entity.Property(e => e.Thu3From)
                .HasMaxLength(4)
                .HasColumnName("Thu3_from");
            entity.Property(e => e.Thu3To)
                .HasMaxLength(4)
                .HasColumnName("Thu3_to");
            entity.Property(e => e.Thu4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Thu4_display_text");
            entity.Property(e => e.Thu4From)
                .HasMaxLength(4)
                .HasColumnName("Thu4_from");
            entity.Property(e => e.Thu4To)
                .HasMaxLength(4)
                .HasColumnName("Thu4_to");
            entity.Property(e => e.Tue1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue1_display_text");
            entity.Property(e => e.Tue1From)
                .HasMaxLength(4)
                .HasColumnName("Tue1_from");
            entity.Property(e => e.Tue1To)
                .HasMaxLength(4)
                .HasColumnName("Tue1_to");
            entity.Property(e => e.Tue2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue2_display_text");
            entity.Property(e => e.Tue2From)
                .HasMaxLength(4)
                .HasColumnName("Tue2_from");
            entity.Property(e => e.Tue2To)
                .HasMaxLength(4)
                .HasColumnName("Tue2_to");
            entity.Property(e => e.Tue3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue3_display_text");
            entity.Property(e => e.Tue3From)
                .HasMaxLength(4)
                .HasColumnName("Tue3_from");
            entity.Property(e => e.Tue3To)
                .HasMaxLength(4)
                .HasColumnName("Tue3_to");
            entity.Property(e => e.Tue4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Tue4_display_text");
            entity.Property(e => e.Tue4From)
                .HasMaxLength(4)
                .HasColumnName("Tue4_from");
            entity.Property(e => e.Tue4To)
                .HasMaxLength(4)
                .HasColumnName("Tue4_to");
            entity.Property(e => e.Wed1DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed1_display_text");
            entity.Property(e => e.Wed1From)
                .HasMaxLength(4)
                .HasColumnName("Wed1_from");
            entity.Property(e => e.Wed1To)
                .HasMaxLength(4)
                .HasColumnName("Wed1_to");
            entity.Property(e => e.Wed2DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed2_display_text");
            entity.Property(e => e.Wed2From)
                .HasMaxLength(4)
                .HasColumnName("Wed2_from");
            entity.Property(e => e.Wed2To)
                .HasMaxLength(4)
                .HasColumnName("Wed2_to");
            entity.Property(e => e.Wed3DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed3_display_text");
            entity.Property(e => e.Wed3From)
                .HasMaxLength(4)
                .HasColumnName("Wed3_from");
            entity.Property(e => e.Wed3To)
                .HasMaxLength(4)
                .HasColumnName("Wed3_to");
            entity.Property(e => e.Wed4DisplayText)
                .HasMaxLength(96)
                .HasColumnName("Wed4_display_text");
            entity.Property(e => e.Wed4From)
                .HasMaxLength(4)
                .HasColumnName("Wed4_from");
            entity.Property(e => e.Wed4To)
                .HasMaxLength(4)
                .HasColumnName("Wed4_to");
        });

        modelBuilder.Entity<AccessReaderIddiction>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.ToTable("AccessReaderIDDiction");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.Desc0).HasMaxLength(50);
            entity.Property(e => e.Desc1).HasMaxLength(50);
            entity.Property(e => e.Desc2).HasMaxLength(50);
            entity.Property(e => e.Desc3).HasMaxLength(50);
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
        });

        modelBuilder.Entity<AccessReaderParameter>(entity =>
        {
            entity.HasKey(e => e.Recno).HasName("PK_AccessReaderParameter");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.AccessDeniedStatus).HasColumnName("Access_denied_status");
            entity.Property(e => e.AccessGrantedStatus).HasColumnName("Access_granted_status");
            entity.Property(e => e.Baudrate).HasColumnName("baudrate");
            entity.Property(e => e.BuzzerTime).HasColumnName("Buzzer_time");
            entity.Property(e => e.CardBits).HasColumnName("Card_bits");
            entity.Property(e => e.CardIdLength).HasColumnName("Card_id_length");
            entity.Property(e => e.CardIdPos).HasColumnName("Card_id_pos");
            entity.Property(e => e.CardKeyData)
                .HasMaxLength(32)
                .HasColumnName("Card_key_data");
            entity.Property(e => e.CardKeyType).HasColumnName("Card_key_type");
            entity.Property(e => e.CardNoBlock).HasColumnName("Card_no_block");
            entity.Property(e => e.CardNoLength).HasColumnName("Card_no_length");
            entity.Property(e => e.CardNoPosStart).HasColumnName("Card_no_pos_start");
            entity.Property(e => e.CardNoSector).HasColumnName("Card_no_sector");
            entity.Property(e => e.CardSiteEnable).HasColumnName("Card_site_enable");
            entity.Property(e => e.CardType).HasColumnName("Card_type");
            entity.Property(e => e.CloseBuzzerTime).HasColumnName("Close_buzzer_time");
            entity.Property(e => e.CloseTwinkleTime).HasColumnName("Close_twinkle_time");
            entity.Property(e => e.CsnReserve).HasColumnName("CSN_reserve");
            entity.Property(e => e.DeniedBuzzerCount).HasColumnName("Denied_buzzer_count");
            entity.Property(e => e.DeniedTwinkleCount).HasColumnName("Denied_twinkle_count");
            entity.Property(e => e.DisplayCardNoEnable).HasColumnName("Display_card_no_enable");
            entity.Property(e => e.DisplayDateFormat).HasColumnName("Display_date_format");
            entity.Property(e => e.DisplayFcCodeEnable).HasColumnName("Display_fc_code_enable");
            entity.Property(e => e.DisplayFormatHex).HasColumnName("Display_format_hex");
            entity.Property(e => e.EvenEnable).HasColumnName("Even_enable");
            entity.Property(e => e.EvenPLength).HasColumnName("Even_p_length");
            entity.Property(e => e.EvenPPos).HasColumnName("Even_p_pos");
            entity.Property(e => e.EvenPStart).HasColumnName("Even_p_start");
            entity.Property(e => e.GrantedBuzzerCount).HasColumnName("Granted_buzzer_count");
            entity.Property(e => e.GrantedTwinkleCount).HasColumnName("Granted_twinkle_count");
            entity.Property(e => e.InMsgAccept)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_accept");
            entity.Property(e => e.InMsgIdle)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_idle");
            entity.Property(e => e.InMsgLog)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_log");
            entity.Property(e => e.InMsgReject)
                .HasMaxLength(100)
                .HasColumnName("In_Msg_reject");
            entity.Property(e => e.InReaderBluetoothEnable).HasColumnName("InReader_bluetooth_enable");
            entity.Property(e => e.LcdContrast).HasColumnName("LCD_contrast");
            entity.Property(e => e.LeadingZeroEnable).HasColumnName("Leading_zero_enable");
            entity.Property(e => e.LightingDelayTime).HasColumnName("Lighting_delay_time");
            entity.Property(e => e.MsgTimeout).HasColumnName("Msg_timeout");
            entity.Property(e => e.NormalStatus).HasColumnName("Normal_status");
            entity.Property(e => e.OddEnable).HasColumnName("Odd_enable");
            entity.Property(e => e.OddPLength).HasColumnName("Odd_p_length");
            entity.Property(e => e.OddPPos).HasColumnName("Odd_p_pos");
            entity.Property(e => e.OddPStart).HasColumnName("Odd_p_start");
            entity.Property(e => e.OutMsgAccept)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_accept");
            entity.Property(e => e.OutMsgIdle)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_idle");
            entity.Property(e => e.OutMsgLog)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_log");
            entity.Property(e => e.OutMsgReject)
                .HasMaxLength(100)
                .HasColumnName("Out_Msg_reject");
            entity.Property(e => e.OutReaderBluetoothEnable).HasColumnName("OutReader_bluetooth_enable");
            entity.Property(e => e.PasswordInputMode).HasColumnName("Password_input_mode");
            entity.Property(e => e.ReadCardType).HasColumnName("Read_card_type");
            entity.Property(e => e.ReaderCommKey)
                .HasMaxLength(48)
                .HasColumnName("Reader_comm_key");
            entity.Property(e => e.SiteCode1).HasColumnName("Site_code1");
            entity.Property(e => e.SiteCode2).HasColumnName("Site_code2");
            entity.Property(e => e.SiteCode3).HasColumnName("Site_code3");
            entity.Property(e => e.SiteLength).HasColumnName("Site_length");
            entity.Property(e => e.SitePos).HasColumnName("Site_pos");
        });

        modelBuilder.Entity<AccessRecTypeDiction>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.ToTable("AccessRecTypeDiction");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.English).HasMaxLength(50);
            entity.Property(e => e.Other).HasMaxLength(50);
            entity.Property(e => e.RecType)
                .HasMaxLength(1)
                .HasColumnName("Rec_Type");
            entity.Property(e => e.SimplifiedChinese)
                .HasMaxLength(50)
                .HasColumnName("Simplified_Chinese");
            entity.Property(e => e.TraditionalChinese)
                .HasMaxLength(50)
                .HasColumnName("Traditional_Chinese");
        });

        modelBuilder.Entity<AccessRight>(entity =>
        {
            entity.HasKey(e => e.CardExtNo).HasName("PK__AccessRi__BD617C85EC1EAAE9");

            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.DoorGroup).HasColumnName("Door_group");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective_date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_date");
            entity.Property(e => e.GroupType).HasColumnName("Group_type");
            entity.Property(e => e.GuidId)
                .HasMaxLength(50)
                .HasColumnName("Guid_id");
            entity.Property(e => e.Password).HasMaxLength(4);
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccessSpecialRightGroup>(entity =>
        {
            entity.HasKey(e => e.SpecialRightGroup);

            entity.ToTable("AccessSpecialRightGroup");

            entity.Property(e => e.SpecialRightGroup)
                .HasMaxLength(50)
                .HasColumnName("Special_right_group");
        });

        modelBuilder.Entity<AccessSpecialRightGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.SpecialRightGroup, e.EmpNo });

            entity.ToTable("AccessSpecialRightGroupDetail");

            entity.Property(e => e.SpecialRightGroup)
                .HasMaxLength(50)
                .HasColumnName("Special_right_group");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(20)
                .HasColumnName("Emp_no");
        });

        modelBuilder.Entity<AccessThermalParam>(entity =>
        {
            entity.HasKey(e => e.DeviceId);

            entity.Property(e => e.DeviceId)
                .HasMaxLength(30)
                .HasColumnName("Device_id");
            entity.Property(e => e.AccessGrantedOutput).HasColumnName("Access_granted_output");
            entity.Property(e => e.AccessGrantedOutputRelayTime).HasColumnName("Access_granted_output_relay_time");
            entity.Property(e => e.AntiPassbackEnable).HasColumnName("Anti_passback_enable");
            entity.Property(e => e.CardnoRetryTime).HasColumnName("Cardno_retry_time");
            entity.Property(e => e.CheckMaskInput1).HasColumnName("CheckMask_Input1");
            entity.Property(e => e.CheckMaskInterval).HasColumnName("Check_mask_interval");
            entity.Property(e => e.CheckTemperatureInterval).HasColumnName("Check_temperature_interval");
            entity.Property(e => e.DeviceOk).HasColumnName("Device_ok");
            entity.Property(e => e.FaceId).HasColumnName("Face_id");
            entity.Property(e => e.FaceIpAddress)
                .HasMaxLength(25)
                .HasColumnName("Face_ip_address");
            entity.Property(e => e.FaceIpPort).HasColumnName("Face_ip_port");
            entity.Property(e => e.HighTemperatureStatus).HasColumnName("High_temperature_status");
            entity.Property(e => e.HighTemperatureTimeout).HasColumnName("High_temperature_timeout");
            entity.Property(e => e.IsAutoRestartPc).HasColumnName("IsAutoRestartPC");
            entity.Property(e => e.LocalDirection)
                .HasMaxLength(1)
                .HasColumnName("Local_direction");
            entity.Property(e => e.LocalZone).HasColumnName("Local_zone");
            entity.Property(e => e.NormalTemperatureStatus).HasColumnName("Normal_temperature_status");
            entity.Property(e => e.NormalTemperatureTimeout).HasColumnName("Normal_temperature_timeout");
            entity.Property(e => e.PanelIpAddress)
                .HasMaxLength(25)
                .HasColumnName("Panel_ip_address");
            entity.Property(e => e.PanelIpPort).HasColumnName("Panel_ip_port");
            entity.Property(e => e.PanelType).HasColumnName("Panel_type");
            entity.Property(e => e.PcIpAddress)
                .HasMaxLength(25)
                .HasColumnName("PC_ip_address");
            entity.Property(e => e.PcIpPort).HasColumnName("PC_ip_port");
            entity.Property(e => e.PcautoRestartTimeout).HasColumnName("PCAutoRestartTimeout");
            entity.Property(e => e.ReadyStatus).HasColumnName("Ready_status");
            entity.Property(e => e.Relay1Enable).HasColumnName("Relay1_enable");
            entity.Property(e => e.Relay1ReleaseTime).HasColumnName("Relay1_release_time");
            entity.Property(e => e.Relay2Enable).HasColumnName("Relay2_enable");
            entity.Property(e => e.Relay2ReleaseTime).HasColumnName("Relay2_release_time");
            entity.Property(e => e.Relay3Enable).HasColumnName("Relay3_enable");
            entity.Property(e => e.Relay3ReleaseTime).HasColumnName("Relay3_release_time");
            entity.Property(e => e.Relay4Enable).HasColumnName("Relay4_enable");
            entity.Property(e => e.Relay4ReleaseTime).HasColumnName("Relay4_release_time");
            entity.Property(e => e.TemperatureHigh).HasColumnName("Temperature_high");
            entity.Property(e => e.TemperatureLow).HasColumnName("Temperature_low");
            entity.Property(e => e.TerminalId).HasColumnName("Terminal_id");
            entity.Property(e => e.Tower).HasMaxLength(20);
        });

        modelBuilder.Entity<AttendanceDayReport>(entity =>
        {
            entity.HasKey(e => new { e.AttnDate, e.CardholderId });

            entity.ToTable("AttendanceDayReport");

            entity.Property(e => e.AttnDate)
                .HasColumnType("datetime")
                .HasColumnName("Attn_date");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.AttnStatus)
                .HasMaxLength(1)
                .HasColumnName("Attn_status");
            entity.Property(e => e.AttnStatus0).HasColumnName("Attn_status0");
            entity.Property(e => e.AttnStatus1).HasColumnName("Attn_status1");
            entity.Property(e => e.AttnStatus2).HasColumnName("Attn_status2");
            entity.Property(e => e.AttnStatus3).HasColumnName("Attn_status3");
            entity.Property(e => e.AttnStatus4).HasColumnName("Attn_status4");
            entity.Property(e => e.AttnStatus5).HasColumnName("Attn_status5");
            entity.Property(e => e.AttnStatus6).HasColumnName("Attn_status6");
            entity.Property(e => e.AttnStatus7).HasColumnName("Attn_status7");
            entity.Property(e => e.AttnStatus8).HasColumnName("Attn_status8");
            entity.Property(e => e.BookOff)
                .HasColumnType("datetime")
                .HasColumnName("Book_off");
            entity.Property(e => e.BookOn)
                .HasColumnType("datetime")
                .HasColumnName("Book_on");
            entity.Property(e => e.EarlyLeave).HasColumnName("Early_leave");
            entity.Property(e => e.EarlyReach).HasColumnName("Early_reach");
            entity.Property(e => e.LeaveEnd)
                .HasColumnType("datetime")
                .HasColumnName("Leave_end");
            entity.Property(e => e.LeaveHrs).HasColumnName("Leave_hrs");
            entity.Property(e => e.LeaveStart)
                .HasColumnType("datetime")
                .HasColumnName("Leave_start");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(35)
                .HasColumnName("Leave_type");
            entity.Property(e => e.LunchEnd)
                .HasColumnType("datetime")
                .HasColumnName("Lunch_end");
            entity.Property(e => e.LunchStart)
                .HasColumnType("datetime")
                .HasColumnName("Lunch_start");
            entity.Property(e => e.Ot1Hrs).HasColumnName("OT1_hrs");
            entity.Property(e => e.Ot2Hrs).HasColumnName("OT2_hrs");
            entity.Property(e => e.OtEnd)
                .HasColumnType("datetime")
                .HasColumnName("OT_end");
            entity.Property(e => e.OtHrs).HasColumnName("OT_hrs");
            entity.Property(e => e.OtStart)
                .HasColumnType("datetime")
                .HasColumnName("OT_start");
            entity.Property(e => e.OtType).HasColumnName("OT_type");
            entity.Property(e => e.Shift).HasMaxLength(20);
            entity.Property(e => e.ShiftHrs).HasColumnName("Shift_hrs");
            entity.Property(e => e.WorkHrs).HasColumnName("Work_hrs");
        });

        modelBuilder.Entity<AttendanceEmailInfo>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.ToTable("AttendanceEmailInfo");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.EmailLoginName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(10);
            entity.Property(e => e.Smtpserver).HasMaxLength(30);
        });

        modelBuilder.Entity<AttendanceEmailManager>(entity =>
        {
            entity.HasKey(e => e.Recno).HasName("PK_AttendanceMangerEmail");

            entity.ToTable("AttendanceEmailManager");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
        });

        modelBuilder.Entity<AttendanceEmailSendInfo>(entity =>
        {
            entity.HasKey(e => new { e.ManagerNo, e.CardholderId });

            entity.ToTable("AttendanceEmailSendInfo");

            entity.Property(e => e.ManagerNo)
                .HasMaxLength(20)
                .HasColumnName("Manager_no");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
        });

        modelBuilder.Entity<AttendanceLeaveRecord>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.EndDt)
                .HasColumnType("datetime")
                .HasColumnName("End_dt");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(20)
                .HasColumnName("Leave_type");
            entity.Property(e => e.StartDt)
                .HasColumnType("datetime")
                .HasColumnName("Start_dt");
        });

        modelBuilder.Entity<AttendanceLeaveType>(entity =>
        {
            entity.HasKey(e => e.LeaveType).HasName("PK_AttendanceLeave");

            entity.ToTable("AttendanceLeaveType");

            entity.Property(e => e.LeaveType)
                .HasMaxLength(20)
                .HasColumnName("Leave_type");
        });

        modelBuilder.Entity<AttendanceManualRecord>(entity =>
        {
            entity.HasKey(e => new { e.CardholderId, e.AttnDate }).HasName("PK_AttendanceManualRec");

            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.AttnDate)
                .HasColumnType("datetime")
                .HasColumnName("Attn_date");
            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.BookOff)
                .HasColumnType("datetime")
                .HasColumnName("Book_off");
            entity.Property(e => e.BookOn)
                .HasColumnType("datetime")
                .HasColumnName("Book_on");
            entity.Property(e => e.LunchEnd)
                .HasColumnType("datetime")
                .HasColumnName("Lunch_end");
            entity.Property(e => e.LunchStart)
                .HasColumnType("datetime")
                .HasColumnName("Lunch_start");
            entity.Property(e => e.Reason).HasMaxLength(20);
        });

        modelBuilder.Entity<AttendanceRecordsTemp>(entity =>
        {
            entity.HasKey(e => new { e.CardholderId, e.AttnDate });

            entity.ToTable("AttendanceRecordsTemp");

            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.AttnDate)
                .HasColumnType("datetime")
                .HasColumnName("Attn_date");
        });

        modelBuilder.Entity<AttendanceRostCode>(entity =>
        {
            entity.HasKey(e => e.RostCode);

            entity.ToTable("AttendanceRostCode");

            entity.Property(e => e.RostCode)
                .HasMaxLength(10)
                .HasColumnName("Rost_code");
            entity.Property(e => e.RostDesc)
                .HasMaxLength(50)
                .HasColumnName("Rost_desc");
        });

        modelBuilder.Entity<AttendanceRoster>(entity =>
        {
            entity.HasKey(e => new { e.GroupType, e.GroupCode, e.YearMonth });

            entity.ToTable("AttendanceRoster");

            entity.Property(e => e.GroupType).HasColumnName("Group_type");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(20)
                .HasColumnName("Group_code");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(8)
                .HasColumnName("Year_month");
            entity.Property(e => e.D01).HasMaxLength(20);
            entity.Property(e => e.D02).HasMaxLength(20);
            entity.Property(e => e.D03).HasMaxLength(20);
            entity.Property(e => e.D04).HasMaxLength(20);
            entity.Property(e => e.D05).HasMaxLength(20);
            entity.Property(e => e.D06).HasMaxLength(20);
            entity.Property(e => e.D07).HasMaxLength(20);
            entity.Property(e => e.D08).HasMaxLength(20);
            entity.Property(e => e.D09).HasMaxLength(20);
            entity.Property(e => e.D10).HasMaxLength(20);
            entity.Property(e => e.D11).HasMaxLength(20);
            entity.Property(e => e.D12).HasMaxLength(20);
            entity.Property(e => e.D13).HasMaxLength(20);
            entity.Property(e => e.D14).HasMaxLength(20);
            entity.Property(e => e.D15).HasMaxLength(20);
            entity.Property(e => e.D16).HasMaxLength(20);
            entity.Property(e => e.D17).HasMaxLength(20);
            entity.Property(e => e.D18).HasMaxLength(20);
            entity.Property(e => e.D19).HasMaxLength(20);
            entity.Property(e => e.D20).HasMaxLength(20);
            entity.Property(e => e.D21).HasMaxLength(20);
            entity.Property(e => e.D22).HasMaxLength(20);
            entity.Property(e => e.D23).HasMaxLength(20);
            entity.Property(e => e.D24).HasMaxLength(20);
            entity.Property(e => e.D25).HasMaxLength(20);
            entity.Property(e => e.D26).HasMaxLength(20);
            entity.Property(e => e.D27).HasMaxLength(20);
            entity.Property(e => e.D28).HasMaxLength(20);
            entity.Property(e => e.D29).HasMaxLength(20);
            entity.Property(e => e.D30).HasMaxLength(20);
            entity.Property(e => e.D31).HasMaxLength(20);
            entity.Property(e => e.MonthWorkHours).HasColumnName("Month_work_hours");
        });

        modelBuilder.Entity<AttendanceServerCalcDate>(entity =>
        {
            entity.HasKey(e => e.CalcDate);

            entity.ToTable("AttendanceServerCalcDate");

            entity.Property(e => e.CalcDate)
                .HasColumnType("datetime")
                .HasColumnName("Calc_date");
        });

        modelBuilder.Entity<AttendanceShift>(entity =>
        {
            entity.HasKey(e => e.Shift);

            entity.ToTable("AttendanceShift");

            entity.Property(e => e.Shift).HasMaxLength(20);
            entity.Property(e => e.AfterBookoffTime).HasColumnName("After_bookoff_time");
            entity.Property(e => e.AfterOtUnit)
                .HasDefaultValue(1f)
                .HasColumnName("After_ot_unit");
            entity.Property(e => e.BeforeOtUnit)
                .HasDefaultValue(1f)
                .HasColumnName("Before_ot_unit");
            entity.Property(e => e.BookOff)
                .HasColumnType("datetime")
                .HasColumnName("Book_off");
            entity.Property(e => e.BookOffRange).HasColumnName("Book_off_range");
            entity.Property(e => e.BookOn)
                .HasColumnType("datetime")
                .HasColumnName("Book_on");
            entity.Property(e => e.BookOnRange).HasColumnName("Book_on_range");
            entity.Property(e => e.LateExcludeTolerance).HasColumnName("Late_exclude_tolerance");
            entity.Property(e => e.LateTolerance).HasColumnName("Late_tolerance");
            entity.Property(e => e.LunchDiningTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("Lunch_dining_time");
            entity.Property(e => e.LunchEnd)
                .HasColumnType("datetime")
                .HasColumnName("Lunch_end");
            entity.Property(e => e.LunchEndRange).HasColumnName("Lunch_end_range");
            entity.Property(e => e.LunchStart)
                .HasColumnType("datetime")
                .HasColumnName("Lunch_start");
            entity.Property(e => e.LunchStartRange).HasColumnName("Lunch_start_range");
            entity.Property(e => e.OtDeductLate).HasColumnName("OT_deduct_late");
            entity.Property(e => e.OtDiningTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("OT_dining_time");
            entity.Property(e => e.OtEarly).HasColumnName("OT_early");
            entity.Property(e => e.OtEnd).HasColumnName("OT_end");
            entity.Property(e => e.OtIncludeBefore).HasColumnName("OT_include_before");
            entity.Property(e => e.OtStart).HasColumnName("OT_start");
            entity.Property(e => e.OtUnit).HasColumnName("OT_unit");
            entity.Property(e => e.OtherOtUnit)
                .HasDefaultValue(1f)
                .HasColumnName("Other_ot_unit");
            entity.Property(e => e.RestDayOtUnit).HasColumnName("RestDay_ot_unit");
            entity.Property(e => e.ShiftDesc)
                .HasMaxLength(50)
                .HasColumnName("Shift_desc");
            entity.Property(e => e.ShiftType).HasColumnName("Shift_type");
            entity.Property(e => e.WorkHrs)
                .HasColumnType("smalldatetime")
                .HasColumnName("Work_hrs");
        });

        modelBuilder.Entity<BuildingFloorsAuthorityGroup>(entity =>
        {
            entity.HasKey(e => e.FloorsGroup).HasName("PK__FloorsGroup");

            entity.ToTable("BuildingFloorsAuthorityGroup");

            entity.Property(e => e.FloorsGroup)
                .HasMaxLength(20)
                .HasColumnName("Floors_group");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.DefaultFloor).HasColumnName("Default_floor");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BuildingFloorsAuthorityGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.FloorsGroup, e.BuildingCode, e.FloorNumber }).HasName("PK_BuildingFloorsAccessGroupDetail");

            entity.ToTable("BuildingFloorsAuthorityGroupDetail");

            entity.Property(e => e.FloorsGroup)
                .HasMaxLength(20)
                .HasColumnName("Floors_group");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_Number");
            entity.Property(e => e.LiftDoorOpenType).HasDefaultValue((short)1);
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.TzIndex).HasColumnName("Tz_Index");
        });

        modelBuilder.Entity<BuildingFloorsInfo>(entity =>
        {
            entity.HasKey(e => new { e.BuildingCode, e.FloorNumber }).HasName("PK__FloorsInfo");

            entity.ToTable("BuildingFloorsInfo");

            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_Number");
            entity.Property(e => e.FloorDesc)
                .HasMaxLength(50)
                .HasColumnName("Floor_Desc");
            entity.Property(e => e.VisitFloorNumber).HasColumnName("Visit_Floor_Number");
        });

        modelBuilder.Entity<BuildingFloorsUnitInfo>(entity =>
        {
            entity.HasKey(e => new { e.BuildingCode, e.FloorNumber, e.RoomNumber });

            entity.ToTable("BuildingFloorsUnitInfo");

            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.FloorNumber)
                .HasMaxLength(10)
                .HasColumnName("Floor_Number");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(10)
                .HasColumnName("Room_number");
            entity.Property(e => e.DoorGroups).HasColumnName("Door_groups");
            entity.Property(e => e.RoomDesc)
                .HasMaxLength(30)
                .HasColumnName("Room_desc");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BuildingInfo>(entity =>
        {
            entity.HasKey(e => e.BuildingCode);

            entity.ToTable("BuildingInfo");

            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.AccessDoorGroup)
                .HasMaxLength(250)
                .HasColumnName("Access_door_group");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(250)
                .HasColumnName("Building_Name");
            entity.Property(e => e.BuildingNum).HasColumnName("Building_Num");
        });

        modelBuilder.Entity<CardInfo>(entity =>
        {
            entity.HasKey(e => e.CardInteNo);

            entity.ToTable("_CardInfo");

            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.ActCodePassword)
                .HasMaxLength(20)
                .HasColumnName("act_code_password");
            entity.Property(e => e.AntiBackGroup)
                .HasMaxLength(20)
                .HasColumnName("AntiBack_group");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.CardInteNoHex)
                .HasMaxLength(16)
                .HasColumnName("Card_inte_no_hex");
            entity.Property(e => e.CardStatus)
                .HasDefaultValue((short)0)
                .HasColumnName("Card_status");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(30)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective_date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_date");
            entity.Property(e => e.LastInOut).HasColumnName("Last_in_out");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(8);
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.VirtualCardActCode)
                .HasMaxLength(20)
                .HasColumnName("VirtualCard_act_code");
        });

        modelBuilder.Entity<ControlStatusModbu>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<DeviceCardformat>(entity =>
        {
            entity.HasKey(e => new { e.FormatType, e.DeviceId, e.PanelId }).HasName("PK__ReaderOutputCardformat_1");

            entity.ToTable("_DeviceCardformat");

            entity.Property(e => e.FormatType).HasColumnName("Format_type");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.CardBits).HasColumnName("Card_bits");
            entity.Property(e => e.CardFormatEnable).HasColumnName("Card_format_enable");
            entity.Property(e => e.CardIdBitPer).HasColumnName("Card_id_bit_per");
            entity.Property(e => e.CardIdLength).HasColumnName("Card_id_length");
            entity.Property(e => e.CardIdPos).HasColumnName("Card_id_pos");
            entity.Property(e => e.CardSiteEnable).HasColumnName("Card_site_enable");
            entity.Property(e => e.CsnBits).HasColumnName("CSN_bits");
            entity.Property(e => e.CsnParityEnable).HasColumnName("CSN_parity_enable");
            entity.Property(e => e.CsnReserve).HasColumnName("CSN_reserve");
            entity.Property(e => e.EvenEnable).HasColumnName("Even_enable");
            entity.Property(e => e.EvenPLength).HasColumnName("Even_p_length");
            entity.Property(e => e.EvenPPos).HasColumnName("Even_p_pos");
            entity.Property(e => e.EvenPStart).HasColumnName("Even_p_start");
            entity.Property(e => e.OddEnable).HasColumnName("Odd_enable");
            entity.Property(e => e.OddPLength).HasColumnName("Odd_p_length");
            entity.Property(e => e.OddPPos).HasColumnName("Odd_p_pos");
            entity.Property(e => e.OddPStart).HasColumnName("Odd_p_start");
            entity.Property(e => e.SectorFixCardnoEnable).HasColumnName("Sector_fix_cardno_enable");
            entity.Property(e => e.SectorOutputBits).HasColumnName("Sector_output_bits");
            entity.Property(e => e.SectorPraityEnable).HasColumnName("Sector_praity_enable");
            entity.Property(e => e.SiteCode1).HasColumnName("Site_code1");
            entity.Property(e => e.SiteCode2).HasColumnName("Site_code2");
            entity.Property(e => e.SiteCode3).HasColumnName("Site_code3");
            entity.Property(e => e.SiteLength).HasColumnName("Site_length");
            entity.Property(e => e.SitePos).HasColumnName("Site_pos");
        });

        modelBuilder.Entity<DeviceGroupCode>(entity =>
        {
            entity.HasKey(e => e.GroupCode);

            entity.ToTable("_DeviceGroupCode");

            entity.Property(e => e.GroupCode)
                .HasMaxLength(50)
                .HasColumnName("Group_code");
            entity.Property(e => e.GroupDesc)
                .HasMaxLength(50)
                .HasColumnName("Group_desc");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .HasColumnName("ServerIP");
        });

        modelBuilder.Entity<DeviceInfo>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId }).HasName("PK__DeviceInfo_1");

            entity.ToTable("_DeviceInfo", tb =>
                {
                    tb.HasTrigger("Tgr_Add_New_Ctrller");
                    tb.HasTrigger("Tgr_Delete_Ctrller");
                    tb.HasTrigger("Tgr_Update_Ctrller");
                });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.CameraCode1)
                .HasMaxLength(20)
                .HasColumnName("Camera_code1");
            entity.Property(e => e.CameraCode2)
                .HasMaxLength(20)
                .HasColumnName("Camera_code2");
            entity.Property(e => e.CheckInReader).HasMaxLength(30);
            entity.Property(e => e.CheckOutReader).HasMaxLength(30);
            entity.Property(e => e.Clock)
                .HasColumnType("datetime")
                .HasColumnName("_Clock");
            entity.Property(e => e.ComPort).HasColumnName("Com_port");
            entity.Property(e => e.CommType).HasColumnName("Comm_type");
            entity.Property(e => e.CommunicationKey)
                .HasMaxLength(100)
                .HasColumnName("Communication_key");
            entity.Property(e => e.DeviceOk).HasColumnName("Device_ok");
            entity.Property(e => e.DeviceType).HasColumnName("Device_Type");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(50)
                .HasColumnName("Group_code");
            entity.Property(e => e.GuidId)
                .HasMaxLength(50)
                .HasColumnName("Guid_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(15)
                .HasColumnName("Ip_address");
            entity.Property(e => e.IpPort).HasColumnName("Ip_port");
            entity.Property(e => e.IsBmsdevice).HasColumnName("IsBMSDevice");
            entity.Property(e => e.IsVisitDeviceCommonDoor).HasColumnName("IsVisitDevice_CommonDoor");
            entity.Property(e => e.LastInOut).HasColumnName("Last_in_out");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(20)
                .HasColumnName("mac_address");
            entity.Property(e => e.PanelDesc)
                .HasMaxLength(50)
                .HasColumnName("Panel_desc");
            entity.Property(e => e.RandomKey).HasMaxLength(32);
            entity.Property(e => e.Recno)
                .ValueGeneratedOnAdd()
                .HasColumnName("RECNO");
            entity.Property(e => e.SyncDatetime).HasColumnType("datetime");
            entity.Property(e => e.TakeAttandance).HasColumnName("Take_attandance");
            entity.Property(e => e.TcpIpmoduleRebotTime).HasColumnName("TCP_IPModuleRebotTime");
            entity.Property(e => e.TimeDiff).HasColumnName("Time_diff");
            entity.Property(e => e.TurnstileIoType).HasColumnName("Turnstile_IO_Type");
            entity.Property(e => e.UsedType).HasColumnName("Used_type");
            entity.Property(e => e.Version).HasMaxLength(50);
            entity.Property(e => e.VersionType).HasColumnName("Version_type");
            entity.Property(e => e.VisitFloors)
                .HasMaxLength(100)
                .HasColumnName("Visit_floors");
            entity.Property(e => e.WaterLeakageDeviceId)
                .HasMaxLength(20)
                .HasColumnName("WaterLeakage_device_id");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.HasKey(e => e.DeviceType1);

            entity.ToTable("_DeviceType");

            entity.Property(e => e.DeviceType1)
                .ValueGeneratedNever()
                .HasColumnName("Device_Type");
            entity.Property(e => e.English).HasMaxLength(50);
            entity.Property(e => e.Other).HasMaxLength(50);
            entity.Property(e => e.SimplifiedChinese)
                .HasMaxLength(50)
                .HasColumnName("Simplified_Chinese");
            entity.Property(e => e.TraditionalChinese)
                .HasMaxLength(50)
                .HasColumnName("Traditional_Chinese");
            entity.Property(e => e.TypeDesc)
                .HasMaxLength(250)
                .HasColumnName("Type_desc");
        });

        modelBuilder.Entity<ElectronicMapAlarmLog>(entity =>
        {
            entity.HasKey(e => e.Recno);

            entity.ToTable("ElectronicMap_AlarmLog");

            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.AlarmStatus).HasColumnName("alarm_status");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<ElectronicMapBuilding>(entity =>
        {
            entity.HasKey(e => e.BuildingName);

            entity.ToTable("ElectronicMap_Building");

            entity.Property(e => e.BuildingName)
                .HasMaxLength(50)
                .HasColumnName("Building_name");
            entity.Property(e => e.BuildingImage)
                .HasColumnType("image")
                .HasColumnName("Building_image");
        });

        modelBuilder.Entity<ElectronicMapFloor>(entity =>
        {
            entity.HasKey(e => new { e.FloorName, e.BuildingName, e.SubFloorName });

            entity.ToTable("ElectronicMap_Floors");

            entity.Property(e => e.FloorName)
                .HasMaxLength(50)
                .HasColumnName("Floor_name");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(50)
                .HasColumnName("Building_name");
            entity.Property(e => e.SubFloorName)
                .HasMaxLength(50)
                .HasColumnName("SubFloor_name");
            entity.Property(e => e.BgZoomValue).HasColumnName("bg_zoom_value");
            entity.Property(e => e.FloorImage)
                .HasColumnType("image")
                .HasColumnName("Floor_image");
            entity.Property(e => e.ImageZoom)
                .HasDefaultValue(1f)
                .HasColumnName("image_zoom");
        });

        modelBuilder.Entity<ElectronicMapFloorDevice>(entity =>
        {
            entity.HasKey(e => new { e.BuildingName, e.FloorName, e.SubFloorName, e.DeviceId, e.PanelId, e.DeviceType }).HasName("PK_ElectronicMap_FloorDevices_1");

            entity.ToTable("ElectronicMap_FloorDevices");

            entity.Property(e => e.BuildingName)
                .HasMaxLength(50)
                .HasColumnName("Building_name");
            entity.Property(e => e.FloorName)
                .HasMaxLength(50)
                .HasColumnName("Floor_name");
            entity.Property(e => e.SubFloorName)
                .HasMaxLength(50)
                .HasColumnName("SubFloor_name");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.DeviceType).HasColumnName("Device_type");
            entity.Property(e => e.CctvUrl)
                .HasMaxLength(128)
                .HasColumnName("CCTV_URL");
            entity.Property(e => e.LocationX).HasColumnName("Location_X");
            entity.Property(e => e.LocationY).HasColumnName("Location_Y");
        });

        modelBuilder.Entity<Holidate>(entity =>
        {
            entity.HasKey(e => e.Holidate1);

            entity.ToTable("_Holidate");

            entity.Property(e => e.Holidate1)
                .HasMaxLength(30)
                .HasColumnName("Holidate");
            entity.Property(e => e.Holi01).HasColumnType("datetime");
            entity.Property(e => e.Holi02).HasColumnType("datetime");
            entity.Property(e => e.Holi03).HasColumnType("datetime");
            entity.Property(e => e.Holi04).HasColumnType("datetime");
            entity.Property(e => e.Holi05).HasColumnType("datetime");
            entity.Property(e => e.Holi06).HasColumnType("datetime");
            entity.Property(e => e.Holi07).HasColumnType("datetime");
            entity.Property(e => e.Holi08).HasColumnType("datetime");
            entity.Property(e => e.Holi09).HasColumnType("datetime");
            entity.Property(e => e.Holi10).HasColumnType("datetime");
            entity.Property(e => e.Holi11).HasColumnType("datetime");
            entity.Property(e => e.Holi12).HasColumnType("datetime");
            entity.Property(e => e.Holi13).HasColumnType("datetime");
            entity.Property(e => e.Holi14).HasColumnType("datetime");
            entity.Property(e => e.Holi15).HasColumnType("datetime");
            entity.Property(e => e.Holi16).HasColumnType("datetime");
            entity.Property(e => e.Holi17).HasColumnType("datetime");
            entity.Property(e => e.Holi18).HasColumnType("datetime");
            entity.Property(e => e.Holi19).HasColumnType("datetime");
            entity.Property(e => e.Holi20).HasColumnType("datetime");
            entity.Property(e => e.Holi21).HasColumnType("datetime");
            entity.Property(e => e.Holi22).HasColumnType("datetime");
            entity.Property(e => e.Holi23).HasColumnType("datetime");
            entity.Property(e => e.Holi24).HasColumnType("datetime");
            entity.Property(e => e.Holi25).HasColumnType("datetime");
            entity.Property(e => e.Holi26).HasColumnType("datetime");
            entity.Property(e => e.Holi27).HasColumnType("datetime");
            entity.Property(e => e.Holi28).HasColumnType("datetime");
            entity.Property(e => e.Holi29).HasColumnType("datetime");
            entity.Property(e => e.Holi30).HasColumnType("datetime");
        });

        modelBuilder.Entity<HumanCardholder>(entity =>
        {
            entity.HasKey(e => e.CardholderId).HasName("PK_HumanCardholder");

            entity.Property(e => e.CardholderId)
                .HasMaxLength(30)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.Company).HasMaxLength(250);
            entity.Property(e => e.DepaCode)
                .HasMaxLength(50)
                .HasColumnName("Depa_code");
            entity.Property(e => e.DiviCode)
                .HasMaxLength(50)
                .HasColumnName("Divi_code");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .HasColumnName("Email_address");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JoinDate)
                .HasColumnType("datetime")
                .HasColumnName("Join_date");
            entity.Property(e => e.LocalAddress)
                .HasMaxLength(100)
                .HasColumnName("Local_address");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PositionDesc)
                .HasMaxLength(250)
                .HasColumnName("Position_desc");
            entity.Property(e => e.QuitDate)
                .HasColumnType("datetime")
                .HasColumnName("Quit_date");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.TelNo)
                .HasMaxLength(30)
                .HasColumnName("Tel_no");
        });

        modelBuilder.Entity<HumanCardholdersDetail>(entity =>
        {
            entity.HasKey(e => e.CardholderId).HasName("PK_HumanStaffDetail");

            entity.ToTable("HumanCardholdersDetail", tb => tb.HasTrigger("insert_tmpsendSenseLinkServer"));

            entity.Property(e => e.CardholderId)
                .HasMaxLength(30)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.ChnName)
                .HasMaxLength(10)
                .HasColumnName("Chn_name");
            entity.Property(e => e.EmpPhoto1)
                .HasColumnType("image")
                .HasColumnName("Emp_photo1");
            entity.Property(e => e.EmpPhoto2)
                .HasColumnType("image")
                .HasColumnName("Emp_photo2");
            entity.Property(e => e.EnableSendMailForAttendance).HasColumnName("Enable_send_mail_for_attendance");
            entity.Property(e => e.EnableSendMailForRecords).HasColumnName("Enable_send_mail_for_records");
            entity.Property(e => e.FpData1)
                .HasMaxLength(512)
                .HasColumnName("FP_data1");
            entity.Property(e => e.FpData2)
                .HasMaxLength(512)
                .HasColumnName("FP_data2");
            entity.Property(e => e.PsData1).HasColumnName("PS_data1");
            entity.Property(e => e.PsData2).HasColumnName("PS_data2");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HumanCardholdersFloorInfo>(entity =>
        {
            entity.HasKey(e => e.CardholderId);

            entity.ToTable("HumanCardholdersFloorInfo");

            entity.Property(e => e.CardholderId)
                .HasMaxLength(30)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_code");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_number");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(30)
                .HasColumnName("Room_number");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HumanCategory>(entity =>
        {
            entity.HasKey(e => e.Category);

            entity.ToTable("HumanCategory");

            entity.Property(e => e.Category).HasMaxLength(250);
        });

        modelBuilder.Entity<HumanCompany>(entity =>
        {
            entity.HasKey(e => e.Company);

            entity.ToTable("HumanCompany");

            entity.Property(e => e.Company).HasMaxLength(250);
        });

        modelBuilder.Entity<HumanDepartMultiDoorGroup>(entity =>
        {
            entity.HasKey(e => new { e.DepaCode, e.AccessDoorGroup }).HasName("PK_HumanDepartDoorGroups");

            entity.ToTable("HumanDepartMultiDoorGroup");

            entity.Property(e => e.DepaCode)
                .HasMaxLength(20)
                .HasColumnName("Depa_code");
            entity.Property(e => e.AccessDoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Access_door_group");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HumanDepartment>(entity =>
        {
            entity.HasKey(e => e.DepaCode);

            entity.ToTable("HumanDepartment");

            entity.Property(e => e.DepaCode)
                .HasMaxLength(20)
                .HasColumnName("Depa_code");
            entity.Property(e => e.AccessDoorGroup)
                .HasMaxLength(250)
                .HasColumnName("Access_door_group");
            entity.Property(e => e.DepaDesc)
                .HasMaxLength(100)
                .HasColumnName("Depa_desc");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HumanDiviMultiDoorGroup>(entity =>
        {
            entity.HasKey(e => new { e.DiviCode, e.AccessDoorGroup }).HasName("PK_HumanDiviDoorGroups");

            entity.ToTable("HumanDiviMultiDoorGroup");

            entity.Property(e => e.DiviCode)
                .HasMaxLength(20)
                .HasColumnName("Divi_code");
            entity.Property(e => e.AccessDoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Access_door_group");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HumanDivision>(entity =>
        {
            entity.HasKey(e => e.DiviCode).HasName("PK_HumanDivision_1");

            entity.ToTable("HumanDivision");

            entity.Property(e => e.DiviCode)
                .HasMaxLength(10)
                .HasColumnName("Divi_code");
            entity.Property(e => e.AccessDoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Access_door_group");
            entity.Property(e => e.DepaCode)
                .HasMaxLength(20)
                .HasColumnName("Depa_code");
            entity.Property(e => e.DiviDesc)
                .HasMaxLength(50)
                .HasColumnName("Divi_desc");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<IoControllerView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("IO_Controller_View");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.DeviceType).HasColumnName("Device_Type");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(15)
                .HasColumnName("ip_address");
            entity.Property(e => e.IpPort).HasColumnName("ip_port");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(20)
                .HasColumnName("mac_address");
        });

        modelBuilder.Entity<IocontrolParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId });

            entity.ToTable("IOControlParams");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.EnableTimezone)
                .HasDefaultValue(false)
                .HasColumnName("Enable_Timezone");
        });

        modelBuilder.Entity<IoemergencyChannelGroup>(entity =>
        {
            entity.HasKey(e => new { e.AcceptGroupCode, e.DeviceId, e.PanelId, e.IoIndex });

            entity.ToTable("IOEmergencyChannelGroup");

            entity.Property(e => e.AcceptGroupCode)
                .HasMaxLength(10)
                .HasColumnName("Accept_group_code");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.IoIndex).HasColumnName("IO_Index");
        });

        modelBuilder.Entity<IoeventDefinition>(entity =>
        {
            entity.HasKey(e => e.EventType);

            entity.ToTable("IOEventDefinition");

            entity.Property(e => e.EventType)
                .ValueGeneratedNever()
                .HasColumnName("Event_type");
            entity.Property(e => e.EventConfirm).HasColumnName("Event_confirm");
            entity.Property(e => e.EventDesc)
                .HasMaxLength(50)
                .HasColumnName("Event_desc");
            entity.Property(e => e.PlayMusic).HasDefaultValue(false);
            entity.Property(e => e.SendBroadcast).HasColumnName("Send_broadcast");
            entity.Property(e => e.SendMilestone).HasColumnName("Send_milestone");
            entity.Property(e => e.SendSiemens).HasColumnName("Send_Siemens");
            entity.Property(e => e.VideoTrigger).HasColumnName("Video_trigger");
        });

        modelBuilder.Entity<IogroupAccessControl>(entity =>
        {
            entity.HasKey(e => new { e.GroupCode, e.DeviceId, e.PanelId });

            entity.ToTable("IOGroupAccessControl");

            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .HasColumnName("Group_code");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<IogroupCode>(entity =>
        {
            entity.HasKey(e => e.GroupCode);

            entity.ToTable("IOGroupCode");

            entity.Property(e => e.GroupCode)
                .HasMaxLength(10)
                .HasColumnName("Group_code");
            entity.Property(e => e.GroupDesc)
                .HasMaxLength(50)
                .HasColumnName("Group_desc");
            entity.Property(e => e.IoCommand).HasColumnName("IO_command");
            entity.Property(e => e.IoGroupNo).HasColumnName("IO_group_no");
            entity.Property(e => e.IoZone).HasColumnName("IO_zone");
        });

        modelBuilder.Entity<IoinputParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.IoIndex }).HasName("PK_IODescription");

            entity.ToTable("IOInputParams");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.IoIndex).HasColumnName("IO_index");
            entity.Property(e => e.Action).HasDefaultValue((short)0);
            entity.Property(e => e.BroadcastGroupCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Broadcast_group_code");
            entity.Property(e => e.CameraCode1)
                .HasMaxLength(20)
                .HasColumnName("Camera_code1");
            entity.Property(e => e.CameraCode2)
                .HasMaxLength(20)
                .HasColumnName("Camera_code2");
            entity.Property(e => e.EventDt)
                .HasColumnType("datetime")
                .HasColumnName("Event_dt");
            entity.Property(e => e.EventType).HasColumnName("Event_type");
            entity.Property(e => e.InputEvent).HasColumnName("Input_event");
            entity.Property(e => e.IoCode)
                .HasMaxLength(4)
                .HasColumnName("IO_Code");
            entity.Property(e => e.IoDesc)
                .HasMaxLength(50)
                .HasColumnName("IO_desc");
            entity.Property(e => e.IsEnable).HasDefaultValue(false);
            entity.Property(e => e.ModbusPoint).HasColumnName("Modbus_point");
            entity.Property(e => e.NormalStatus)
                .HasDefaultValue((short)1)
                .HasColumnName("Normal_Status");
            entity.Property(e => e.Output1).HasDefaultValue((short)0);
            entity.Property(e => e.Output2).HasDefaultValue((short)0);
            entity.Property(e => e.TzIndex).HasColumnName("Tz_index");
        });

        modelBuilder.Entity<IooutputParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.IoIndex });

            entity.ToTable("IOOutputParams");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.IoIndex).HasColumnName("IO_index");
            entity.Property(e => e.IoCode)
                .HasMaxLength(4)
                .HasColumnName("IO_Code");
            entity.Property(e => e.IoDesc)
                .HasMaxLength(50)
                .HasColumnName("IO_desc");
            entity.Property(e => e.IsEnable).HasDefaultValue(false);
            entity.Property(e => e.OutputType).HasColumnName("Output_type");
        });

        modelBuilder.Entity<Iotimezone>(entity =>
        {
            entity.HasKey(e => e.TzIndex);

            entity.ToTable("IOTimezone");

            entity.Property(e => e.TzIndex)
                .ValueGeneratedNever()
                .HasColumnName("Tz_index");
            entity.Property(e => e.TzDesc)
                .HasMaxLength(30)
                .HasColumnName("Tz_desc");
        });

        modelBuilder.Entity<LiftAccessRight>(entity =>
        {
            entity.HasKey(e => e.CardExtNo).HasName("PK_LiftCardhold");

            entity.ToTable("LiftAccessRight");

            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.CardId).HasColumnName("Card_id");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(30)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.DefaultFloor).HasColumnName("Default_floor");
            entity.Property(e => e.DoorGroup).HasColumnName("Door_group");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective_date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_date");
            entity.Property(e => e.GroupType).HasColumnName("Group_type");
            entity.Property(e => e.PassageType).HasDefaultValue((short)0);
            entity.Property(e => e.Password).HasMaxLength(8);
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LiftControlFloor>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.PortId });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.PortId).HasColumnName("Port_id");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(10)
                .HasColumnName("Building_Code");
            entity.Property(e => e.FloorDesc)
                .HasMaxLength(50)
                .HasColumnName("Floor_Desc");
            entity.Property(e => e.FloorNumber)
                .HasMaxLength(10)
                .HasColumnName("Floor_Number");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
            entity.Property(e => e.TzIndex).HasColumnName("Tz_index");
            entity.Property(e => e.WaitTimes).HasDefaultValue((short)5);
        });

        modelBuilder.Entity<LiftEntryTimezone>(entity =>
        {
            entity.HasKey(e => e.TzIndex);

            entity.ToTable("LiftEntryTimezone");

            entity.Property(e => e.TzIndex)
                .ValueGeneratedNever()
                .HasColumnName("Tz_index");
            entity.Property(e => e.TzDesc)
                .HasMaxLength(30)
                .HasColumnName("Tz_desc");
        });

        modelBuilder.Entity<LiftFinderPanelInfo>(entity =>
        {
            entity.HasKey(e => e.DeviceDesc);

            entity.ToTable("LiftFinderPanelInfo");

            entity.Property(e => e.DeviceDesc)
                .HasMaxLength(30)
                .HasColumnName("Device_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(25)
                .HasColumnName("Ip_address");
            entity.Property(e => e.IpPort).HasColumnName("Ip_port");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.PanelType).HasColumnName("Panel_type");
        });

        modelBuilder.Entity<LiftTimezone>(entity =>
        {
            entity.HasKey(e => e.TzDesc);

            entity.ToTable("LiftTimezone");

            entity.Property(e => e.TzDesc)
                .HasMaxLength(30)
                .HasColumnName("Tz_desc");
            entity.Property(e => e.Fri1From)
                .HasMaxLength(4)
                .HasColumnName("Fri1_from");
            entity.Property(e => e.Fri1To)
                .HasMaxLength(4)
                .HasColumnName("Fri1_to");
            entity.Property(e => e.Fri2From)
                .HasMaxLength(4)
                .HasColumnName("Fri2_from");
            entity.Property(e => e.Fri2To)
                .HasMaxLength(4)
                .HasColumnName("Fri2_to");
            entity.Property(e => e.Fri3From)
                .HasMaxLength(4)
                .HasColumnName("Fri3_from");
            entity.Property(e => e.Fri3To)
                .HasMaxLength(4)
                .HasColumnName("Fri3_to");
            entity.Property(e => e.Fri4From)
                .HasMaxLength(4)
                .HasColumnName("Fri4_from");
            entity.Property(e => e.Fri4To)
                .HasMaxLength(4)
                .HasColumnName("Fri4_to");
            entity.Property(e => e.Hol1From)
                .HasMaxLength(4)
                .HasColumnName("Hol1_from");
            entity.Property(e => e.Hol1To)
                .HasMaxLength(4)
                .HasColumnName("Hol1_to");
            entity.Property(e => e.Hol2From)
                .HasMaxLength(4)
                .HasColumnName("Hol2_from");
            entity.Property(e => e.Hol2To)
                .HasMaxLength(4)
                .HasColumnName("Hol2_to");
            entity.Property(e => e.Hol3From)
                .HasMaxLength(4)
                .HasColumnName("Hol3_from");
            entity.Property(e => e.Hol3To)
                .HasMaxLength(4)
                .HasColumnName("Hol3_to");
            entity.Property(e => e.Hol4From)
                .HasMaxLength(4)
                .HasColumnName("Hol4_from");
            entity.Property(e => e.Hol4To)
                .HasMaxLength(4)
                .HasColumnName("Hol4_to");
            entity.Property(e => e.Mon1From)
                .HasMaxLength(4)
                .HasColumnName("Mon1_from");
            entity.Property(e => e.Mon1To)
                .HasMaxLength(4)
                .HasColumnName("Mon1_to");
            entity.Property(e => e.Mon2From)
                .HasMaxLength(4)
                .HasColumnName("Mon2_from");
            entity.Property(e => e.Mon2To)
                .HasMaxLength(4)
                .HasColumnName("Mon2_to");
            entity.Property(e => e.Mon3From)
                .HasMaxLength(4)
                .HasColumnName("Mon3_from");
            entity.Property(e => e.Mon3To)
                .HasMaxLength(4)
                .HasColumnName("Mon3_to");
            entity.Property(e => e.Mon4From)
                .HasMaxLength(4)
                .HasColumnName("Mon4_from");
            entity.Property(e => e.Mon4To)
                .HasMaxLength(4)
                .HasColumnName("Mon4_to");
            entity.Property(e => e.Sat1From)
                .HasMaxLength(4)
                .HasColumnName("Sat1_from");
            entity.Property(e => e.Sat1To)
                .HasMaxLength(4)
                .HasColumnName("Sat1_to");
            entity.Property(e => e.Sat2From)
                .HasMaxLength(4)
                .HasColumnName("Sat2_from");
            entity.Property(e => e.Sat2To)
                .HasMaxLength(4)
                .HasColumnName("Sat2_to");
            entity.Property(e => e.Sat3From)
                .HasMaxLength(4)
                .HasColumnName("Sat3_from");
            entity.Property(e => e.Sat3To)
                .HasMaxLength(4)
                .HasColumnName("Sat3_to");
            entity.Property(e => e.Sat4From)
                .HasMaxLength(4)
                .HasColumnName("Sat4_from");
            entity.Property(e => e.Sat4To)
                .HasMaxLength(4)
                .HasColumnName("Sat4_to");
            entity.Property(e => e.Sun1From)
                .HasMaxLength(4)
                .HasColumnName("Sun1_from");
            entity.Property(e => e.Sun1To)
                .HasMaxLength(4)
                .HasColumnName("Sun1_to");
            entity.Property(e => e.Sun2From)
                .HasMaxLength(4)
                .HasColumnName("Sun2_from");
            entity.Property(e => e.Sun2To)
                .HasMaxLength(4)
                .HasColumnName("Sun2_to");
            entity.Property(e => e.Sun3From)
                .HasMaxLength(4)
                .HasColumnName("Sun3_from");
            entity.Property(e => e.Sun3To)
                .HasMaxLength(4)
                .HasColumnName("Sun3_to");
            entity.Property(e => e.Sun4From)
                .HasMaxLength(4)
                .HasColumnName("Sun4_from");
            entity.Property(e => e.Sun4To)
                .HasMaxLength(4)
                .HasColumnName("Sun4_to");
            entity.Property(e => e.Thu1From)
                .HasMaxLength(4)
                .HasColumnName("Thu1_from");
            entity.Property(e => e.Thu1To)
                .HasMaxLength(4)
                .HasColumnName("Thu1_to");
            entity.Property(e => e.Thu2From)
                .HasMaxLength(4)
                .HasColumnName("Thu2_from");
            entity.Property(e => e.Thu2To)
                .HasMaxLength(4)
                .HasColumnName("Thu2_to");
            entity.Property(e => e.Thu3From)
                .HasMaxLength(4)
                .HasColumnName("Thu3_from");
            entity.Property(e => e.Thu3To)
                .HasMaxLength(4)
                .HasColumnName("Thu3_to");
            entity.Property(e => e.Thu4From)
                .HasMaxLength(4)
                .HasColumnName("Thu4_from");
            entity.Property(e => e.Thu4To)
                .HasMaxLength(4)
                .HasColumnName("Thu4_to");
            entity.Property(e => e.Tue1From)
                .HasMaxLength(4)
                .HasColumnName("Tue1_from");
            entity.Property(e => e.Tue1To)
                .HasMaxLength(4)
                .HasColumnName("Tue1_to");
            entity.Property(e => e.Tue2From)
                .HasMaxLength(4)
                .HasColumnName("Tue2_from");
            entity.Property(e => e.Tue2To)
                .HasMaxLength(4)
                .HasColumnName("Tue2_to");
            entity.Property(e => e.Tue3From)
                .HasMaxLength(4)
                .HasColumnName("Tue3_from");
            entity.Property(e => e.Tue3To)
                .HasMaxLength(4)
                .HasColumnName("Tue3_to");
            entity.Property(e => e.Tue4From)
                .HasMaxLength(4)
                .HasColumnName("Tue4_from");
            entity.Property(e => e.Tue4To)
                .HasMaxLength(4)
                .HasColumnName("Tue4_to");
            entity.Property(e => e.Wed1From)
                .HasMaxLength(4)
                .HasColumnName("Wed1_from");
            entity.Property(e => e.Wed1To)
                .HasMaxLength(4)
                .HasColumnName("Wed1_to");
            entity.Property(e => e.Wed2From)
                .HasMaxLength(4)
                .HasColumnName("Wed2_from");
            entity.Property(e => e.Wed2To)
                .HasMaxLength(4)
                .HasColumnName("Wed2_to");
            entity.Property(e => e.Wed3From)
                .HasMaxLength(4)
                .HasColumnName("Wed3_from");
            entity.Property(e => e.Wed3To)
                .HasMaxLength(4)
                .HasColumnName("Wed3_to");
            entity.Property(e => e.Wed4From)
                .HasMaxLength(4)
                .HasColumnName("Wed4_from");
            entity.Property(e => e.Wed4To)
                .HasMaxLength(4)
                .HasColumnName("Wed4_to");
        });

        modelBuilder.Entity<LilfControlParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.EnableTimezone)
                .HasDefaultValue(false)
                .HasColumnName("Enable_Timezone");
            entity.Property(e => e.WaitTime)
                .HasDefaultValue((short)5)
                .HasColumnName("Wait_time");
        });

        modelBuilder.Entity<LoginUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("_LoginUser");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
            entity.Property(e => e.LoginTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Login_time");
        });

        modelBuilder.Entity<MailboxControlParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.PanelId, e.PortId });

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.PortId).HasColumnName("Port_id");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_Number");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(30)
                .HasColumnName("Room_number");
            entity.Property(e => e.TzIndex).HasColumnName("Tz_index");
            entity.Property(e => e.VdpIpAddress)
                .HasMaxLength(20)
                .HasColumnName("vdp_ip_address");
            entity.Property(e => e.WaitTimes).HasDefaultValue((short)5);
        });

        modelBuilder.Entity<ModbusMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ModbusMap");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("Device_id");
            entity.Property(e => e.IoIndex).HasColumnName("IO_Index");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
        });

        modelBuilder.Entity<NistServer>(entity =>
        {
            entity.HasKey(e => e.ServerName);

            entity.ToTable("_NistServer");

            entity.Property(e => e.ServerName).HasMaxLength(128);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(256);
        });

        modelBuilder.Entity<NvrcameraDeviceInfo>(entity =>
        {
            entity.HasKey(e => e.CameraCode).HasName("PK__CameraDeviceInfo");

            entity.ToTable("NVRCameraDeviceInfo");

            entity.Property(e => e.CameraCode)
                .HasMaxLength(20)
                .HasColumnName("Camera_code");
            entity.Property(e => e.CameraDesc)
                .HasMaxLength(50)
                .HasColumnName("Camera_desc");
            entity.Property(e => e.DvrChannel).HasColumnName("DVR_channel");
            entity.Property(e => e.DvrCode)
                .HasMaxLength(20)
                .HasColumnName("DVR_code");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("IP_address");
            entity.Property(e => e.IpPort).HasColumnName("IP_port");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(50)
                .HasColumnName("MAC_address");
            entity.Property(e => e.Password).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
        });

        modelBuilder.Entity<NvrdeviceInfo>(entity =>
        {
            entity.HasKey(e => e.DvrCode).HasName("PK__DVRDeviceInfo");

            entity.ToTable("NVRDeviceInfo");

            entity.Property(e => e.DvrCode)
                .HasMaxLength(20)
                .HasColumnName("DVR_code");
            entity.Property(e => e.DvrDesc)
                .HasMaxLength(250)
                .HasColumnName("DVR_desc");
            entity.Property(e => e.DvrIpAddress)
                .HasMaxLength(50)
                .HasColumnName("DVR_ip_address");
            entity.Property(e => e.DvrIpPort).HasColumnName("DVR_ip_port");
            entity.Property(e => e.DvrType).HasColumnName("DVR_Type");
            entity.Property(e => e.DvrUserId)
                .HasMaxLength(20)
                .HasColumnName("DVR_user_id");
            entity.Property(e => e.DvrUserPassword)
                .HasMaxLength(10)
                .HasColumnName("DVR_user_password");
        });

        modelBuilder.Entity<SysDbprocessing>(entity =>
        {
            entity.ToTable("_SysDBProcessing");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DbbackupPath).HasColumnName("DBBackupPath");
        });

        modelBuilder.Entity<SysEventLog>(entity =>
        {
            entity.ToTable("SysEventLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("Device_id");
            entity.Property(e => e.EventId).HasColumnName("Event_id");
            entity.Property(e => e.OccurTime)
                .HasColumnType("datetime")
                .HasColumnName("Occur_time");
            entity.Property(e => e.RefId)
                .HasMaxLength(20)
                .HasColumnName("Ref_id");
            entity.Property(e => e.ResumeTime)
                .HasColumnType("datetime")
                .HasColumnName("Resume_time");
        });

        modelBuilder.Entity<SysInfo>(entity =>
        {
            entity.HasKey(e => e.SysKey);

            entity.ToTable("_SysInfo", tb =>
                {
                    tb.HasTrigger("Tgr_Delete_CommKey");
                    tb.HasTrigger("Tgr_Update_CommKey");
                    tb.HasTrigger("Tgr_insert_CommKey");
                });

            entity.Property(e => e.SysKey).HasMaxLength(50);
            entity.Property(e => e.Remark).HasColumnType("text");
            entity.Property(e => e.SysValues).HasMaxLength(1024);
        });

        modelBuilder.Entity<TblCommServerCmd>(entity =>
        {
            entity.ToTable("tbl_comm_server_cmd");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddDate)
                .HasColumnType("datetime")
                .HasColumnName("add_date");
            entity.Property(e => e.CommServerCmd)
                .HasMaxLength(50)
                .HasColumnName("comm_server_cmd");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("Device_id");
            entity.Property(e => e.IpAdrss)
                .HasMaxLength(15)
                .HasColumnName("IP_Adrss");
            entity.Property(e => e.IsExecute)
                .HasDefaultValue(false)
                .HasColumnName("is_execute");
            entity.Property(e => e.LinkId)
                .HasMaxLength(64)
                .HasColumnName("Link_id");
            entity.Property(e => e.UpDate)
                .HasColumnType("datetime")
                .HasColumnName("up_date");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<TblSyncCommandLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_sync_command_log");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .HasColumnName("action");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsUpdate)
                .HasDefaultValue(0)
                .HasColumnName("is_update");
            entity.Property(e => e.TableName)
                .HasMaxLength(256)
                .HasColumnName("table_name");
            entity.Property(e => e.UpdDt)
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
        });

        modelBuilder.Entity<TblSyncIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_sync_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Slave)
                .HasMaxLength(50)
                .HasColumnName("slave");
            entity.Property(e => e.SyncIndex).HasColumnName("sync_index");
            entity.Property(e => e.TableName)
                .HasMaxLength(256)
                .HasColumnName("table_name");
        });

        modelBuilder.Entity<TblTmpSendLiftFinderCommand>(entity =>
        {
            entity.ToTable("tbl_tmp_SendLiftFinderCommand");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.Command)
                .HasColumnType("text")
                .HasColumnName("command");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .HasColumnName("device_id");
            entity.Property(e => e.DeviceType).HasColumnName("device_type");
            entity.Property(e => e.SendSuccess).HasColumnName("send_success");
            entity.Property(e => e.UpDt)
                .HasColumnType("datetime")
                .HasColumnName("up_dt");
        });

        modelBuilder.Entity<TenantVisitRecord>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("Add_dt");
            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("Booking_date");
            entity.Property(e => e.BookingFromTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_from_time");
            entity.Property(e => e.BookingToTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_to_time");
            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.Company).HasMaxLength(100);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Email_address");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.GuidId).HasColumnName("Guid_id");
            entity.Property(e => e.HomeId).HasColumnName("Home_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerDepartment)
                .HasMaxLength(100)
                .HasColumnName("Interviewer_department");
            entity.Property(e => e.InterviewerEmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_email_address");
            entity.Property(e => e.InterviewerTelNo)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_tel_no");
            entity.Property(e => e.IsUpdate).HasDefaultValue(false);
            entity.Property(e => e.MeetingRoom).HasColumnType("text");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.QrCode).HasMaxLength(2048);
            entity.Property(e => e.Reception).HasDefaultValue(0);
            entity.Property(e => e.Room).HasMaxLength(10);
            entity.Property(e => e.Sigunature).HasColumnType("image");
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .HasColumnName("Staff_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .HasColumnName("Tel_no");
            entity.Property(e => e.TenantCompany)
                .HasMaxLength(100)
                .HasColumnName("Tenant_company");
            entity.Property(e => e.Tower)
                .HasMaxLength(50)
                .HasColumnName("tower");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.VisitEnterTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Enter_Time");
            entity.Property(e => e.VisitLeaveTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Leave_Time");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor_name");
            entity.Property(e => e.VisitorPhoto)
                .HasColumnType("image")
                .HasColumnName("Visitor_photo");
        });

        modelBuilder.Entity<Timezone>(entity =>
        {
            entity.HasKey(e => e.TzDesc);

            entity.ToTable("_Timezone");

            entity.Property(e => e.TzDesc)
                .HasMaxLength(30)
                .HasColumnName("Tz_desc");
            entity.Property(e => e.Fri1From)
                .HasMaxLength(4)
                .HasColumnName("Fri1_from");
            entity.Property(e => e.Fri1To)
                .HasMaxLength(4)
                .HasColumnName("Fri1_to");
            entity.Property(e => e.Fri2From)
                .HasMaxLength(4)
                .HasColumnName("Fri2_from");
            entity.Property(e => e.Fri2To)
                .HasMaxLength(4)
                .HasColumnName("Fri2_to");
            entity.Property(e => e.Fri3From)
                .HasMaxLength(4)
                .HasColumnName("Fri3_from");
            entity.Property(e => e.Fri3To)
                .HasMaxLength(4)
                .HasColumnName("Fri3_to");
            entity.Property(e => e.Fri4From)
                .HasMaxLength(4)
                .HasColumnName("Fri4_from");
            entity.Property(e => e.Fri4To)
                .HasMaxLength(4)
                .HasColumnName("Fri4_to");
            entity.Property(e => e.Hol1From)
                .HasMaxLength(4)
                .HasColumnName("Hol1_from");
            entity.Property(e => e.Hol1To)
                .HasMaxLength(4)
                .HasColumnName("Hol1_to");
            entity.Property(e => e.Hol2From)
                .HasMaxLength(4)
                .HasColumnName("Hol2_from");
            entity.Property(e => e.Hol2To)
                .HasMaxLength(4)
                .HasColumnName("Hol2_to");
            entity.Property(e => e.Hol3From)
                .HasMaxLength(4)
                .HasColumnName("Hol3_from");
            entity.Property(e => e.Hol3To)
                .HasMaxLength(4)
                .HasColumnName("Hol3_to");
            entity.Property(e => e.Hol4From)
                .HasMaxLength(4)
                .HasColumnName("Hol4_from");
            entity.Property(e => e.Hol4To)
                .HasMaxLength(4)
                .HasColumnName("Hol4_to");
            entity.Property(e => e.Mon1From)
                .HasMaxLength(4)
                .HasColumnName("Mon1_from");
            entity.Property(e => e.Mon1To)
                .HasMaxLength(4)
                .HasColumnName("Mon1_to");
            entity.Property(e => e.Mon2From)
                .HasMaxLength(4)
                .HasColumnName("Mon2_from");
            entity.Property(e => e.Mon2To)
                .HasMaxLength(4)
                .HasColumnName("Mon2_to");
            entity.Property(e => e.Mon3From)
                .HasMaxLength(4)
                .HasColumnName("Mon3_from");
            entity.Property(e => e.Mon3To)
                .HasMaxLength(4)
                .HasColumnName("Mon3_to");
            entity.Property(e => e.Mon4From)
                .HasMaxLength(4)
                .HasColumnName("Mon4_from");
            entity.Property(e => e.Mon4To)
                .HasMaxLength(4)
                .HasColumnName("Mon4_to");
            entity.Property(e => e.Sat1From)
                .HasMaxLength(4)
                .HasColumnName("Sat1_from");
            entity.Property(e => e.Sat1To)
                .HasMaxLength(4)
                .HasColumnName("Sat1_to");
            entity.Property(e => e.Sat2From)
                .HasMaxLength(4)
                .HasColumnName("Sat2_from");
            entity.Property(e => e.Sat2To)
                .HasMaxLength(4)
                .HasColumnName("Sat2_to");
            entity.Property(e => e.Sat3From)
                .HasMaxLength(4)
                .HasColumnName("Sat3_from");
            entity.Property(e => e.Sat3To)
                .HasMaxLength(4)
                .HasColumnName("Sat3_to");
            entity.Property(e => e.Sat4From)
                .HasMaxLength(4)
                .HasColumnName("Sat4_from");
            entity.Property(e => e.Sat4To)
                .HasMaxLength(4)
                .HasColumnName("Sat4_to");
            entity.Property(e => e.Sun1From)
                .HasMaxLength(4)
                .HasColumnName("Sun1_from");
            entity.Property(e => e.Sun1To)
                .HasMaxLength(4)
                .HasColumnName("Sun1_to");
            entity.Property(e => e.Sun2From)
                .HasMaxLength(4)
                .HasColumnName("Sun2_from");
            entity.Property(e => e.Sun2To)
                .HasMaxLength(4)
                .HasColumnName("Sun2_to");
            entity.Property(e => e.Sun3From)
                .HasMaxLength(4)
                .HasColumnName("Sun3_from");
            entity.Property(e => e.Sun3To)
                .HasMaxLength(4)
                .HasColumnName("Sun3_to");
            entity.Property(e => e.Sun4From)
                .HasMaxLength(4)
                .HasColumnName("Sun4_from");
            entity.Property(e => e.Sun4To)
                .HasMaxLength(4)
                .HasColumnName("Sun4_to");
            entity.Property(e => e.Thu1From)
                .HasMaxLength(4)
                .HasColumnName("Thu1_from");
            entity.Property(e => e.Thu1To)
                .HasMaxLength(4)
                .HasColumnName("Thu1_to");
            entity.Property(e => e.Thu2From)
                .HasMaxLength(4)
                .HasColumnName("Thu2_from");
            entity.Property(e => e.Thu2To)
                .HasMaxLength(4)
                .HasColumnName("Thu2_to");
            entity.Property(e => e.Thu3From)
                .HasMaxLength(4)
                .HasColumnName("Thu3_from");
            entity.Property(e => e.Thu3To)
                .HasMaxLength(4)
                .HasColumnName("Thu3_to");
            entity.Property(e => e.Thu4From)
                .HasMaxLength(4)
                .HasColumnName("Thu4_from");
            entity.Property(e => e.Thu4To)
                .HasMaxLength(4)
                .HasColumnName("Thu4_to");
            entity.Property(e => e.Tue1From)
                .HasMaxLength(4)
                .HasColumnName("Tue1_from");
            entity.Property(e => e.Tue1To)
                .HasMaxLength(4)
                .HasColumnName("Tue1_to");
            entity.Property(e => e.Tue2From)
                .HasMaxLength(4)
                .HasColumnName("Tue2_from");
            entity.Property(e => e.Tue2To)
                .HasMaxLength(4)
                .HasColumnName("Tue2_to");
            entity.Property(e => e.Tue3From)
                .HasMaxLength(4)
                .HasColumnName("Tue3_from");
            entity.Property(e => e.Tue3To)
                .HasMaxLength(4)
                .HasColumnName("Tue3_to");
            entity.Property(e => e.Tue4From)
                .HasMaxLength(4)
                .HasColumnName("Tue4_from");
            entity.Property(e => e.Tue4To)
                .HasMaxLength(4)
                .HasColumnName("Tue4_to");
            entity.Property(e => e.Wed1From)
                .HasMaxLength(4)
                .HasColumnName("Wed1_from");
            entity.Property(e => e.Wed1To)
                .HasMaxLength(4)
                .HasColumnName("Wed1_to");
            entity.Property(e => e.Wed2From)
                .HasMaxLength(4)
                .HasColumnName("Wed2_from");
            entity.Property(e => e.Wed2To)
                .HasMaxLength(4)
                .HasColumnName("Wed2_to");
            entity.Property(e => e.Wed3From)
                .HasMaxLength(4)
                .HasColumnName("Wed3_from");
            entity.Property(e => e.Wed3To)
                .HasMaxLength(4)
                .HasColumnName("Wed3_to");
            entity.Property(e => e.Wed4From)
                .HasMaxLength(4)
                .HasColumnName("Wed4_from");
            entity.Property(e => e.Wed4To)
                .HasMaxLength(4)
                .HasColumnName("Wed4_to");
        });

        modelBuilder.Entity<TmpsendSenseLinkServer>(entity =>
        {
            entity.ToTable("tmpsendSenseLinkServer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(50)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.OptType)
                .HasMaxLength(10)
                .HasColumnName("Opt_type");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("_User");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
            entity.Property(e => e.Password).HasMaxLength(10);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .HasColumnName("User_name");

            entity.HasMany(d => d.DepaCodes).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserDepartmentGroup",
                    r => r.HasOne<HumanDepartment>().WithMany()
                        .HasForeignKey("DepaCode")
                        .HasConstraintName("FK__UserDepartmentGroup_HumanDepartment"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__UserDepartmentGroup__User"),
                    j =>
                    {
                        j.HasKey("UserId", "DepaCode");
                        j.ToTable("_UserDepartmentGroup");
                        j.IndexerProperty<string>("UserId")
                            .HasMaxLength(20)
                            .HasColumnName("User_id");
                        j.IndexerProperty<string>("DepaCode")
                            .HasMaxLength(20)
                            .HasColumnName("Depa_code");
                    });
        });

        modelBuilder.Entity<UserCategoryGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Category });

            entity.ToTable("_UserCategoryGroup");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
            entity.Property(e => e.Category).HasMaxLength(250);
        });

        modelBuilder.Entity<UserCtrlGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.DeviceId, e.PanelId });

            entity.ToTable("_UserCtrlGroup");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserCtrlGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserCtrlGroup__User");
        });

        modelBuilder.Entity<UserElectronicMapGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.EventType }).HasName("PK__UserElectronicMap");

            entity.ToTable("_UserElectronicMapGroup");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
            entity.Property(e => e.EventType).HasColumnName("Event_type");
        });

        modelBuilder.Entity<UserFunctionGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FunctionId });

            entity.ToTable("_UserFunctionGroup");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("User_id");
            entity.Property(e => e.FunctionId)
                .HasMaxLength(50)
                .HasColumnName("Function_id");
            entity.Property(e => e.AllowAccess).HasColumnName("Allow_access");
            entity.Property(e => e.AllowAdd).HasColumnName("Allow_add");
            entity.Property(e => e.AllowDelete).HasColumnName("Allow_delete");
            entity.Property(e => e.AllowEdit).HasColumnName("Allow_edit");
            entity.Property(e => e.SubGroup).HasColumnName("Sub_group");

            entity.HasOne(d => d.User).WithMany(p => p.UserFunctionGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserFunctionGroup__User");
        });

        modelBuilder.Entity<ViewAccessEntryRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AccessEntryRecords");

            entity.Property(e => e.AccessDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Access Date Time");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .HasColumnName("Card No.");
            entity.Property(e => e.DoorId)
                .HasMaxLength(15)
                .HasColumnName("Door ID");
            entity.Property(e => e.MemberCodeStaffCode)
                .HasMaxLength(30)
                .HasColumnName("Member Code / Staff Code");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCardStaffInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_card_staff_info");

            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.DepaDesc)
                .HasMaxLength(50)
                .HasColumnName("Depa_desc");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(20)
                .HasColumnName("Emp_no");
            entity.Property(e => e.EmpPhoto)
                .HasColumnType("image")
                .HasColumnName("Emp_photo");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_date");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.PositionDesc)
                .HasMaxLength(30)
                .HasColumnName("Position_desc");
        });

        modelBuilder.Entity<ViewEMail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_e_mail");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.EmailLoginName).HasMaxLength(50);
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.Password).HasMaxLength(10);
            entity.Property(e => e.SenderMail)
                .HasMaxLength(50)
                .HasColumnName("Sender_mail");
            entity.Property(e => e.Smtpserver).HasMaxLength(30);
        });

        modelBuilder.Entity<ViewVisitorAccessRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_VisitorAccessRecords");

            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("Add_dt");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.CardInteNoHex)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no_hex");
            entity.Property(e => e.CardholderId)
                .HasMaxLength(20)
                .HasColumnName("Cardholder_id");
            entity.Property(e => e.DepaDesc)
                .HasMaxLength(100)
                .HasColumnName("Depa_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.DeviceType).HasColumnName("Device_type");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.IoStatus).HasColumnName("IO_status");
            entity.Property(e => e.IsMask).HasColumnName("isMask");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
            entity.Property(e => e.RecType).HasColumnName("Rec_type");
            entity.Property(e => e.Recno)
                .ValueGeneratedOnAdd()
                .HasColumnName("RECNO");
        });

        modelBuilder.Entity<ViewVisitorAccessReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_VisitorAccessReport");

            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.EntryDt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Entry_dt");
            entity.Property(e => e.Floor).HasMaxLength(50);
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerTelNo)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_tel_no");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.PersonalId)
                .HasMaxLength(30)
                .HasColumnName("PersonalID");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.TenantCompany)
                .HasMaxLength(100)
                .HasColumnName("Tenant_company");
            entity.Property(e => e.Unit).HasColumnType("text");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor_name");
            entity.Property(e => e.VisitorTelephone)
                .HasMaxLength(20)
                .HasColumnName("Visitor Telephone");
        });

        modelBuilder.Entity<ViewVisitorBooking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_VisitorBooking");

            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.FromTime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("From Time");
            entity.Property(e => e.PersonalId)
                .HasMaxLength(30)
                .HasColumnName(" Personal ID");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.ToTime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("To Time");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor Name");
            entity.Property(e => e.VisitorTelephone)
                .HasMaxLength(20)
                .HasColumnName("Visitor Telephone");
        });

        modelBuilder.Entity<VisionEntryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VisionEntryReport");

            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.CardInteNoHex)
                .HasMaxLength(16)
                .HasColumnName("Card_inte_no_hex");
            entity.Property(e => e.Company).HasMaxLength(100);
            entity.Property(e => e.DepaDesc)
                .HasMaxLength(50)
                .HasColumnName("Depa_desc");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Email_address");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerDepartment)
                .HasMaxLength(100)
                .HasColumnName("Interviewer_department");
            entity.Property(e => e.IoStatus).HasColumnName("IO_status");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
            entity.Property(e => e.RecType)
                .HasMaxLength(1)
                .HasColumnName("Rec_type");
            entity.Property(e => e.Recno).HasColumnName("RECNO");
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .HasColumnName("Tel_no");
            entity.Property(e => e.TenantCompany)
                .HasMaxLength(100)
                .HasColumnName("Tenant_company");
            entity.Property(e => e.Tower)
                .HasMaxLength(50)
                .HasColumnName("tower");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor_name");
        });

        modelBuilder.Entity<VisitCardInfo>(entity =>
        {
            entity.ToTable("VisitCardInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.Company).HasMaxLength(100);
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerDepartment)
                .HasMaxLength(100)
                .HasColumnName("Interviewer_department");
            entity.Property(e => e.PsData).HasColumnName("PS_data");
            entity.Property(e => e.PsData2).HasColumnName("PS_data2");
            entity.Property(e => e.PsUsed).HasColumnName("PS_Used");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.VisitorName)
                .HasMaxLength(50)
                .HasColumnName("Visitor_Name");
        });

        modelBuilder.Entity<VisitRecord>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("Add_dt");
            entity.Property(e => e.AllowedTimes)
                .HasDefaultValue(1)
                .HasColumnName("Allowed_times");
            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("Booking_date");
            entity.Property(e => e.BookingFromTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_from_time");
            entity.Property(e => e.BookingToTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_to_time");
            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.Company).HasMaxLength(100);
            entity.Property(e => e.DestFloor).HasMaxLength(300);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Email_address");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.GuidId).HasColumnName("Guid_id");
            entity.Property(e => e.HomeId)
                .HasMaxLength(50)
                .HasColumnName("Home_id");
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerDepartment)
                .HasMaxLength(100)
                .HasColumnName("Interviewer_department");
            entity.Property(e => e.InterviewerEmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_email_address");
            entity.Property(e => e.InterviewerTelNo)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_tel_no");
            entity.Property(e => e.IsUpdate).HasDefaultValue(false);
            entity.Property(e => e.MeetingRoom).HasColumnType("text");
            entity.Property(e => e.PersonalId)
                .HasMaxLength(30)
                .HasColumnName("PersonalID");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.QrCode).HasMaxLength(2048);
            entity.Property(e => e.Reception).HasDefaultValue(0);
            entity.Property(e => e.Room).HasMaxLength(1000);
            entity.Property(e => e.Sigunature).HasColumnType("image");
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .HasColumnName("Staff_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SystemVersion).HasMaxLength(100);
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .HasColumnName("Tel_no");
            entity.Property(e => e.TenantCompany)
                .HasMaxLength(100)
                .HasColumnName("Tenant_company");
            entity.Property(e => e.Tower)
                .HasMaxLength(50)
                .HasColumnName("tower");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.UsedTimes)
                .HasDefaultValue(0)
                .HasColumnName("Used_times");
            entity.Property(e => e.VisitEnterTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Enter_Time");
            entity.Property(e => e.VisitLeaveTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Leave_Time");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor_name");
            entity.Property(e => e.VisitorPhoto)
                .HasColumnType("image")
                .HasColumnName("Visitor_photo");
        });

        modelBuilder.Entity<VisitorAccessRecord>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Add_dt");
            entity.Property(e => e.BookingDate)
                .HasColumnType("datetime")
                .HasColumnName("Booking_date");
            entity.Property(e => e.BookingFromTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_from_time");
            entity.Property(e => e.BookingToTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_to_time");
            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.Company).HasMaxLength(100);
            entity.Property(e => e.DestFloor).HasMaxLength(50);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(15)
                .HasColumnName("Device_id");
            entity.Property(e => e.DeviceType).HasColumnName("Device_type");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Email_address");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.GuidId).HasColumnName("Guid_id");
            entity.Property(e => e.HomeId)
                .HasMaxLength(50)
                .HasColumnName("Home_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerDepartment)
                .HasMaxLength(100)
                .HasColumnName("Interviewer_department");
            entity.Property(e => e.InterviewerEmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_email_address");
            entity.Property(e => e.InterviewerTelNo)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_tel_no");
            entity.Property(e => e.IoStatus).HasColumnName("IO_status");
            entity.Property(e => e.IsMask).HasColumnName("isMask");
            entity.Property(e => e.IsUpdate).HasDefaultValue(false);
            entity.Property(e => e.MeetingRoom).HasColumnType("text");
            entity.Property(e => e.PanelId).HasColumnName("Panel_id");
            entity.Property(e => e.PersonalId)
                .HasMaxLength(30)
                .HasColumnName("PersonalID");
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.QrCode).HasMaxLength(2048);
            entity.Property(e => e.ReaderId).HasColumnName("Reader_id");
            entity.Property(e => e.Reception).HasDefaultValue(0);
            entity.Property(e => e.Sigunature).HasColumnType("image");
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .HasColumnName("Staff_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .HasColumnName("Tel_no");
            entity.Property(e => e.TenantCompany)
                .HasMaxLength(100)
                .HasColumnName("Tenant_company");
            entity.Property(e => e.Tower)
                .HasMaxLength(50)
                .HasColumnName("tower");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.VisitEnterTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Enter_Time");
            entity.Property(e => e.VisitLeaveTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Leave_Time");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor_name");
            entity.Property(e => e.VisitorPhoto)
                .HasColumnType("image")
                .HasColumnName("Visitor_photo");
        });

        modelBuilder.Entity<VwLiftCtrlCardholderDestFloor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_lift_ctrl_cardholder_dest_floor");

            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("ADD_DT");
            entity.Property(e => e.BuildingCode)
                .HasMaxLength(10)
                .HasColumnName("Building_Code");
            entity.Property(e => e.CardExtNo)
                .HasMaxLength(20)
                .HasColumnName("Card_ext_no");
            entity.Property(e => e.CardId).HasColumnName("Card_id");
            entity.Property(e => e.CardInteNo)
                .HasMaxLength(20)
                .HasColumnName("Card_inte_no");
            entity.Property(e => e.DoorGroup)
                .HasMaxLength(20)
                .HasColumnName("Door_group");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective_date");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(20)
                .HasColumnName("Emp_no");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_date");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_Number");
            entity.Property(e => e.FloorsGroup)
                .HasMaxLength(20)
                .HasColumnName("Floors_group");
            entity.Property(e => e.GroupType).HasColumnName("Group_type");
            entity.Property(e => e.Password).HasMaxLength(4);
            entity.Property(e => e.TzIndex).HasColumnName("Tz_Index");
        });

        modelBuilder.Entity<WaterLeakageControlParam>(entity =>
        {
            entity.HasKey(e => new { e.DeviceId, e.SensorId }).HasName("PK_WaterLeakageControllerParams");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.SensorId)
                .HasMaxLength(20)
                .HasColumnName("Sensor_id");
            entity.Property(e => e.Buzzer).HasMaxLength(50);
            entity.Property(e => e.LedAlarm)
                .HasMaxLength(50)
                .HasColumnName("LED_alarm");
            entity.Property(e => e.SensorInput1)
                .HasMaxLength(50)
                .HasColumnName("Sensor_input1");
            entity.Property(e => e.SensorInput2)
                .HasMaxLength(50)
                .HasColumnName("Sensor_input2");
        });

        modelBuilder.Entity<WaterLeakageDeviceInfo>(entity =>
        {
            entity.HasKey(e => e.DeviceId);

            entity.ToTable("WaterLeakageDeviceInfo");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(20)
                .HasColumnName("Device_id");
            entity.Property(e => e.DeviceDesc)
                .HasMaxLength(50)
                .HasColumnName("Device_desc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BioTimeSQLContext : DbContext
{
    public BioTimeSQLContext()
    {
    }

    public BioTimeSQLContext(DbContextOptions<BioTimeSQLContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccAcccombination> AccAcccombinations { get; set; }

    public virtual DbSet<AccAccgroup> AccAccgroups { get; set; }

    public virtual DbSet<AccAccholiday> AccAccholidays { get; set; }

    public virtual DbSet<AccAccprivilege> AccAccprivileges { get; set; }

    public virtual DbSet<AccAccterminal> AccAccterminals { get; set; }

    public virtual DbSet<AccAcctimezone> AccAcctimezones { get; set; }

    public virtual DbSet<AccountsAdminbiodatum> AccountsAdminbiodata { get; set; }

    public virtual DbSet<AccountsUsersecuritypolicy> AccountsUsersecuritypolicies { get; set; }

    public virtual DbSet<AttAttcalclog> AttAttcalclogs { get; set; }

    public virtual DbSet<AttAttreportsetting> AttAttreportsettings { get; set; }

    public virtual DbSet<AttAttrule> AttAttrules { get; set; }

    public virtual DbSet<AttAttschedule> AttAttschedules { get; set; }

    public virtual DbSet<AttAttshift> AttAttshifts { get; set; }

    public virtual DbSet<AttBreaktime> AttBreaktimes { get; set; }

    public virtual DbSet<AttChangeschedule> AttChangeschedules { get; set; }

    public virtual DbSet<AttDepartmentschedule> AttDepartmentschedules { get; set; }

    public virtual DbSet<AttDeptattrule> AttDeptattrules { get; set; }

    public virtual DbSet<AttHoliday> AttHolidays { get; set; }

    public virtual DbSet<AttLeave> AttLeaves { get; set; }

    public virtual DbSet<AttLeavecategory> AttLeavecategories { get; set; }

    public virtual DbSet<AttManuallog> AttManuallogs { get; set; }

    public virtual DbSet<AttOvertime> AttOvertimes { get; set; }

    public virtual DbSet<AttPayloadbase> AttPayloadbases { get; set; }

    public virtual DbSet<AttPayloadbreak> AttPayloadbreaks { get; set; }

    public virtual DbSet<AttPayloadexception> AttPayloadexceptions { get; set; }

    public virtual DbSet<AttPayloadmulpunchset> AttPayloadmulpunchsets { get; set; }

    public virtual DbSet<AttPayloadovertime> AttPayloadovertimes { get; set; }

    public virtual DbSet<AttPayloadpunch> AttPayloadpunches { get; set; }

    public virtual DbSet<AttReportparam> AttReportparams { get; set; }

    public virtual DbSet<AttShiftdetail> AttShiftdetails { get; set; }

    public virtual DbSet<AttTempschedule> AttTempschedules { get; set; }

    public virtual DbSet<AttTimeinterval> AttTimeintervals { get; set; }

    public virtual DbSet<AttTimeintervalBreakTime> AttTimeintervalBreakTimes { get; set; }

    public virtual DbSet<AttTraining> AttTrainings { get; set; }

    public virtual DbSet<AttTrainingcategory> AttTrainingcategories { get; set; }

    public virtual DbSet<AttVacationemployee> AttVacationemployees { get; set; }

    public virtual DbSet<AttVacationtime> AttVacationtimes { get; set; }

    public virtual DbSet<AttVacationtimeseniority> AttVacationtimeseniorities { get; set; }

    public virtual DbSet<Attparam> Attparams { get; set; }

    public virtual DbSet<AuthGroup> AuthGroups { get; set; }

    public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthPermission> AuthPermissions { get; set; }

    public virtual DbSet<AuthUser> AuthUsers { get; set; }

    public virtual DbSet<AuthUserAuthArea> AuthUserAuthAreas { get; set; }

    public virtual DbSet<AuthUserAuthDept> AuthUserAuthDepts { get; set; }

    public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; }

    public virtual DbSet<AuthUserProfile> AuthUserProfiles { get; set; }

    public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; }

    public virtual DbSet<AuthtokenToken> AuthtokenTokens { get; set; }

    public virtual DbSet<BaseAdminlog> BaseAdminlogs { get; set; }

    public virtual DbSet<BaseAttparamdept> BaseAttparamdepts { get; set; }

    public virtual DbSet<BaseAutoexporttask> BaseAutoexporttasks { get; set; }

    public virtual DbSet<BaseBookmark> BaseBookmarks { get; set; }

    public virtual DbSet<BaseDbbackuplog> BaseDbbackuplogs { get; set; }

    public virtual DbSet<BaseDbmigrate> BaseDbmigrates { get; set; }

    public virtual DbSet<BaseDepartmentalert> BaseDepartmentalerts { get; set; }

    public virtual DbSet<BaseDepartmentalertDepartment> BaseDepartmentalertDepartments { get; set; }

    public virtual DbSet<BasePersonalalert> BasePersonalalerts { get; set; }

    public virtual DbSet<BasePersonalalertEmployee> BasePersonalalertEmployees { get; set; }

    public virtual DbSet<BaseReportoutputsetting> BaseReportoutputsettings { get; set; }

    public virtual DbSet<BaseSecuritypolicy> BaseSecuritypolicies { get; set; }

    public virtual DbSet<BaseSendemail> BaseSendemails { get; set; }

    public virtual DbSet<BaseSftpsetting> BaseSftpsettings { get; set; }

    public virtual DbSet<BaseSysparam> BaseSysparams { get; set; }

    public virtual DbSet<BaseSysparamdept> BaseSysparamdepts { get; set; }

    public virtual DbSet<BaseSystemsetting> BaseSystemsettings { get; set; }

    public virtual DbSet<BaseTaskresultlog> BaseTaskresultlogs { get; set; }

    public virtual DbSet<CeleryTaskmetum> CeleryTaskmeta { get; set; }

    public virtual DbSet<CeleryTasksetmetum> CeleryTasksetmeta { get; set; }

    public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }

    public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }

    public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }

    public virtual DbSet<DjangoSession> DjangoSessions { get; set; }

    public virtual DbSet<DjceleryCrontabschedule> DjceleryCrontabschedules { get; set; }

    public virtual DbSet<DjceleryIntervalschedule> DjceleryIntervalschedules { get; set; }

    public virtual DbSet<DjceleryPeriodictask> DjceleryPeriodictasks { get; set; }

    public virtual DbSet<DjceleryPeriodictask1> DjceleryPeriodictasks1 { get; set; }

    public virtual DbSet<DjceleryTaskstate> DjceleryTaskstates { get; set; }

    public virtual DbSet<DjceleryWorkerstate> DjceleryWorkerstates { get; set; }

    public virtual DbSet<EpEpsetup> EpEpsetups { get; set; }

    public virtual DbSet<EpEptransaction> EpEptransactions { get; set; }

    public virtual DbSet<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; }

    public virtual DbSet<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; }

    public virtual DbSet<IclockBiodatum> IclockBiodata { get; set; }

    public virtual DbSet<IclockBiophoto> IclockBiophotos { get; set; }

    public virtual DbSet<IclockDeviceconfig> IclockDeviceconfigs { get; set; }

    public virtual DbSet<IclockErrorcommandlog> IclockErrorcommandlogs { get; set; }

    public virtual DbSet<IclockPrivatemessage> IclockPrivatemessages { get; set; }

    public virtual DbSet<IclockPublicmessage> IclockPublicmessages { get; set; }

    public virtual DbSet<IclockTerminal> IclockTerminals { get; set; }

    public virtual DbSet<IclockTerminalcommand> IclockTerminalcommands { get; set; }

    public virtual DbSet<IclockTerminalcommandlog> IclockTerminalcommandlogs { get; set; }

    public virtual DbSet<IclockTerminalemployee> IclockTerminalemployees { get; set; }

    public virtual DbSet<IclockTerminallog> IclockTerminallogs { get; set; }

    public virtual DbSet<IclockTerminalparameter> IclockTerminalparameters { get; set; }

    public virtual DbSet<IclockTerminaluploadlog> IclockTerminaluploadlogs { get; set; }

    public virtual DbSet<IclockTerminalworkcode> IclockTerminalworkcodes { get; set; }

    public virtual DbSet<IclockTransaction> IclockTransactions { get; set; }

    public virtual DbSet<IclockTransactionproofcmd> IclockTransactionproofcmds { get; set; }

    public virtual DbSet<MobileAnnouncement> MobileAnnouncements { get; set; }

    public virtual DbSet<MobileAppactionlog> MobileAppactionlogs { get; set; }

    public virtual DbSet<MobileApplist> MobileApplists { get; set; }

    public virtual DbSet<MobileAppnotification> MobileAppnotifications { get; set; }

    public virtual DbSet<MobileGpsfordepartment> MobileGpsfordepartments { get; set; }

    public virtual DbSet<MobileGpsforemployee> MobileGpsforemployees { get; set; }

    public virtual DbSet<NotificationsNotification> NotificationsNotifications { get; set; }

    public virtual DbSet<PayrollDeductionformula> PayrollDeductionformulas { get; set; }

    public virtual DbSet<PayrollEmploan> PayrollEmploans { get; set; }

    public virtual DbSet<PayrollEmppayrollprofile> PayrollEmppayrollprofiles { get; set; }

    public virtual DbSet<PayrollExceptionformula> PayrollExceptionformulas { get; set; }

    public virtual DbSet<PayrollExtradeduction> PayrollExtradeductions { get; set; }

    public virtual DbSet<PayrollExtraincrease> PayrollExtraincreases { get; set; }

    public virtual DbSet<PayrollIncreasementformula> PayrollIncreasementformulas { get; set; }

    public virtual DbSet<PayrollLeaveformula> PayrollLeaveformulas { get; set; }

    public virtual DbSet<PayrollMonthlysalary> PayrollMonthlysalaries { get; set; }

    public virtual DbSet<PayrollOvertimeformula> PayrollOvertimeformulas { get; set; }

    public virtual DbSet<PayrollReimbursement> PayrollReimbursements { get; set; }

    public virtual DbSet<PayrollSalaryadvance> PayrollSalaryadvances { get; set; }

    public virtual DbSet<PayrollSalarystructure> PayrollSalarystructures { get; set; }

    public virtual DbSet<PayrollSalarystructureDeductionformula> PayrollSalarystructureDeductionformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; set; }

    public virtual DbSet<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; set; }

    public virtual DbSet<PersonnelArea> PersonnelAreas { get; set; }

    public virtual DbSet<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; set; }

    public virtual DbSet<PersonnelCertification> PersonnelCertifications { get; set; }

    public virtual DbSet<PersonnelCompany> PersonnelCompanies { get; set; }

    public virtual DbSet<PersonnelCompanyregister> PersonnelCompanyregisters { get; set; }

    public virtual DbSet<PersonnelDepartment> PersonnelDepartments { get; set; }

    public virtual DbSet<PersonnelEmployee> PersonnelEmployees { get; set; }

    public virtual DbSet<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; set; }

    public virtual DbSet<PersonnelEmployeeAreaPrivilege> PersonnelEmployeeAreaPrivileges { get; set; }

    public virtual DbSet<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; set; }

    public virtual DbSet<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; set; }

    public virtual DbSet<PersonnelEmployeeprofile> PersonnelEmployeeprofiles { get; set; }

    public virtual DbSet<PersonnelPosition> PersonnelPositions { get; set; }

    public virtual DbSet<PersonnelResign> PersonnelResigns { get; set; }

    public virtual DbSet<StaffStafftoken> StaffStafftokens { get; set; }

    public virtual DbSet<SyncArea> SyncAreas { get; set; }

    public virtual DbSet<SyncDepartment> SyncDepartments { get; set; }

    public virtual DbSet<SyncEmployee> SyncEmployees { get; set; }

    public virtual DbSet<SyncJob> SyncJobs { get; set; }

    public virtual DbSet<WorkflowAbstractexception> WorkflowAbstractexceptions { get; set; }

    public virtual DbSet<WorkflowNodeinstance> WorkflowNodeinstances { get; set; }

    public virtual DbSet<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; }

    public virtual DbSet<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; set; }

    public virtual DbSet<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; set; }

    public virtual DbSet<WorkflowWorkflownode> WorkflowWorkflownodes { get; set; }

    public virtual DbSet<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; set; }

    public virtual DbSet<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; set; }

    public virtual DbSet<WorkflowWorkflowrole> WorkflowWorkflowroles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=BioTimeSQLConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccAcccombination>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_acccombination");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CombinationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("combination_name");
            entity.Property(e => e.CombinationNo).HasColumnName("combination_no");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Group1).HasColumnName("group1");
            entity.Property(e => e.Group2).HasColumnName("group2");
            entity.Property(e => e.Group3).HasColumnName("group3");
            entity.Property(e => e.Group4).HasColumnName("group4");
            entity.Property(e => e.Group5).HasColumnName("group5");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Remark)
                .HasMaxLength(999)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<AccAccgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_accgroups");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.GroupName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("group_name");
            entity.Property(e => e.GroupNo).HasColumnName("group_no");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsIncludeHoliday).HasColumnName("is_include_holiday");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timezone1).HasColumnName("timezone1");
            entity.Property(e => e.Timezone2).HasColumnName("timezone2");
            entity.Property(e => e.Timezone3).HasColumnName("timezone3");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
            entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");
        });

        modelBuilder.Entity<AccAccholiday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_accholiday");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.HolidayId).HasColumnName("holiday_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TimezoneId).HasColumnName("timezone_id");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<AccAccprivilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_accprivilege");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsGroupTimezone).HasColumnName("is_group_timezone");
            entity.Property(e => e.IsGroupVerifycode).HasColumnName("is_group_verifycode");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timezone1).HasColumnName("timezone1");
            entity.Property(e => e.Timezone2).HasColumnName("timezone2");
            entity.Property(e => e.Timezone3).HasColumnName("timezone3");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
            entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");
        });

        modelBuilder.Entity<AccAccterminal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_accterminal");

            entity.Property(e => e.Alarm11).HasColumnName("alarm_1_1");
            entity.Property(e => e.Alarm1N).HasColumnName("alarm_1_n");
            entity.Property(e => e.AlarmPassword).HasColumnName("alarm_password");
            entity.Property(e => e.AntiDoorDirection).HasColumnName("anti_door_direction");
            entity.Property(e => e.AntiPassbackMode).HasColumnName("anti_passback_mode");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DoorAlarmDelay).HasColumnName("door_alarm_delay");
            entity.Property(e => e.DoorLockDelay).HasColumnName("door_lock_delay");
            entity.Property(e => e.DoorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("door_name");
            entity.Property(e => e.DoorSensorDelay).HasColumnName("door_sensor_delay");
            entity.Property(e => e.DoorSensorType).HasColumnName("door_sensor_type");
            entity.Property(e => e.DuressAlarmDelay).HasColumnName("duress_alarm_delay");
            entity.Property(e => e.DuressFunOn).HasColumnName("duress_fun_on");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NcTimePeriod).HasColumnName("nc_time_period");
            entity.Property(e => e.NoTimePeriod).HasColumnName("no_time_period");
            entity.Property(e => e.PushTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("push_time");
            entity.Property(e => e.RetryTimes).HasColumnName("retry_times");
            entity.Property(e => e.SpeakerAlarm).HasColumnName("speaker_alarm");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.ValidHoliday).HasColumnName("valid_holiday");
            entity.Property(e => e.VerifyMode485).HasColumnName("verify_mode_485");
        });

        modelBuilder.Entity<AccAcctimezone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("acc_acctimezone");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.FriEnd).HasColumnName("fri_end");
            entity.Property(e => e.FriOn).HasColumnName("fri_on");
            entity.Property(e => e.FriStart).HasColumnName("fri_start");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MonEnd).HasColumnName("mon_end");
            entity.Property(e => e.MonOn).HasColumnName("mon_on");
            entity.Property(e => e.MonStart).HasColumnName("mon_start");
            entity.Property(e => e.Remark)
                .HasMaxLength(999)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.SatEnd).HasColumnName("sat_end");
            entity.Property(e => e.SatOn).HasColumnName("sat_on");
            entity.Property(e => e.SatStart).HasColumnName("sat_start");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SunEnd).HasColumnName("sun_end");
            entity.Property(e => e.SunOn).HasColumnName("sun_on");
            entity.Property(e => e.SunStart).HasColumnName("sun_start");
            entity.Property(e => e.ThuEnd).HasColumnName("thu_end");
            entity.Property(e => e.ThuOn).HasColumnName("thu_on");
            entity.Property(e => e.ThuStart).HasColumnName("thu_start");
            entity.Property(e => e.TimezoneName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("timezone_name");
            entity.Property(e => e.TimezoneNo).HasColumnName("timezone_no");
            entity.Property(e => e.TueEnd).HasColumnName("tue_end");
            entity.Property(e => e.TueOn).HasColumnName("tue_on");
            entity.Property(e => e.TueStart).HasColumnName("tue_start");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
            entity.Property(e => e.WedEnd).HasColumnName("wed_end");
            entity.Property(e => e.WedOn).HasColumnName("wed_on");
            entity.Property(e => e.WedStart).HasColumnName("wed_start");
        });

        modelBuilder.Entity<AccountsAdminbiodatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("accounts_adminbiodata");

            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.BioFormat).HasColumnName("bio_format");
            entity.Property(e => e.BioIndex).HasColumnName("bio_index");
            entity.Property(e => e.BioNo).HasColumnName("bio_no");
            entity.Property(e => e.BioTmp)
                .HasColumnType("text")
                .HasColumnName("bio_tmp");
            entity.Property(e => e.BioType).HasColumnName("bio_type");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Duress).HasColumnName("duress");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MajorVer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("major_ver");
            entity.Property(e => e.MinorVer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("minor_ver");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Valid).HasColumnName("valid");
        });

        modelBuilder.Entity<AccountsUsersecuritypolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("accounts_usersecuritypolicy");

            entity.Property(e => e.Account).HasColumnName("account");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PasswordDate).HasColumnName("password_date");
            entity.Property(e => e.PasswordExpired).HasColumnName("password_expired");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("session_key");
            entity.Property(e => e.UnlockTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("unlock_time");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AttAttcalclog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_attcalclog");

            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EndDate)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LogType).HasColumnName("log_type");
            entity.Property(e => e.StartDate)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<AttAttreportsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_attreportsetting");

            entity.Property(e => e.AttItem)
                .HasColumnType("text")
                .HasColumnName("att_item");
            entity.Property(e => e.FuncKey)
                .HasColumnType("text")
                .HasColumnName("func_key");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ResignEmp).HasColumnName("resign_emp");
            entity.Property(e => e.ShortDate).HasColumnName("short_date");
            entity.Property(e => e.ShortTime).HasColumnName("short_time");
        });

        modelBuilder.Entity<AttAttrule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_attrule");

            entity.Property(e => e.ParamName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamValue)
                .HasColumnType("text")
                .HasColumnName("param_value");
        });

        modelBuilder.Entity<AttAttschedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_attschedule");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
        });

        modelBuilder.Entity<AttAttshift>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_attshift");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.AutoShift).HasColumnName("auto_shift");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.CycleUnit).HasColumnName("cycle_unit");
            entity.Property(e => e.DayOffType).HasColumnName("day_off_type");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ShiftCycle).HasColumnName("shift_cycle");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WeekendType).HasColumnName("weekend_type");
            entity.Property(e => e.WorkDayOff).HasColumnName("work_day_off");
            entity.Property(e => e.WorkWeekend).HasColumnName("work_weekend");
        });

        modelBuilder.Entity<AttBreaktime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_breaktime");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.AvailableInterval).HasColumnName("available_interval");
            entity.Property(e => e.AvailableIntervalType).HasColumnName("available_interval_type");
            entity.Property(e => e.CalcType).HasColumnName("calc_type");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyIn).HasColumnName("early_in");
            entity.Property(e => e.EndMargin).HasColumnName("end_margin");
            entity.Property(e => e.FuncKey).HasColumnName("func_key");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LateIn).HasColumnName("late_in");
            entity.Property(e => e.MinEarlyIn).HasColumnName("min_early_in");
            entity.Property(e => e.MinLateIn).HasColumnName("min_late_in");
            entity.Property(e => e.MinimumDuration).HasColumnName("minimum_duration");
            entity.Property(e => e.MultiplePunch).HasColumnName("multiple_punch");
            entity.Property(e => e.PeriodStart).HasColumnName("period_start");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttChangeschedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_changeschedule");

            entity.Property(e => e.AbstractexceptionPtrId).HasColumnName("abstractexception_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("apply_time");
            entity.Property(e => e.Approver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approver");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.AuditReason)
                .HasColumnType("text")
                .HasColumnName("audit_reason");
            entity.Property(e => e.AuditTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("audit_time");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.PreviousTimeinterval)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("previous_timeinterval");
            entity.Property(e => e.TimeintervalId).HasColumnName("timeinterval_id");
        });

        modelBuilder.Entity<AttDepartmentschedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_departmentschedule");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttDeptattrule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_deptattrule");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Rule)
                .HasColumnType("text")
                .HasColumnName("rule");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttHoliday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_holiday");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DurationDay).HasColumnName("duration_day");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OvertimeLv1).HasColumnName("overtime_lv1");
            entity.Property(e => e.OvertimeLv2).HasColumnName("overtime_lv2");
            entity.Property(e => e.OvertimeLv3).HasColumnName("overtime_lv3");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.WorkType).HasColumnName("work_type");
        });

        modelBuilder.Entity<AttLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_leave");

            entity.Property(e => e.AbstractexceptionPtrId).HasColumnName("abstractexception_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasColumnType("text")
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("apply_time");
            entity.Property(e => e.ApprovalLevel).HasColumnName("approval_level");
            entity.Property(e => e.Approver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approver");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attachment");
            entity.Property(e => e.AuditReason)
                .HasColumnType("text")
                .HasColumnName("audit_reason");
            entity.Property(e => e.AuditTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("audit_time");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.VacationNumber).HasColumnName("vacation_number");
        });

        modelBuilder.Entity<AttLeavecategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_leavecategory");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LeaveCategoryType).HasColumnName("leave_category_type");
            entity.Property(e => e.MinimumUnit).HasColumnName("minimum_unit");
            entity.Property(e => e.ReportSymbol)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("report_symbol");
            entity.Property(e => e.RoundOff).HasColumnName("round_off");
            entity.Property(e => e.Unit).HasColumnName("unit");
        });

        modelBuilder.Entity<AttManuallog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_manuallog");

            entity.Property(e => e.AbstractexceptionPtrId).HasColumnName("abstractexception_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasColumnType("text")
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("apply_time");
            entity.Property(e => e.ApprovalLevel).HasColumnName("approval_level");
            entity.Property(e => e.Approver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approver");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attachment");
            entity.Property(e => e.AuditReason)
                .HasColumnType("text")
                .HasColumnName("audit_reason");
            entity.Property(e => e.AuditTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("audit_time");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.IsMask).HasColumnName("is_mask");
            entity.Property(e => e.PunchState).HasColumnName("punch_state");
            entity.Property(e => e.PunchTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("punch_time");
            entity.Property(e => e.Temperature)
                .HasColumnType("numeric(4, 1)")
                .HasColumnName("temperature");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("work_code");
        });

        modelBuilder.Entity<AttOvertime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_overtime");

            entity.Property(e => e.AbstractexceptionPtrId).HasColumnName("abstractexception_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasColumnType("text")
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("apply_time");
            entity.Property(e => e.ApprovalLevel).HasColumnName("approval_level");
            entity.Property(e => e.Approver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approver");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attachment");
            entity.Property(e => e.AuditReason)
                .HasColumnType("text")
                .HasColumnName("audit_reason");
            entity.Property(e => e.AuditTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("audit_time");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.OvertimeType).HasColumnName("overtime_type");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
        });

        modelBuilder.Entity<AttPayloadbase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_payloadbase");

            entity.Property(e => e.Absent).HasColumnName("absent");
            entity.Property(e => e.ActualWorked).HasColumnName("actual_worked");
            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.BreakTimeId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("break_time_id");
            entity.Property(e => e.CheckIn)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("check_in");
            entity.Property(e => e.CheckOut)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("check_out");
            entity.Property(e => e.ClockIn)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("clock_in");
            entity.Property(e => e.ClockOut)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("clock_out");
            entity.Property(e => e.DayOff).HasColumnName("day_off");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.DutyDuration).HasColumnName("duty_duration");
            entity.Property(e => e.DutyWorked).HasColumnName("duty_worked");
            entity.Property(e => e.EarlyLeave).HasColumnName("early_leave");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Exception)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exception");
            entity.Property(e => e.Late).HasColumnName("late");
            entity.Property(e => e.Leave).HasColumnName("leave");
            entity.Property(e => e.OvertimeId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("overtime_id");
            entity.Property(e => e.Remaining).HasColumnName("remaining");
            entity.Property(e => e.Short).HasColumnName("short");
            entity.Property(e => e.TimetableId).HasColumnName("timetable_id");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.TotalWorked).HasColumnName("total_worked");
            entity.Property(e => e.TransInId).HasColumnName("trans_in_id");
            entity.Property(e => e.TransOutId).HasColumnName("trans_out_id");
            entity.Property(e => e.Unscheduled).HasColumnName("unscheduled");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uuid");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.WorkDay).HasColumnName("work_day");
        });

        modelBuilder.Entity<AttPayloadbreak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_payloadbreak");

            entity.Property(e => e.Absent).HasColumnName("absent");
            entity.Property(e => e.ActualDuration).HasColumnName("actual_duration");
            entity.Property(e => e.BreakIn)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("break_in");
            entity.Property(e => e.BreakOut)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("break_out");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyIn).HasColumnName("early_in");
            entity.Property(e => e.EarlyLeave).HasColumnName("early_leave");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.Late).HasColumnName("late");
            entity.Property(e => e.LateIn).HasColumnName("late_in");
            entity.Property(e => e.Overtime).HasColumnName("overtime");
            entity.Property(e => e.Taken).HasColumnName("taken");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uuid");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
            entity.Property(e => e.WorkTime).HasColumnName("work_time");
        });

        modelBuilder.Entity<AttPayloadexception>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_payloadexception");

            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.SkdId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("skd_id");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<AttPayloadmulpunchset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_payloadmulpunchset");

            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.ClockIn)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("clock_in");
            entity.Property(e => e.ClockOut)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("clock_out");
            entity.Property(e => e.DataIndex).HasColumnName("data_index");
            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InId).HasColumnName("in_id");
            entity.Property(e => e.OutId).HasColumnName("out_id");
            entity.Property(e => e.TimetableId).HasColumnName("timetable_id");
            entity.Property(e => e.TotalTime).HasColumnName("total_time");
            entity.Property(e => e.Weekday).HasColumnName("weekday");
            entity.Property(e => e.WorkedTime).HasColumnName("worked_time");
        });

        modelBuilder.Entity<AttPayloadovertime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_payloadovertime");

            entity.Property(e => e.DayoffOt).HasColumnName("dayoff_ot");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.NormalOt).HasColumnName("normal_ot");
            entity.Property(e => e.NormalWt).HasColumnName("normal_wt");
            entity.Property(e => e.OtLv1).HasColumnName("ot_lv1");
            entity.Property(e => e.OtLv2).HasColumnName("ot_lv2");
            entity.Property(e => e.OtLv3).HasColumnName("ot_lv3");
            entity.Property(e => e.TotalOt).HasColumnName("total_ot");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uuid");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
        });

        modelBuilder.Entity<AttPayloadpunch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_payloadpunch");

            entity.Property(e => e.AttDate).HasColumnName("att_date");
            entity.Property(e => e.CorrectState)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("correct_state");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.OrigId).HasColumnName("orig_id");
            entity.Property(e => e.SkdId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("skd_id");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<AttReportparam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_reportparam");

            entity.Property(e => e.ParamName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamValue)
                .HasColumnType("text")
                .HasColumnName("param_value");
        });

        modelBuilder.Entity<AttShiftdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_shiftdetail");

            entity.Property(e => e.DayIndex).HasColumnName("day_index");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InTime).HasColumnName("in_time");
            entity.Property(e => e.OutTime).HasColumnName("out_time");
            entity.Property(e => e.ShiftId).HasColumnName("shift_id");
            entity.Property(e => e.TimeIntervalId).HasColumnName("time_interval_id");
        });

        modelBuilder.Entity<AttTempschedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_tempschedule");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RuleFlag).HasColumnName("rule_flag");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.TimeIntervalId).HasColumnName("time_interval_id");
            entity.Property(e => e.WorkType).HasColumnName("work_type");
        });

        modelBuilder.Entity<AttTimeinterval>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_timeinterval");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.AllowLate).HasColumnName("allow_late");
            entity.Property(e => e.AllowLeaveEarly).HasColumnName("allow_leave_early");
            entity.Property(e => e.AvailableInterval).HasColumnName("available_interval");
            entity.Property(e => e.AvailableIntervalType).HasColumnName("available_interval_type");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DayChange).HasColumnName("day_change");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EarlyIn).HasColumnName("early_in");
            entity.Property(e => e.FuncKey).HasColumnName("func_key");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InAboveMargin).HasColumnName("in_above_margin");
            entity.Property(e => e.InAheadMargin).HasColumnName("in_ahead_margin");
            entity.Property(e => e.InRequired).HasColumnName("in_required");
            entity.Property(e => e.InTime).HasColumnName("in_time");
            entity.Property(e => e.LateOut).HasColumnName("late_out");
            entity.Property(e => e.MinEarlyIn).HasColumnName("min_early_in");
            entity.Property(e => e.MinLateOut).HasColumnName("min_late_out");
            entity.Property(e => e.MultiplePunch).HasColumnName("multiple_punch");
            entity.Property(e => e.OutAboveMargin).HasColumnName("out_above_margin");
            entity.Property(e => e.OutAheadMargin).HasColumnName("out_ahead_margin");
            entity.Property(e => e.OutRequired).HasColumnName("out_required");
            entity.Property(e => e.OvertimeLv).HasColumnName("overtime_lv");
            entity.Property(e => e.OvertimeLv1).HasColumnName("overtime_lv1");
            entity.Property(e => e.OvertimeLv2).HasColumnName("overtime_lv2");
            entity.Property(e => e.OvertimeLv3).HasColumnName("overtime_lv3");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Use24Mode).HasColumnName("use_24_mode");
            entity.Property(e => e.UseMode).HasColumnName("use_mode");
            entity.Property(e => e.WorkDay).HasColumnName("work_day");
            entity.Property(e => e.WorkTimeDuration).HasColumnName("work_time_duration");
            entity.Property(e => e.WorkType).HasColumnName("work_type");
        });

        modelBuilder.Entity<AttTimeintervalBreakTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_timeinterval_break_time");

            entity.Property(e => e.BreaktimeId).HasColumnName("breaktime_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TimeintervalId).HasColumnName("timeinterval_id");
        });

        modelBuilder.Entity<AttTraining>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_training");

            entity.Property(e => e.AbstractexceptionPtrId).HasColumnName("abstractexception_ptr_id");
            entity.Property(e => e.ApplyReason)
                .HasColumnType("text")
                .HasColumnName("apply_reason");
            entity.Property(e => e.ApplyTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("apply_time");
            entity.Property(e => e.ApprovalLevel).HasColumnName("approval_level");
            entity.Property(e => e.Approver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approver");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attachment");
            entity.Property(e => e.AuditReason)
                .HasColumnType("text")
                .HasColumnName("audit_reason");
            entity.Property(e => e.AuditTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("audit_time");
            entity.Property(e => e.AuditUserId).HasColumnName("audit_user_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
        });

        modelBuilder.Entity<AttTrainingcategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_trainingcategory");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MinimumUnit).HasColumnName("minimum_unit");
            entity.Property(e => e.ReportSymbol)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("report_symbol");
            entity.Property(e => e.RoundOff).HasColumnName("round_off");
            entity.Property(e => e.Unit).HasColumnName("unit");
        });

        modelBuilder.Entity<AttVacationemployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_vacationemployee");

            entity.Property(e => e.DaysLeft).HasColumnName("days_left");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LeaveId).HasColumnName("leave_id");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.VacationAvailableId).HasColumnName("vacation_available_id");
        });

        modelBuilder.Entity<AttVacationtime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_vacationtime");

            entity.Property(e => e.CategoryCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("category_code");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category_name");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttVacationtimeseniority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("att_vacationtimeseniority");

            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Seniority).HasColumnName("seniority");
            entity.Property(e => e.VacationTimeId).HasColumnName("vacation_time_id");
        });

        modelBuilder.Entity<Attparam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("attparam");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Paraname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("paraname");
            entity.Property(e => e.Paratype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("paratype");
            entity.Property(e => e.Paravalue)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("paravalue");
        });

        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_group");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroupPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_group_permissions");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_permission");

            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_user");

            entity.Property(e => e.AuthCompanyId).HasColumnName("auth_company_id");
            entity.Property(e => e.AuthTimeDept).HasColumnName("auth_time_dept");
            entity.Property(e => e.CanManageAllDept).HasColumnName("can_manage_all_dept");
            entity.Property(e => e.DateJoined)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("date_joined");
            entity.Property(e => e.DelFlag).HasColumnName("del_flag");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmpPin)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("emp_pin");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsPublic).HasColumnName("is_public");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");
            entity.Property(e => e.IsTest).HasColumnName("is_test");
            entity.Property(e => e.LastLogin)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.LoginCount).HasColumnName("login_count");
            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.LoginType).HasColumnName("login_type");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.TelePhone)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tele_phone");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUserAuthArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_user_auth_area");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");
        });

        modelBuilder.Entity<AuthUserAuthDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_user_auth_dept");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");
        });

        modelBuilder.Entity<AuthUserGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_user_groups");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");
        });

        modelBuilder.Entity<AuthUserProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_user_profile");

            entity.Property(e => e.ColumnOrder)
                .HasColumnType("text")
                .HasColumnName("column_order");
            entity.Property(e => e.DisabledFields)
                .HasColumnType("text")
                .HasColumnName("disabled_fields");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LoginName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("login_name");
            entity.Property(e => e.PinTabs)
                .HasColumnType("text")
                .HasColumnName("pin_tabs");
            entity.Property(e => e.Preferences)
                .HasColumnType("text")
                .HasColumnName("preferences");
            entity.Property(e => e.PwdUpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("pwd_update_time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<AuthUserUserPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("auth_user_user_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MyuserId).HasColumnName("myuser_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
        });

        modelBuilder.Entity<AuthtokenToken>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("authtoken_token");

            entity.Property(e => e.Created)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("created");
            entity.Property(e => e.Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("key");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BaseAdminlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_adminlog");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.ActionStatus).HasColumnName("action_status");
            entity.Property(e => e.CanRoutable).HasColumnName("can_routable");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip_address");
            entity.Property(e => e.OpTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("op_time");
            entity.Property(e => e.Targets)
                .HasColumnType("text")
                .HasColumnName("targets");
            entity.Property(e => e.TargetsRepr)
                .HasColumnType("text")
                .HasColumnName("targets_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BaseAttparamdept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_attparamdepts");

            entity.Property(e => e.Deptid).HasColumnName("deptid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("operator");
            entity.Property(e => e.Optime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("optime");
            entity.Property(e => e.Rulename)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("rulename");
        });

        modelBuilder.Entity<BaseAutoexporttask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_autoexporttask");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TaskCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("task_code");
            entity.Property(e => e.TaskName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("task_name");
        });

        modelBuilder.Entity<BaseBookmark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_bookmark");

            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Filters)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("filters");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsShare).HasColumnName("is_share");
            entity.Property(e => e.TimeSaved)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("time_saved");
            entity.Property(e => e.Title)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<BaseDbbackuplog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_dbbackuplog");

            entity.Property(e => e.BackupFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("backup_file");
            entity.Property(e => e.BackupStatus).HasColumnName("backup_status");
            entity.Property(e => e.BackupTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("backup_time");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DbName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("db_name");
            entity.Property(e => e.DbType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("db_type");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Operator)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("operator");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<BaseDbmigrate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_dbmigrate");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<BaseDepartmentalert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_departmentalert");

            entity.Property(e => e.DepartmentalertCode)
                .HasMaxLength(116)
                .IsUnicode(false)
                .HasColumnName("departmentalert_code");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmplistId).HasColumnName("emplist_id");
            entity.Property(e => e.PersonalalertPtrId).HasColumnName("personalalert_ptr_id");
        });

        modelBuilder.Entity<BaseDepartmentalertDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_departmentalert_department");

            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DepartmentalertId).HasColumnName("departmentalert_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<BasePersonalalert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_personalalert");

            entity.Property(e => e.AbsentExceeds).HasColumnName("absent_exceeds");
            entity.Property(e => e.AlertType).HasColumnName("alert_type");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.EarlyLeaveExceeds).HasColumnName("early_leave_exceeds");
            entity.Property(e => e.EmailAlert).HasColumnName("email_alert");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IncludeToday).HasColumnName("include_today");
            entity.Property(e => e.IsEnbleAlert).HasColumnName("is_enble_alert");
            entity.Property(e => e.LastActivity)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_activity");
            entity.Property(e => e.LateExceeds).HasColumnName("late_exceeds");
            entity.Property(e => e.MessageType).HasColumnName("message_type");
            entity.Property(e => e.PopAlert).HasColumnName("pop_alert");
            entity.Property(e => e.SendingFrequency).HasColumnName("sending_frequency");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("time");
        });

        modelBuilder.Entity<BasePersonalalertEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_personalalert_employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PersonalalertId).HasColumnName("personalalert_id");
        });

        modelBuilder.Entity<BaseReportoutputsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_reportoutputsetting");

            entity.Property(e => e.AgreementMessage)
                .HasColumnType("text")
                .HasColumnName("agreement_message");
            entity.Property(e => e.AgreementMessageId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("agreement_message_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReportName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("report_name");
        });

        modelBuilder.Entity<BaseSecuritypolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_securitypolicy");

            entity.Property(e => e.CodeLength).HasColumnName("code_length");
            entity.Property(e => e.EnforcePwdChange).HasColumnName("enforce_pwd_change");
            entity.Property(e => e.EnforcePwdExpiration).HasColumnName("enforce_pwd_expiration");
            entity.Property(e => e.FailedLocked).HasColumnName("failed_locked");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.LockDuration).HasColumnName("lock_duration");
            entity.Property(e => e.LockFailedCount).HasColumnName("lock_failed_count");
            entity.Property(e => e.SecurityCode).HasColumnName("security_code");
            entity.Property(e => e.SingleLogin).HasColumnName("single_login");
            entity.Property(e => e.ValidDuration).HasColumnName("valid_duration");
            entity.Property(e => e.ValidityPeriod).HasColumnName("validity_period");
        });

        modelBuilder.Entity<BaseSendemail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_sendemail");

            entity.Property(e => e.EmailBcc)
                .HasColumnType("text")
                .HasColumnName("email_bcc");
            entity.Property(e => e.EmailCc)
                .HasColumnType("text")
                .HasColumnName("email_cc");
            entity.Property(e => e.EmailContent)
                .HasColumnType("text")
                .HasColumnName("email_content");
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("email_subject");
            entity.Property(e => e.EmailTo)
                .HasColumnType("text")
                .HasColumnName("email_to");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.SendStatus).HasColumnName("send_status");
            entity.Property(e => e.SendTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("send_time");
        });

        modelBuilder.Entity<BaseSftpsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_sftpsetting");

            entity.Property(e => e.AuthMethod).HasColumnName("auth_method");
            entity.Property(e => e.Host)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KeyPassword)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("key_password");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.UserKey)
                .HasColumnType("text")
                .HasColumnName("user_key");
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("user_password");
        });

        modelBuilder.Entity<BaseSysparam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_sysparam");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParaName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("para_name");
            entity.Property(e => e.ParaType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("para_type");
            entity.Property(e => e.ParaValue)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("para_value");
        });

        modelBuilder.Entity<BaseSysparamdept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_sysparamdept");

            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OpTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("op_time");
            entity.Property(e => e.Operator)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("operator");
            entity.Property(e => e.RuleName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("rule_name");
        });

        modelBuilder.Entity<BaseSystemsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_systemsetting");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<BaseTaskresultlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("base_taskresultlog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Result)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("result");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Task)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("task");
            entity.Property(e => e.Time)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("time");
        });

        modelBuilder.Entity<CeleryTaskmetum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("celery_taskmeta");

            entity.Property(e => e.DateDone)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("date_done");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Meta)
                .HasColumnType("text")
                .HasColumnName("meta");
            entity.Property(e => e.Result)
                .HasColumnType("text")
                .HasColumnName("result");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaskId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("task_id");
            entity.Property(e => e.Traceback)
                .HasColumnType("text")
                .HasColumnName("traceback");
        });

        modelBuilder.Entity<CeleryTasksetmetum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("celery_tasksetmeta");

            entity.Property(e => e.DateDone)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("date_done");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Result)
                .HasColumnType("text")
                .HasColumnName("result");
            entity.Property(e => e.TasksetId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("taskset_id");
        });

        modelBuilder.Entity<DjangoAdminLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("django_admin_log");

            entity.Property(e => e.ActionFlag).HasColumnName("action_flag");
            entity.Property(e => e.ActionTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage)
                .HasColumnType("text")
                .HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ObjectId)
                .HasColumnType("text")
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("object_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("django_content_type");

            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("app_label");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("model");
        });

        modelBuilder.Entity<DjangoMigration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("django_migrations");

            entity.Property(e => e.App)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("app");
            entity.Property(e => e.Applied)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("applied");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("django_session");

            entity.Property(e => e.ExpireDate)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("expire_date");
            entity.Property(e => e.SessionData)
                .HasColumnType("text")
                .HasColumnName("session_data");
            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("session_key");
        });

        modelBuilder.Entity<DjceleryCrontabschedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("djcelery_crontabschedule");

            entity.Property(e => e.DayOfMonth)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("day_of_month");
            entity.Property(e => e.DayOfWeek)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("day_of_week");
            entity.Property(e => e.Hour)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("hour");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Minute)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("minute");
            entity.Property(e => e.MonthOfYear)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("month_of_year");
        });

        modelBuilder.Entity<DjceleryIntervalschedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("djcelery_intervalschedule");

            entity.Property(e => e.Every).HasColumnName("every");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Period)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("period");
        });

        modelBuilder.Entity<DjceleryPeriodictask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("djcelery_periodictask");

            entity.Property(e => e.Args)
                .HasColumnType("text")
                .HasColumnName("args");
            entity.Property(e => e.CrontabId).HasColumnName("crontab_id");
            entity.Property(e => e.DateChanged)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("date_changed");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Exchange)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("exchange");
            entity.Property(e => e.Expires)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("expires");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IntervalId).HasColumnName("interval_id");
            entity.Property(e => e.Kwargs)
                .HasColumnType("text")
                .HasColumnName("kwargs");
            entity.Property(e => e.LastRunAt)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_run_at");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Queue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("queue");
            entity.Property(e => e.RoutingKey)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("routing_key");
            entity.Property(e => e.Task)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("task");
            entity.Property(e => e.TotalRunCount).HasColumnName("total_run_count");
        });

        modelBuilder.Entity<DjceleryPeriodictask1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("djcelery_periodictasks");

            entity.Property(e => e.Ident).HasColumnName("ident");
            entity.Property(e => e.LastUpdate)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_update");
        });

        modelBuilder.Entity<DjceleryTaskstate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("djcelery_taskstate");

            entity.Property(e => e.Args)
                .HasColumnType("text")
                .HasColumnName("args");
            entity.Property(e => e.Eta)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("eta");
            entity.Property(e => e.Expires)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("expires");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Kwargs)
                .HasColumnType("text")
                .HasColumnName("kwargs");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Result)
                .HasColumnType("text")
                .HasColumnName("result");
            entity.Property(e => e.Retries).HasColumnName("retries");
            entity.Property(e => e.Runtime).HasColumnName("runtime");
            entity.Property(e => e.State)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.TaskId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("task_id");
            entity.Property(e => e.Traceback)
                .HasColumnType("text")
                .HasColumnName("traceback");
            entity.Property(e => e.Tstamp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("tstamp");
            entity.Property(e => e.WorkerId).HasColumnName("worker_id");
        });

        modelBuilder.Entity<DjceleryWorkerstate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("djcelery_workerstate");

            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hostname");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastHeartbeat)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_heartbeat");
        });

        modelBuilder.Entity<EpEpsetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ep_epsetup");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaskAlarm).HasColumnName("mask_alarm");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TempAlarm).HasColumnName("temp_alarm");
            entity.Property(e => e.TempUnit).HasColumnName("temp_unit");
            entity.Property(e => e.TempWarning)
                .HasColumnType("numeric(4, 1)")
                .HasColumnName("temp_warning");
        });

        modelBuilder.Entity<EpEptransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ep_eptransaction");

            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CheckDate).HasColumnName("check_date");
            entity.Property(e => e.CheckDatetime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("check_datetime");
            entity.Property(e => e.CheckTime).HasColumnName("check_time");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsMask).HasColumnName("is_mask");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Temperature)
                .HasColumnType("numeric(4, 1)")
                .HasColumnName("temperature");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.UploadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("upload_time");
        });

        modelBuilder.Entity<GuardianGroupobjectpermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guardian_groupobjectpermission");

            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ObjectPk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("object_pk");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
        });

        modelBuilder.Entity<GuardianUserobjectpermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("guardian_userobjectpermission");

            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ObjectPk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("object_pk");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<IclockBiodatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_biodata");

            entity.Property(e => e.BioFormat).HasColumnName("bio_format");
            entity.Property(e => e.BioIndex).HasColumnName("bio_index");
            entity.Property(e => e.BioNo).HasColumnName("bio_no");
            entity.Property(e => e.BioTmp)
                .HasColumnType("text")
                .HasColumnName("bio_tmp");
            entity.Property(e => e.BioType).HasColumnName("bio_type");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Duress).HasColumnName("duress");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MajorVer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("major_ver");
            entity.Property(e => e.MinorVer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("minor_ver");
            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
            entity.Property(e => e.Valid).HasColumnName("valid");
        });

        modelBuilder.Entity<IclockBiophoto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_biophoto");

            entity.Property(e => e.ApprovalPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("approval_photo");
            entity.Property(e => e.ApprovalState).HasColumnName("approval_state");
            entity.Property(e => e.ApprovalTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("approval_time");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EnrollSn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("enroll_sn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastName)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.RegisterPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("register_photo");
            entity.Property(e => e.RegisterTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("register_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<IclockDeviceconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_deviceconfig");

            entity.Property(e => e.CommandRetention).HasColumnName("command_retention");
            entity.Property(e => e.DevLogRetention).HasColumnName("dev_log_retention");
            entity.Property(e => e.DevicePolicy).HasColumnName("device_policy");
            entity.Property(e => e.EditPolicy).HasColumnName("edit_policy");
            entity.Property(e => e.EnableAutoAdd).HasColumnName("enable_auto_add");
            entity.Property(e => e.EnableCardUpload).HasColumnName("enable_card_upload");
            entity.Property(e => e.EnableNameUpload).HasColumnName("enable_name_upload");
            entity.Property(e => e.EnableRegistration).HasColumnName("enable_registration");
            entity.Property(e => e.EnableResignedFilter).HasColumnName("enable_resigned_filter");
            entity.Property(e => e.ImportPolicy).HasColumnName("import_policy");
            entity.Property(e => e.MobilePolicy).HasColumnName("mobile_policy");
            entity.Property(e => e.TransactionRetention).HasColumnName("transaction_retention");
            entity.Property(e => e.UploadLogRetention).HasColumnName("upload_log_retention");
            entity.Property(e => e.Uuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<IclockErrorcommandlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_errorcommandlog");

            entity.Property(e => e.Additional)
                .HasColumnType("text")
                .HasColumnName("additional");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.Cmd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cmd");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DataOrigin)
                .HasColumnType("text")
                .HasColumnName("data_origin");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("error_code");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("error_msg");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.UploadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("upload_time");
        });

        modelBuilder.Entity<IclockPrivatemessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_privatemessage");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastSend)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_send");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Uid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<IclockPublicmessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_publicmessage");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastSend)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_send");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.Uid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("uid");
        });

        modelBuilder.Entity<IclockTerminal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminal");

            entity.Property(e => e.Alias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.Authentication).HasColumnName("authentication");
            entity.Property(e => e.CaptureStamp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("capture_stamp");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.ControllerType).HasColumnName("controller_type");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.FaceAlgVer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("face_alg_ver");
            entity.Property(e => e.FaceCapacity).HasColumnName("face_capacity");
            entity.Property(e => e.FaceCount).HasColumnName("face_count");
            entity.Property(e => e.FaceFuncOn).HasColumnName("face_func_on");
            entity.Property(e => e.FpAlgVer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fp_alg_ver");
            entity.Property(e => e.FpCapacity).HasColumnName("fp_capacity");
            entity.Property(e => e.FpCount).HasColumnName("fp_count");
            entity.Property(e => e.FpFuncOn).HasColumnName("fp_func_on");
            entity.Property(e => e.FvAlgVer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fv_alg_ver");
            entity.Property(e => e.FvCapacity).HasColumnName("fv_capacity");
            entity.Property(e => e.FvCount).HasColumnName("fv_count");
            entity.Property(e => e.FvFuncOn).HasColumnName("fv_func_on");
            entity.Property(e => e.FwVer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fw_ver");
            entity.Property(e => e.Heartbeat).HasColumnName("heartbeat");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip_address");
            entity.Property(e => e.IsAccess).HasColumnName("is_access");
            entity.Property(e => e.IsAttendance).HasColumnName("is_attendance");
            entity.Property(e => e.IsRegistration).HasColumnName("is_registration");
            entity.Property(e => e.IsTft).HasColumnName("is_tft");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.LastActivity)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_activity");
            entity.Property(e => e.LockFunc).HasColumnName("lock_func");
            entity.Property(e => e.LogStamp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("log_stamp");
            entity.Property(e => e.OemVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oem_vendor");
            entity.Property(e => e.OpLogStamp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("op_log_stamp");
            entity.Property(e => e.PalmAlgVer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("palm_alg_ver");
            entity.Property(e => e.PalmCapacity).HasColumnName("palm_capacity");
            entity.Property(e => e.PalmCount).HasColumnName("palm_count");
            entity.Property(e => e.PalmFuncOn).HasColumnName("palm_func_on");
            entity.Property(e => e.PhotoFuncOn).HasColumnName("photo_func_on");
            entity.Property(e => e.Platform)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("platform");
            entity.Property(e => e.ProductType).HasColumnName("product_type");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.PushProtocol)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("push_protocol");
            entity.Property(e => e.PushTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("push_time");
            entity.Property(e => e.PushVer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("push_ver");
            entity.Property(e => e.RealIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("real_ip");
            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Style)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("style");
            entity.Property(e => e.TerminalName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("terminal_name");
            entity.Property(e => e.TerminalTz).HasColumnName("terminal_tz");
            entity.Property(e => e.TransactionCapacity).HasColumnName("transaction_capacity");
            entity.Property(e => e.TransactionCount).HasColumnName("transaction_count");
            entity.Property(e => e.TransferInterval).HasColumnName("transfer_interval");
            entity.Property(e => e.TransferMode).HasColumnName("transfer_mode");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("transfer_time");
            entity.Property(e => e.UploadFlag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("upload_flag");
            entity.Property(e => e.UploadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("upload_time");
            entity.Property(e => e.UserCapacity).HasColumnName("user_capacity");
            entity.Property(e => e.UserCount).HasColumnName("user_count");
        });

        modelBuilder.Entity<IclockTerminalcommand>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminalcommand");

            entity.Property(e => e.CommitTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("commit_time");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReturnTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("return_time");
            entity.Property(e => e.ReturnValue).HasColumnName("return_value");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("transfer_time");
        });

        modelBuilder.Entity<IclockTerminalcommandlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminalcommandlog");

            entity.Property(e => e.CommitTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("commit_time");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Package).HasColumnName("package");
            entity.Property(e => e.ReturnTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("return_time");
            entity.Property(e => e.ReturnValue).HasColumnName("return_value");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TransferTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("transfer_time");
        });

        modelBuilder.Entity<IclockTerminalemployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminalemployee");

            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Privilege).HasColumnName("privilege");
            entity.Property(e => e.TerminalSn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminal_sn");
        });

        modelBuilder.Entity<IclockTerminallog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminallog");

            entity.Property(e => e.ActionName).HasColumnName("action_name");
            entity.Property(e => e.ActionTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("action_time");
            entity.Property(e => e.Admin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("admin");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Object)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("object");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalTz).HasColumnName("terminal_tz");
            entity.Property(e => e.UploadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("upload_time");
        });

        modelBuilder.Entity<IclockTerminalparameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminalparameter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ParamName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("param_name");
            entity.Property(e => e.ParamType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("param_type");
            entity.Property(e => e.ParamValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("param_value");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
        });

        modelBuilder.Entity<IclockTerminaluploadlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminaluploadlog");

            entity.Property(e => e.Content)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.ErrorCount).HasColumnName("error_count");
            entity.Property(e => e.Event)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("event");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.UploadCount).HasColumnName("upload_count");
            entity.Property(e => e.UploadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("upload_time");
        });

        modelBuilder.Entity<IclockTerminalworkcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_terminalworkcode");

            entity.Property(e => e.Alias)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.Code)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastActivity)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_activity");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<IclockTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_transaction");

            entity.Property(e => e.AreaAlias)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_alias");
            entity.Property(e => e.Crc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("crc");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_code");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.GpsLocation)
                .HasColumnType("text")
                .HasColumnName("gps_location");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsAttendance).HasColumnName("is_attendance");
            entity.Property(e => e.IsMask).HasColumnName("is_mask");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.PunchState)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("punch_state");
            entity.Property(e => e.PunchTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("punch_time");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Reserved)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("reserved");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.SyncStatus).HasColumnName("sync_status");
            entity.Property(e => e.SyncTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("sync_time");
            entity.Property(e => e.Temperature)
                .HasColumnType("numeric(4, 1)")
                .HasColumnName("temperature");
            entity.Property(e => e.TerminalAlias)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminal_alias");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalSn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminal_sn");
            entity.Property(e => e.UploadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("upload_time");
            entity.Property(e => e.VerifyType).HasColumnName("verify_type");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("work_code");
        });

        modelBuilder.Entity<IclockTransactionproofcmd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("iclock_transactionproofcmd");

            entity.Property(e => e.ActionTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("action_time");
            entity.Property(e => e.EndTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("end_time");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReservedChar)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("reserved_char");
            entity.Property(e => e.ReservedFloat).HasColumnName("reserved_float");
            entity.Property(e => e.ReservedInit).HasColumnName("reserved_init");
            entity.Property(e => e.ServerCount).HasColumnName("server_count");
            entity.Property(e => e.StartTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("start_time");
            entity.Property(e => e.TerminalCount).HasColumnName("terminal_count");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
        });

        modelBuilder.Entity<MobileAnnouncement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_announcement");

            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");
            entity.Property(e => e.Sender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sender");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.SystemSender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("system_sender");
        });

        modelBuilder.Entity<MobileAppactionlog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_appactionlog");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.ActionTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("action_time");
            entity.Property(e => e.Client)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("client");
            entity.Property(e => e.Describe)
                .HasColumnType("text")
                .HasColumnName("describe");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Params)
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.RemoteIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("remote_ip");
            entity.Property(e => e.RequestStatus).HasColumnName("request_status");
            entity.Property(e => e.User)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("user");
        });

        modelBuilder.Entity<MobileApplist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_applist");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.ClientCategory).HasColumnName("client_category");
            entity.Property(e => e.ClientId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("client_id");
            entity.Property(e => e.DeviceToken)
                .HasColumnType("text")
                .HasColumnName("device_token");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastActive)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_active");
            entity.Property(e => e.LoginTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("login_time");
            entity.Property(e => e.Token)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<MobileAppnotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_appnotification");

            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NotificationTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("notification_time");
            entity.Property(e => e.ReadStatus).HasColumnName("read_status");
            entity.Property(e => e.ReadTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("read_time");
            entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");
            entity.Property(e => e.Sender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sender");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            entity.Property(e => e.SystemSender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("system_sender");
        });

        modelBuilder.Entity<MobileGpsfordepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_gpsfordepartment");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.Distance).HasColumnName("distance");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<MobileGpsforemployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_gpsforemployee");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Distance).HasColumnName("distance");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<NotificationsNotification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("notifications_notification");

            entity.Property(e => e.CommitTime).HasColumnName("commit_time");
            entity.Property(e => e.Content)
                .HasMaxLength(999)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.ContentTypeId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("content_type_id");
            entity.Property(e => e.Event).HasColumnName("event");
            entity.Property(e => e.ExceptionId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("exception_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsSent).HasColumnName("is_sent");
            entity.Property(e => e.SendTime).HasColumnName("send_time");
        });

        modelBuilder.Entity<PayrollDeductionformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_deductionformula");

            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollEmploan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_emploan");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LoanAmount).HasColumnName("loan_amount");
            entity.Property(e => e.LoanCleanTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("loan_clean_time");
            entity.Property(e => e.LoanTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("loan_time");
            entity.Property(e => e.PerCycleRefund).HasColumnName("per_cycle_refund");
            entity.Property(e => e.RefundCycle).HasColumnName("refund_cycle");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PayrollEmppayrollprofile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_emppayrollprofile");

            entity.Property(e => e.AgentAccount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("agent_account");
            entity.Property(e => e.AgentId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("agent_id");
            entity.Property(e => e.BankAccount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bank_account");
            entity.Property(e => e.BankName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bank_name");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PaymentMode).HasColumnName("payment_mode");
            entity.Property(e => e.PaymentType).HasColumnName("payment_type");
            entity.Property(e => e.PersonnelId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("personnel_id");
        });

        modelBuilder.Entity<PayrollExceptionformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_exceptionformula");

            entity.Property(e => e.ExceptionType).HasColumnName("exception_type");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollExtradeduction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_extradeduction");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IssuedTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("issued_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PayrollExtraincrease>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_extraincrease");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IssuedTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("issued_time");
            entity.Property(e => e.Remark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PayrollIncreasementformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_increasementformula");

            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollLeaveformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_leaveformula");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollMonthlysalary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_monthlysalary");

            entity.Property(e => e.AbsentTime).HasColumnName("absent_time");
            entity.Property(e => e.AbsentTimeFormula)
                .HasColumnType("text")
                .HasColumnName("absent_time_formula");
            entity.Property(e => e.AbsentTimeFormulaName)
                .HasColumnType("text")
                .HasColumnName("absent_time_formula_name");
            entity.Property(e => e.AdvanceDeduction).HasColumnName("advance_deduction");
            entity.Property(e => e.AdvanceIncrease).HasColumnName("advance_increase");
            entity.Property(e => e.BasicSalary).HasColumnName("basic_salary");
            entity.Property(e => e.CalcTime).HasColumnName("calc_time");
            entity.Property(e => e.Deduction).HasColumnName("deduction");
            entity.Property(e => e.DeductionFormula)
                .HasColumnType("text")
                .HasColumnName("deduction_formula");
            entity.Property(e => e.DeductionFormulaName)
                .HasColumnType("text")
                .HasColumnName("deduction_formula_name");
            entity.Property(e => e.EarlyLeave).HasColumnName("early_leave");
            entity.Property(e => e.EarlyLeaveFormula)
                .HasColumnType("text")
                .HasColumnName("early_leave_formula");
            entity.Property(e => e.EarlyLeaveFormulaName)
                .HasColumnType("text")
                .HasColumnName("early_leave_formula_name");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.ExtraDeduction).HasColumnName("extra_deduction");
            entity.Property(e => e.ExtraIncrease).HasColumnName("extra_increase");
            entity.Property(e => e.FormatDict)
                .HasColumnType("text")
                .HasColumnName("format_dict");
            entity.Property(e => e.HolidayOt).HasColumnName("holiday_ot");
            entity.Property(e => e.HolidayOtFormula)
                .HasColumnType("text")
                .HasColumnName("holiday_ot_formula");
            entity.Property(e => e.HolidayOtFormulaName)
                .HasColumnType("text")
                .HasColumnName("holiday_ot_formula_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Increase).HasColumnName("increase");
            entity.Property(e => e.IncreaseFormula)
                .HasColumnType("text")
                .HasColumnName("increase_formula");
            entity.Property(e => e.IncreaseFormulaName)
                .HasColumnType("text")
                .HasColumnName("increase_formula_name");
            entity.Property(e => e.LateTime).HasColumnName("late_time");
            entity.Property(e => e.LateTimeFormula)
                .HasColumnType("text")
                .HasColumnName("late_time_formula");
            entity.Property(e => e.LateTimeFormulaName)
                .HasColumnType("text")
                .HasColumnName("late_time_formula_name");
            entity.Property(e => e.Leave)
                .HasColumnType("text")
                .HasColumnName("leave");
            entity.Property(e => e.LeaveFormula)
                .HasColumnType("text")
                .HasColumnName("leave_formula");
            entity.Property(e => e.LeaveFormulaName)
                .HasColumnType("text")
                .HasColumnName("leave_formula_name");
            entity.Property(e => e.LoanDeduction).HasColumnName("loan_deduction");
            entity.Property(e => e.LoanIncrease).HasColumnName("loan_increase");
            entity.Property(e => e.NormalOt).HasColumnName("normal_ot");
            entity.Property(e => e.NormalOtFormula)
                .HasColumnType("text")
                .HasColumnName("normal_ot_formula");
            entity.Property(e => e.NormalOtFormulaName)
                .HasColumnType("text")
                .HasColumnName("normal_ot_formula_name");
            entity.Property(e => e.Ot1).HasColumnName("ot1");
            entity.Property(e => e.Ot1Formula)
                .HasColumnType("text")
                .HasColumnName("ot1_formula");
            entity.Property(e => e.Ot1FormulaName)
                .HasColumnType("text")
                .HasColumnName("ot1_formula_name");
            entity.Property(e => e.Ot2).HasColumnName("ot2");
            entity.Property(e => e.Ot2Formula)
                .HasColumnType("text")
                .HasColumnName("ot2_formula");
            entity.Property(e => e.Ot2FormulaName)
                .HasColumnType("text")
                .HasColumnName("ot2_formula_name");
            entity.Property(e => e.Ot3).HasColumnName("ot3");
            entity.Property(e => e.Ot3Formula)
                .HasColumnType("text")
                .HasColumnName("ot3_formula");
            entity.Property(e => e.Ot3FormulaName)
                .HasColumnType("text")
                .HasColumnName("ot3_formula_name");
            entity.Property(e => e.RefundLoanAmount).HasColumnName("refund_loan_amount");
            entity.Property(e => e.Reimbursement).HasColumnName("reimbursement");
            entity.Property(e => e.TotalDeduction).HasColumnName("total_deduction");
            entity.Property(e => e.TotalDeductionExpression)
                .HasColumnType("text")
                .HasColumnName("total_deduction_expression");
            entity.Property(e => e.TotalDeductionFormula)
                .HasColumnType("text")
                .HasColumnName("total_deduction_formula");
            entity.Property(e => e.TotalDeductionFormulaName)
                .HasColumnType("text")
                .HasColumnName("total_deduction_formula_name");
            entity.Property(e => e.TotalIncrease).HasColumnName("total_increase");
            entity.Property(e => e.TotalIncreaseExpression)
                .HasColumnType("text")
                .HasColumnName("total_increase_expression");
            entity.Property(e => e.TotalIncreaseFormula)
                .HasColumnType("text")
                .HasColumnName("total_increase_formula");
            entity.Property(e => e.TotalIncreaseFormulaName)
                .HasColumnType("text")
                .HasColumnName("total_increase_formula_name");
            entity.Property(e => e.TotalLoanAmount).HasColumnName("total_loan_amount");
            entity.Property(e => e.TotalSalary).HasColumnName("total_salary");
            entity.Property(e => e.TotalSalaryExpression)
                .HasColumnType("text")
                .HasColumnName("total_salary_expression");
            entity.Property(e => e.UnrefundLoanAmount).HasColumnName("unrefund_loan_amount");
            entity.Property(e => e.WeekendOt).HasColumnName("weekend_ot");
            entity.Property(e => e.WeekendOtFormula)
                .HasColumnType("text")
                .HasColumnName("weekend_ot_formula");
            entity.Property(e => e.WeekendOtFormulaName)
                .HasColumnType("text")
                .HasColumnName("weekend_ot_formula_name");
        });

        modelBuilder.Entity<PayrollOvertimeformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_overtimeformula");

            entity.Property(e => e.Formula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("formula");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OvertimeLevel).HasColumnName("overtime_level");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");
        });

        modelBuilder.Entity<PayrollReimbursement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_reimbursement");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RmbAmount).HasColumnName("rmb_amount");
            entity.Property(e => e.RmbFile)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("rmb_file");
            entity.Property(e => e.RmbRemark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("rmb_remark");
            entity.Property(e => e.RmbTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("rmb_time");
        });

        modelBuilder.Entity<PayrollSalaryadvance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salaryadvance");

            entity.Property(e => e.AdvanceAmount).HasColumnName("advance_amount");
            entity.Property(e => e.AdvanceRemark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("advance_remark");
            entity.Property(e => e.AdvanceTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("advance_time");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PayrollSalarystructure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salarystructure");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SalaryAmount).HasColumnName("salary_amount");
            entity.Property(e => e.SalaryRemark)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("salary_remark");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PayrollSalarystructureDeductionformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salarystructure_deductionformula");

            entity.Property(e => e.DeductionformulaId).HasColumnName("deductionformula_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");
        });

        modelBuilder.Entity<PayrollSalarystructureExceptionformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salarystructure_exceptionformula");

            entity.Property(e => e.ExceptionformulaId).HasColumnName("exceptionformula_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");
        });

        modelBuilder.Entity<PayrollSalarystructureIncreasementformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salarystructure_increasementformula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IncreasementformulaId).HasColumnName("increasementformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");
        });

        modelBuilder.Entity<PayrollSalarystructureLeaveformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salarystructure_leaveformula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LeaveformulaId).HasColumnName("leaveformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");
        });

        modelBuilder.Entity<PayrollSalarystructureOvertimeformula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("payroll_salarystructure_overtimeformula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OvertimeformulaId).HasColumnName("overtimeformula_id");
            entity.Property(e => e.SalarystructureId).HasColumnName("salarystructure_id");
        });

        modelBuilder.Entity<PersonnelArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_area");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("area_code");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.ParentAreaId).HasColumnName("parent_area_id");
        });

        modelBuilder.Entity<PersonnelAssignareaemployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_assignareaemployee");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.AssignedTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("assigned_time");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PersonnelCertification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_certification");

            entity.Property(e => e.CertCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cert_code");
            entity.Property(e => e.CertName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cert_name");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PersonnelCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_company");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Address2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.AreaNumberGt).HasColumnName("area_number_gt");
            entity.Property(e => e.AreaNumberLt).HasColumnName("area_number_lt");
            entity.Property(e => e.City)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("company_code");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.DepartmentNumberGt).HasColumnName("department_number_gt");
            entity.Property(e => e.DepartmentNumberLt).HasColumnName("department_number_lt");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmployeeNumberGt).HasColumnName("employee_number_gt");
            entity.Property(e => e.EmployeeNumberLt).HasColumnName("employee_number_lt");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.LogPosition).HasColumnName("log_position");
            entity.Property(e => e.Logo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("logo");
            entity.Property(e => e.NamePosition).HasColumnName("name_position");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PositionNumberGt).HasColumnName("position_number_gt");
            entity.Property(e => e.PositionNumberLt).HasColumnName("position_number_lt");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.ShowInReport).HasColumnName("show_in_report");
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<PersonnelCompanyregister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_companyregister");

            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("company_address");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("company_code");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact_name");
            entity.Property(e => e.CountryName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("country_name");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DesiredLicenseVersion).HasColumnName("desired_license_version");
            entity.Property(e => e.DesiredOptionalFunctions)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("desired_optional_functions");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mobile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.SecurityCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("security_code");
            entity.Property(e => e.SendMail).HasColumnName("send_mail");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<PersonnelDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_department");

            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.ParentDeptId).HasColumnName("parent_dept_id");
        });

        modelBuilder.Entity<PersonnelEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_employee");

            entity.Property(e => e.AccGroup)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("acc_group");
            entity.Property(e => e.AccTimezone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("acc_timezone");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.AppRole).HasColumnName("app_role");
            entity.Property(e => e.AppStatus).HasColumnName("app_status");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("card_no");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.ContactTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contact_tel");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DelTag).HasColumnName("del_tag");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DepartmentId).HasColumnName("department_id");
            entity.Property(e => e.DevPrivilege).HasColumnName("dev_privilege");
            entity.Property(e => e.DevicePassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("device_password");
            entity.Property(e => e.DriverLicenseAutomobile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("driver_license_automobile");
            entity.Property(e => e.DriverLicenseMotorcycle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("driver_license_motorcycle");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmpCode).HasColumnName("emp_code");
            entity.Property(e => e.EmpType).HasColumnName("emp_type");
            entity.Property(e => e.EnableAtt).HasColumnName("enable_att");
            entity.Property(e => e.EnableHoliday).HasColumnName("enable_holiday");
            entity.Property(e => e.EnableOvertime).HasColumnName("enable_overtime");
            entity.Property(e => e.EnablePayroll).HasColumnName("enable_payroll");
            entity.Property(e => e.EnrollSn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("enroll_sn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InternalEmpNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("internal_emp_num");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.LastLogin)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Mobile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.National)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("national");
            entity.Property(e => e.NationalNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("national_num");
            entity.Property(e => e.Nickname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nickname");
            entity.Property(e => e.OfficeTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("office_tel");
            entity.Property(e => e.Passport)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("passport");
            entity.Property(e => e.PayrollNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payroll_num");
            entity.Property(e => e.Photo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("photo");
            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.Postcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("postcode");
            entity.Property(e => e.Religion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("religion");
            entity.Property(e => e.Reserved).HasColumnName("reserved");
            entity.Property(e => e.SelfPassword)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("self_password");
            entity.Property(e => e.Ssn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ssn");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
            entity.Property(e => e.VacationRule).HasColumnName("vacation_rule");
            entity.Property(e => e.VerifyMode).HasColumnName("verify_mode");
        });

        modelBuilder.Entity<PersonnelEmployeeArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_employee_area");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PersonnelEmployeeAreaPrivilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_employee_area_privilege");

            entity.Property(e => e.AreaId).HasColumnName("area_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PersonnelEmployeeFlowRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_employee_flow_role");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WorkflowroleId).HasColumnName("workflowrole_id");
        });

        modelBuilder.Entity<PersonnelEmployeecertification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_employeecertification");

            entity.Property(e => e.Before).HasColumnName("before");
            entity.Property(e => e.CertificationId).HasColumnName("certification_id");
            entity.Property(e => e.EmailAlert).HasColumnName("email_alert");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.ExpireOn).HasColumnName("expire_on");
            entity.Property(e => e.File)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("file");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<PersonnelEmployeeprofile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_employeeprofile");

            entity.Property(e => e.ColumnOrder)
                .HasColumnType("text")
                .HasColumnName("column_order");
            entity.Property(e => e.DisabledFields)
                .HasColumnType("text")
                .HasColumnName("disabled_fields");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Preferences)
                .HasColumnType("text")
                .HasColumnName("preferences");
            entity.Property(e => e.PwdUpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("pwd_update_time");
        });

        modelBuilder.Entity<PersonnelPosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_position");

            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.ParentPositionId).HasColumnName("parent_position_id");
            entity.Property(e => e.PositionCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position_code");
            entity.Property(e => e.PositionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("position_name");
        });

        modelBuilder.Entity<PersonnelResign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personnel_resign");

            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.Disableatt).HasColumnName("disableatt");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("reason");
            entity.Property(e => e.ResignDate).HasColumnName("resign_date");
            entity.Property(e => e.ResignType).HasColumnName("resign_type");
        });

        modelBuilder.Entity<StaffStafftoken>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("staff_stafftoken");

            entity.Property(e => e.Created)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("created");
            entity.Property(e => e.Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("key");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<SyncArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sync_area");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("area_code");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PostTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<SyncDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sync_department");

            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PostTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<SyncEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sync_employee");

            entity.Property(e => e.ActiveStatus).HasColumnName("active_status");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("area_code");
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area_name");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.CardNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("card_no");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dept_code");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dept_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmpCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_code");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Gender)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.JobCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job_code");
            entity.Property(e => e.JobName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("job_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MultiArea).HasColumnName("multi_area");
            entity.Property(e => e.PostTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<SyncJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sync_job");

            entity.Property(e => e.Flag).HasColumnName("flag");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.JobCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("job_code");
            entity.Property(e => e.JobName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("job_name");
            entity.Property(e => e.PostTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("post_time");
            entity.Property(e => e.SyncRet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sync_ret");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("update_time");
        });

        modelBuilder.Entity<WorkflowAbstractexception>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_abstractexception");

            entity.Property(e => e.AuditStatus).HasColumnName("audit_status");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RevokeReason)
                .HasColumnType("text")
                .HasColumnName("revoke_reason");
        });

        modelBuilder.Entity<WorkflowNodeinstance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_nodeinstance");

            entity.Property(e => e.ApplyTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("apply_time");
            entity.Property(e => e.ApproverAdminId).HasColumnName("approver_admin_id");
            entity.Property(e => e.ApproverEmployeeId).HasColumnName("approver_employee_id");
            entity.Property(e => e.DepartmentsId).HasColumnName("departments_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsLastNode).HasColumnName("is_last_node");
            entity.Property(e => e.IsNextNode).HasColumnName("is_next_node");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NodeEngineId).HasColumnName("node_engine_id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.WorkflowInstanceId).HasColumnName("workflow_instance_id");
        });

        modelBuilder.Entity<WorkflowWorkflowengine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflowengine");

            entity.Property(e => e.ApplicantPositionId).HasColumnName("applicant_position_id");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.DelFlag).HasColumnName("del_flag");
            entity.Property(e => e.DepartmentsId).HasColumnName("departments_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InformType).HasColumnName("inform_type");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WorkflowCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workflow_code");
            entity.Property(e => e.WorkflowName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workflow_name");
            entity.Property(e => e.WorkflowType).HasColumnName("workflow_type");
        });

        modelBuilder.Entity<WorkflowWorkflowengineEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflowengine_employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WorkflowengineId).HasColumnName("workflowengine_id");
        });

        modelBuilder.Entity<WorkflowWorkflowinstance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflowinstance");

            entity.Property(e => e.ContentType).HasColumnName("content_type");
            entity.Property(e => e.DelFlag).HasColumnName("del_flag");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.ExceptionId).HasColumnName("exception_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InformType).HasColumnName("inform_type");
            entity.Property(e => e.IssueDate).HasColumnName("issue_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.WorkflowCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("workflow_code");
            entity.Property(e => e.WorkflowEngineId).HasColumnName("workflow_engine_id");
            entity.Property(e => e.WorkflowName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("workflow_name");
        });

        modelBuilder.Entity<WorkflowWorkflownode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflownode");

            entity.Property(e => e.ApproverByOverall).HasColumnName("approver_by_overall");
            entity.Property(e => e.ApproverType).HasColumnName("approver_type");
            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NodeCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("node_code");
            entity.Property(e => e.NodeName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("node_name");
            entity.Property(e => e.NotifierType).HasColumnName("notifier_type");
            entity.Property(e => e.NotifyByOverall).HasColumnName("notify_by_overall");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WorkflowEngine).HasColumnName("workflow_engine");
            entity.Property(e => e.WorkflowEngineName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("workflow_engine_name");
        });

        modelBuilder.Entity<WorkflowWorkflownodeApprover>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflownode_approver");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WorkflownodeId).HasColumnName("workflownode_id");
            entity.Property(e => e.WorkflowroleId).HasColumnName("workflowrole_id");
        });

        modelBuilder.Entity<WorkflowWorkflownodeNotifier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflownode_notifier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.WorkflownodeId).HasColumnName("workflownode_id");
            entity.Property(e => e.WorkflowroleId).HasColumnName("workflowrole_id");
        });

        modelBuilder.Entity<WorkflowWorkflowrole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("workflow_workflowrole");

            entity.Property(e => e.ChangeTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("change_time");
            entity.Property(e => e.ChangeUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("change_user");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("create_time");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("create_user");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("role_code");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("role_name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

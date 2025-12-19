using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelEmployee
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public long EmpCode { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Nickname { get; set; }

    public string? Passport { get; set; }

    public string? DriverLicenseAutomobile { get; set; }

    public string? DriverLicenseMotorcycle { get; set; }

    public string? Photo { get; set; }

    public string? SelfPassword { get; set; }

    public string? DevicePassword { get; set; }

    public int? DevPrivilege { get; set; }

    public string? CardNo { get; set; }

    public string? AccGroup { get; set; }

    public string? AccTimezone { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Address { get; set; }

    public string? Postcode { get; set; }

    public string? OfficeTel { get; set; }

    public string? ContactTel { get; set; }

    public string? Mobile { get; set; }

    public string? NationalNum { get; set; }

    public string? PayrollNum { get; set; }

    public string? InternalEmpNum { get; set; }

    public string? National { get; set; }

    public string? Religion { get; set; }

    public string? Title { get; set; }

    public string? EnrollSn { get; set; }

    public string? Ssn { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateOnly? HireDate { get; set; }

    public int? VerifyMode { get; set; }

    public string? City { get; set; }

    public bool IsAdmin { get; set; }

    public int? EmpType { get; set; }

    public bool EnableAtt { get; set; }

    public bool EnablePayroll { get; set; }

    public bool EnableOvertime { get; set; }

    public bool EnableHoliday { get; set; }

    public bool Deleted { get; set; }

    public int? Reserved { get; set; }

    public int? DelTag { get; set; }

    public short? AppStatus { get; set; }

    public short? AppRole { get; set; }

    public string? Email { get; set; }

    public DateTime? LastLogin { get; set; }

    public bool IsActive { get; set; }

    public short? VacationRule { get; set; }

    public int? CompanyId { get; set; }

    public int? DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public virtual ICollection<AccAccprivilege> AccAccprivileges { get; set; } = new List<AccAccprivilege>();

    public virtual ICollection<AttAttschedule> AttAttschedules { get; set; } = new List<AttAttschedule>();

    public virtual ICollection<AttChangeschedule> AttChangeschedules { get; set; } = new List<AttChangeschedule>();

    public virtual ICollection<AttLeave> AttLeaves { get; set; } = new List<AttLeave>();

    public virtual ICollection<AttManuallog> AttManuallogs { get; set; } = new List<AttManuallog>();

    public virtual ICollection<AttOvertime> AttOvertimes { get; set; } = new List<AttOvertime>();

    public virtual ICollection<AttPayloadbase> AttPayloadbases { get; set; } = new List<AttPayloadbase>();

    public virtual ICollection<AttPayloadmulpunchset> AttPayloadmulpunchsets { get; set; } = new List<AttPayloadmulpunchset>();

    public virtual ICollection<AttPayloadpunch> AttPayloadpunches { get; set; } = new List<AttPayloadpunch>();

    public virtual ICollection<AttTempschedule> AttTempschedules { get; set; } = new List<AttTempschedule>();

    public virtual ICollection<AttTraining> AttTrainings { get; set; } = new List<AttTraining>();

    public virtual ICollection<AttVacationemployee> AttVacationemployees { get; set; } = new List<AttVacationemployee>();

    public virtual BaseDepartmentalert? BaseDepartmentalert { get; set; }

    public virtual ICollection<BasePersonalalertEmployee> BasePersonalalertEmployees { get; set; } = new List<BasePersonalalertEmployee>();

    public virtual PersonnelCompany? Company { get; set; }

    public virtual PersonnelDepartment? Department { get; set; }

    public virtual ICollection<EpEptransaction> EpEptransactions { get; set; } = new List<EpEptransaction>();

    public virtual ICollection<IclockBiodatum> IclockBiodata { get; set; } = new List<IclockBiodatum>();

    public virtual ICollection<IclockBiophoto> IclockBiophotos { get; set; } = new List<IclockBiophoto>();

    public virtual ICollection<IclockPrivatemessage> IclockPrivatemessages { get; set; } = new List<IclockPrivatemessage>();

    public virtual ICollection<IclockTransaction> IclockTransactions { get; set; } = new List<IclockTransaction>();

    public virtual ICollection<MobileAnnouncement> MobileAnnouncements { get; set; } = new List<MobileAnnouncement>();

    public virtual ICollection<MobileAppnotification> MobileAppnotifications { get; set; } = new List<MobileAppnotification>();

    public virtual ICollection<MobileGpsforemployee> MobileGpsforemployees { get; set; } = new List<MobileGpsforemployee>();

    public virtual ICollection<PayrollEmploan> PayrollEmploans { get; set; } = new List<PayrollEmploan>();

    public virtual PayrollEmppayrollprofile? PayrollEmppayrollprofile { get; set; }

    public virtual ICollection<PayrollExtradeduction> PayrollExtradeductions { get; set; } = new List<PayrollExtradeduction>();

    public virtual ICollection<PayrollExtraincrease> PayrollExtraincreases { get; set; } = new List<PayrollExtraincrease>();

    public virtual ICollection<PayrollMonthlysalary> PayrollMonthlysalaries { get; set; } = new List<PayrollMonthlysalary>();

    public virtual ICollection<PayrollReimbursement> PayrollReimbursements { get; set; } = new List<PayrollReimbursement>();

    public virtual ICollection<PayrollSalaryadvance> PayrollSalaryadvances { get; set; } = new List<PayrollSalaryadvance>();

    public virtual ICollection<PayrollSalarystructure> PayrollSalarystructures { get; set; } = new List<PayrollSalarystructure>();

    public virtual ICollection<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; set; } = new List<PersonnelAssignareaemployee>();

    public virtual ICollection<PersonnelEmployeeAreaPrivilege> PersonnelEmployeeAreaPrivileges { get; set; } = new List<PersonnelEmployeeAreaPrivilege>();

    public virtual ICollection<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; set; } = new List<PersonnelEmployeeArea>();

    public virtual ICollection<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; set; } = new List<PersonnelEmployeeFlowRole>();

    public virtual ICollection<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; set; } = new List<PersonnelEmployeecertification>();

    public virtual PersonnelEmployeeprofile? PersonnelEmployeeprofile { get; set; }

    public virtual PersonnelResign? PersonnelResign { get; set; }

    public virtual PersonnelPosition? Position { get; set; }

    public virtual StaffStafftoken? StaffStafftoken { get; set; }

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; } = new List<WorkflowNodeinstance>();

    public virtual ICollection<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; set; } = new List<WorkflowWorkflowengineEmployee>();

    public virtual ICollection<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; set; } = new List<WorkflowWorkflowinstance>();
}

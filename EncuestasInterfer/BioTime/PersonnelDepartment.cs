using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelDepartment
{
    public int Id { get; set; }

    public string DeptCode { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentDeptId { get; set; }

    public virtual ICollection<AttDepartmentschedule> AttDepartmentschedules { get; set; } = new List<AttDepartmentschedule>();

    public virtual ICollection<AttDeptattrule> AttDeptattrules { get; set; } = new List<AttDeptattrule>();

    public virtual ICollection<AttHoliday> AttHolidays { get; set; } = new List<AttHoliday>();

    public virtual ICollection<AuthUserAuthDept> AuthUserAuthDepts { get; set; } = new List<AuthUserAuthDept>();

    public virtual ICollection<BaseDepartmentalertDepartment> BaseDepartmentalertDepartments { get; set; } = new List<BaseDepartmentalertDepartment>();

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<PersonnelDepartment> InverseParentDept { get; set; } = new List<PersonnelDepartment>();

    public virtual ICollection<MobileGpsfordepartment> MobileGpsfordepartments { get; set; } = new List<MobileGpsfordepartment>();

    public virtual PersonnelDepartment? ParentDept { get; set; }

    public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; set; } = new List<PersonnelEmployee>();

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; } = new List<WorkflowNodeinstance>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; } = new List<WorkflowWorkflowengine>();
}

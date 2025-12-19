using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelCompany
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string? Logo { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? State { get; set; }

    public string? Phone { get; set; }

    public string? Website { get; set; }

    public string? PostalCode { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public bool ShowInReport { get; set; }

    public bool IsDefault { get; set; }

    public int? LogPosition { get; set; }

    public int? NamePosition { get; set; }

    public long EmployeeNumberGt { get; set; }

    public long EmployeeNumberLt { get; set; }

    public long AreaNumberGt { get; set; }

    public long AreaNumberLt { get; set; }

    public long PositionNumberGt { get; set; }

    public long PositionNumberLt { get; set; }

    public long DepartmentNumberGt { get; set; }

    public long DepartmentNumberLt { get; set; }

    public virtual ICollection<AttAttshift> AttAttshifts { get; set; } = new List<AttAttshift>();

    public virtual ICollection<AttBreaktime> AttBreaktimes { get; set; } = new List<AttBreaktime>();

    public virtual ICollection<AttDeptattrule> AttDeptattrules { get; set; } = new List<AttDeptattrule>();

    public virtual ICollection<AttTimeinterval> AttTimeintervals { get; set; } = new List<AttTimeinterval>();

    public virtual ICollection<AttVacationtime> AttVacationtimes { get; set; } = new List<AttVacationtime>();

    public virtual ICollection<AuthUser> AuthUsers { get; set; } = new List<AuthUser>();

    public virtual ICollection<IclockTerminal> IclockTerminals { get; set; } = new List<IclockTerminal>();

    public virtual ICollection<PersonnelArea> PersonnelAreas { get; set; } = new List<PersonnelArea>();

    public virtual ICollection<PersonnelCertification> PersonnelCertifications { get; set; } = new List<PersonnelCertification>();

    public virtual ICollection<PersonnelDepartment> PersonnelDepartments { get; set; } = new List<PersonnelDepartment>();

    public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; set; } = new List<PersonnelEmployee>();

    public virtual ICollection<PersonnelPosition> PersonnelPositions { get; set; } = new List<PersonnelPosition>();

    public virtual ICollection<PersonnelResign> PersonnelResigns { get; set; } = new List<PersonnelResign>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; } = new List<WorkflowWorkflowengine>();

    public virtual ICollection<WorkflowWorkflownode> WorkflowWorkflownodes { get; set; } = new List<WorkflowWorkflownode>();

    public virtual ICollection<WorkflowWorkflowrole> WorkflowWorkflowroles { get; set; } = new List<WorkflowWorkflowrole>();
}

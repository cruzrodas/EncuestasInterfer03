using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelArea
{
    public int Id { get; set; }

    public string AreaCode { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentAreaId { get; set; }

    public virtual ICollection<AccAcccombination> AccAcccombinations { get; set; } = new List<AccAcccombination>();

    public virtual ICollection<AccAccgroup> AccAccgroups { get; set; } = new List<AccAccgroup>();

    public virtual ICollection<AccAccholiday> AccAccholidays { get; set; } = new List<AccAccholiday>();

    public virtual ICollection<AccAccprivilege> AccAccprivileges { get; set; } = new List<AccAccprivilege>();

    public virtual ICollection<AccAcctimezone> AccAcctimezones { get; set; } = new List<AccAcctimezone>();

    public virtual ICollection<AuthUserAuthArea> AuthUserAuthAreas { get; set; } = new List<AuthUserAuthArea>();

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<IclockTerminal> IclockTerminals { get; set; } = new List<IclockTerminal>();

    public virtual ICollection<PersonnelArea> InverseParentArea { get; set; } = new List<PersonnelArea>();

    public virtual PersonnelArea? ParentArea { get; set; }

    public virtual ICollection<PersonnelAssignareaemployee> PersonnelAssignareaemployees { get; set; } = new List<PersonnelAssignareaemployee>();

    public virtual ICollection<PersonnelEmployeeAreaPrivilege> PersonnelEmployeeAreaPrivileges { get; set; } = new List<PersonnelEmployeeAreaPrivilege>();

    public virtual ICollection<PersonnelEmployeeArea> PersonnelEmployeeAreas { get; set; } = new List<PersonnelEmployeeArea>();
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PersonnelDepartment
{
    public int? Id { get; set; }

    public string? DeptCode { get; set; }

    public string? DeptName { get; set; }

    public bool? IsDefault { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentDeptId { get; set; }
}

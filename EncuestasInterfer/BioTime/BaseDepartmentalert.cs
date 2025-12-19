using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class BaseDepartmentalert
{
    public int PersonalalertPtrId { get; set; }

    public string DepartmentalertCode { get; set; } = null!;

    public string? Email { get; set; }

    public int? EmplistId { get; set; }

    public virtual ICollection<BaseDepartmentalertDepartment> BaseDepartmentalertDepartments { get; set; } = new List<BaseDepartmentalertDepartment>();

    public virtual PersonnelEmployee? Emplist { get; set; }

    public virtual BasePersonalalert PersonalalertPtr { get; set; } = null!;
}

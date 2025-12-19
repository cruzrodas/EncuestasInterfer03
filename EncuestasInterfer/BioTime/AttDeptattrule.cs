using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttDeptattrule
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Alias { get; set; } = null!;

    public string? Rule { get; set; }

    public int? CompanyId { get; set; }

    public int DepartmentId { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual PersonnelDepartment Department { get; set; } = null!;
}

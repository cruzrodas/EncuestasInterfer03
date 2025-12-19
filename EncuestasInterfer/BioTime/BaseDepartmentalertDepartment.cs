using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class BaseDepartmentalertDepartment
{
    public int Id { get; set; }

    public int DepartmentalertId { get; set; }

    public int DepartmentId { get; set; }

    public virtual PersonnelDepartment Department { get; set; } = null!;

    public virtual BaseDepartmentalert Departmentalert { get; set; } = null!;
}

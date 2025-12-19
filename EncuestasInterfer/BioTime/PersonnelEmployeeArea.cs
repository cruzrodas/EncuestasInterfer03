using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelEmployeeArea
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int AreaId { get; set; }

    public virtual PersonnelArea Area { get; set; } = null!;

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}

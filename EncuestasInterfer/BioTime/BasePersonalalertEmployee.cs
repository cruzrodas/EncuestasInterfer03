using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class BasePersonalalertEmployee
{
    public int Id { get; set; }

    public int PersonalalertId { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual BasePersonalalert Personalalert { get; set; } = null!;
}

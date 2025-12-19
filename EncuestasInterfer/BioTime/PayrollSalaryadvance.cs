using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollSalaryadvance
{
    public int Id { get; set; }

    public int AdvanceAmount { get; set; }

    public DateTime AdvanceTime { get; set; }

    public string? AdvanceRemark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}

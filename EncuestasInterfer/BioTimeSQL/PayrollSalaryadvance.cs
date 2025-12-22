using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollSalaryadvance
{
    public int? Id { get; set; }

    public int? AdvanceAmount { get; set; }

    public string? AdvanceTime { get; set; }

    public string? AdvanceRemark { get; set; }

    public int? EmployeeId { get; set; }
}

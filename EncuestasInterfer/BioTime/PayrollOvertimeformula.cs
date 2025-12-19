using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollOvertimeformula
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short OvertimeLevel { get; set; }

    public string Formula { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; set; } = new List<PayrollSalarystructureOvertimeformula>();
}

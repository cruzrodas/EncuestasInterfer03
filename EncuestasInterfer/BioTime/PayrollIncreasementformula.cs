using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollIncreasementformula
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Formula { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; set; } = new List<PayrollSalarystructureIncreasementformula>();
}

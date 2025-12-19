using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollExceptionformula
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short ExceptionType { get; set; }

    public string Formula { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; set; } = new List<PayrollSalarystructureExceptionformula>();
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollSalarystructureExceptionformula
{
    public int Id { get; set; }

    public int SalarystructureId { get; set; }

    public int ExceptionformulaId { get; set; }

    public virtual PayrollExceptionformula Exceptionformula { get; set; } = null!;

    public virtual PayrollSalarystructure Salarystructure { get; set; } = null!;
}

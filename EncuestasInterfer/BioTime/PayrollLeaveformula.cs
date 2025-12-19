using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollLeaveformula
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Formula { get; set; } = null!;

    public string? Remark { get; set; }

    public int CategoryId { get; set; }

    public virtual AttLeavecategory Category { get; set; } = null!;

    public virtual ICollection<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; set; } = new List<PayrollSalarystructureLeaveformula>();
}

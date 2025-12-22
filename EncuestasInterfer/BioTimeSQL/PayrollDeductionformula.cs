using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollDeductionformula
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Formula { get; set; }

    public string? Remark { get; set; }
}

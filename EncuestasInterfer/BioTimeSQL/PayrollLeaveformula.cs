using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollLeaveformula
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Formula { get; set; }

    public string? Remark { get; set; }

    public int? CategoryId { get; set; }
}

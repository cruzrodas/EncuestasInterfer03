using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollExceptionformula
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public short? ExceptionType { get; set; }

    public string? Formula { get; set; }

    public string? Remark { get; set; }
}

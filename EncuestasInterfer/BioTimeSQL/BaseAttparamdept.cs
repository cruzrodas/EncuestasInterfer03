using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseAttparamdept
{
    public int? Id { get; set; }

    public string? Rulename { get; set; }

    public int? Deptid { get; set; }

    public string? Operator { get; set; }

    public string? Optime { get; set; }
}

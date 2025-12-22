using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseSysparamdept
{
    public int? Id { get; set; }

    public string? RuleName { get; set; }

    public int? DeptId { get; set; }

    public string? Operator { get; set; }

    public string? OpTime { get; set; }
}

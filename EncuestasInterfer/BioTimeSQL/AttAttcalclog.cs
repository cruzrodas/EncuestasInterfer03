using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttAttcalclog
{
    public int? Id { get; set; }

    public int? DeptId { get; set; }

    public int? EmpId { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? UpdateTime { get; set; }

    public int? LogType { get; set; }
}

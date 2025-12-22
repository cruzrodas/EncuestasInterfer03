using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttTempschedule
{
    public int? Id { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public short? RuleFlag { get; set; }

    public short? WorkType { get; set; }

    public int? EmployeeId { get; set; }

    public int? TimeIntervalId { get; set; }
}

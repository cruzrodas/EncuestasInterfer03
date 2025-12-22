using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class DjceleryPeriodictask
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Task { get; set; }

    public string? Args { get; set; }

    public string? Kwargs { get; set; }

    public string? Queue { get; set; }

    public string? Exchange { get; set; }

    public string? RoutingKey { get; set; }

    public string? Expires { get; set; }

    public bool? Enabled { get; set; }

    public string? LastRunAt { get; set; }

    public int? TotalRunCount { get; set; }

    public string? DateChanged { get; set; }

    public string? Description { get; set; }

    public int? CrontabId { get; set; }

    public int? IntervalId { get; set; }
}

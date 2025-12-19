using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class DjceleryPeriodictask
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Task { get; set; } = null!;

    public string Args { get; set; } = null!;

    public string Kwargs { get; set; } = null!;

    public string? Queue { get; set; }

    public string? Exchange { get; set; }

    public string? RoutingKey { get; set; }

    public DateTime? Expires { get; set; }

    public bool Enabled { get; set; }

    public DateTime? LastRunAt { get; set; }

    public int TotalRunCount { get; set; }

    public DateTime DateChanged { get; set; }

    public string Description { get; set; } = null!;

    public int? CrontabId { get; set; }

    public int? IntervalId { get; set; }

    public virtual DjceleryCrontabschedule? Crontab { get; set; }

    public virtual DjceleryIntervalschedule? Interval { get; set; }
}

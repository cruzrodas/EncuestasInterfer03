using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class DjceleryTaskstate
{
    public int Id { get; set; }

    public string State { get; set; } = null!;

    public string TaskId { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime Tstamp { get; set; }

    public string? Args { get; set; }

    public string? Kwargs { get; set; }

    public DateTime? Eta { get; set; }

    public DateTime? Expires { get; set; }

    public string? Result { get; set; }

    public string? Traceback { get; set; }

    public double? Runtime { get; set; }

    public int Retries { get; set; }

    public bool Hidden { get; set; }

    public int? WorkerId { get; set; }

    public virtual DjceleryWorkerstate? Worker { get; set; }
}

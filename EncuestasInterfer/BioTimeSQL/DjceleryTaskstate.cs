using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class DjceleryTaskstate
{
    public int? Id { get; set; }

    public string? State { get; set; }

    public string? TaskId { get; set; }

    public string? Name { get; set; }

    public string? Tstamp { get; set; }

    public string? Args { get; set; }

    public string? Kwargs { get; set; }

    public string? Eta { get; set; }

    public string? Expires { get; set; }

    public string? Result { get; set; }

    public string? Traceback { get; set; }

    public double? Runtime { get; set; }

    public int? Retries { get; set; }

    public bool? Hidden { get; set; }

    public int? WorkerId { get; set; }
}

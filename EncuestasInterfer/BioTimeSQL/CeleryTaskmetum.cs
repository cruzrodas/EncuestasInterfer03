using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class CeleryTaskmetum
{
    public int? Id { get; set; }

    public string? TaskId { get; set; }

    public string? Status { get; set; }

    public string? Result { get; set; }

    public string? DateDone { get; set; }

    public string? Traceback { get; set; }

    public bool? Hidden { get; set; }

    public string? Meta { get; set; }
}

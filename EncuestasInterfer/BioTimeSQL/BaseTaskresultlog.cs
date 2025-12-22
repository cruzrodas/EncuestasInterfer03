using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseTaskresultlog
{
    public int? Id { get; set; }

    public string? Task { get; set; }

    public string? Status { get; set; }

    public string? Result { get; set; }

    public string? Time { get; set; }
}

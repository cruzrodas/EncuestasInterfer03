using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class CeleryTasksetmetum
{
    public int? Id { get; set; }

    public string? TasksetId { get; set; }

    public string? Result { get; set; }

    public string? DateDone { get; set; }

    public bool? Hidden { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class CeleryTasksetmetum
{
    public int Id { get; set; }

    public string TasksetId { get; set; } = null!;

    public string Result { get; set; } = null!;

    public DateTime DateDone { get; set; }

    public bool Hidden { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttPayloadpunch
{
    public string? Uuid { get; set; }

    public DateOnly? AttDate { get; set; }

    public string? CorrectState { get; set; }

    public int? EmpId { get; set; }

    public int? OrigId { get; set; }

    public string? SkdId { get; set; }
}

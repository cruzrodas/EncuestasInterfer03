using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttPayloadexception
{
    public string? Uuid { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? Duration { get; set; }

    public double? Days { get; set; }

    public short? DataType { get; set; }

    public string? Description { get; set; }

    public int? ItemId { get; set; }

    public string? SkdId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttHoliday
{
    public int? Id { get; set; }

    public string? Alias { get; set; }

    public DateOnly? StartDate { get; set; }

    public short? DurationDay { get; set; }

    public short? WorkType { get; set; }

    public short? OvertimeLv1 { get; set; }

    public short? OvertimeLv2 { get; set; }

    public short? OvertimeLv3 { get; set; }

    public int? DepartmentId { get; set; }
}

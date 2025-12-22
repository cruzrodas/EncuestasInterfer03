using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttPayloadmulpunchset
{
    public int? Id { get; set; }

    public DateOnly? AttDate { get; set; }

    public short? Weekday { get; set; }

    public short? DataIndex { get; set; }

    public string? ClockIn { get; set; }

    public int? InId { get; set; }

    public string? ClockOut { get; set; }

    public int? OutId { get; set; }

    public int? TotalTime { get; set; }

    public int? WorkedTime { get; set; }

    public short? DataType { get; set; }

    public int? EmpId { get; set; }

    public int? TimetableId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttAttshift
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Alias { get; set; }

    public short? CycleUnit { get; set; }

    public int? ShiftCycle { get; set; }

    public bool? WorkWeekend { get; set; }

    public short? WeekendType { get; set; }

    public bool? WorkDayOff { get; set; }

    public short? DayOffType { get; set; }

    public bool? AutoShift { get; set; }

    public int? CompanyId { get; set; }
}

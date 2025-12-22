using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttPayloadbase
{
    public string? Uuid { get; set; }

    public DateOnly? AttDate { get; set; }

    public short? Weekday { get; set; }

    public string? CheckIn { get; set; }

    public string? CheckOut { get; set; }

    public int? Duration { get; set; }

    public int? DutyDuration { get; set; }

    public double? WorkDay { get; set; }

    public string? ClockIn { get; set; }

    public string? ClockOut { get; set; }

    public int? TotalTime { get; set; }

    public int? DutyWorked { get; set; }

    public int? ActualWorked { get; set; }

    public int? Unscheduled { get; set; }

    public int? Remaining { get; set; }

    public int? TotalWorked { get; set; }

    public int? Late { get; set; }

    public int? EarlyLeave { get; set; }

    public int? Short { get; set; }

    public int? Absent { get; set; }

    public int? Leave { get; set; }

    public string? Exception { get; set; }

    public short? DayOff { get; set; }

    public string? BreakTimeId { get; set; }

    public int? EmpId { get; set; }

    public string? OvertimeId { get; set; }

    public int? TimetableId { get; set; }

    public int? TransInId { get; set; }

    public int? TransOutId { get; set; }
}

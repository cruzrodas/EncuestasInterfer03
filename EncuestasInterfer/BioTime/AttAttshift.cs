using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttAttshift
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Alias { get; set; } = null!;

    public short CycleUnit { get; set; }

    public int ShiftCycle { get; set; }

    public bool WorkWeekend { get; set; }

    public short WeekendType { get; set; }

    public bool WorkDayOff { get; set; }

    public short DayOffType { get; set; }

    public bool AutoShift { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AttAttschedule> AttAttschedules { get; set; } = new List<AttAttschedule>();

    public virtual ICollection<AttDepartmentschedule> AttDepartmentschedules { get; set; } = new List<AttDepartmentschedule>();

    public virtual ICollection<AttShiftdetail> AttShiftdetails { get; set; } = new List<AttShiftdetail>();

    public virtual PersonnelCompany? Company { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttTimeinterval
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Alias { get; set; } = null!;

    public short UseMode { get; set; }

    public TimeOnly InTime { get; set; }

    public int InAheadMargin { get; set; }

    public int InAboveMargin { get; set; }

    public int OutAheadMargin { get; set; }

    public int OutAboveMargin { get; set; }

    public int Duration { get; set; }

    public short InRequired { get; set; }

    public short OutRequired { get; set; }

    public int AllowLate { get; set; }

    public int AllowLeaveEarly { get; set; }

    public double WorkDay { get; set; }

    public short EarlyIn { get; set; }

    public int MinEarlyIn { get; set; }

    public short LateOut { get; set; }

    public int MinLateOut { get; set; }

    public short OvertimeLv { get; set; }

    public short OvertimeLv1 { get; set; }

    public short OvertimeLv2 { get; set; }

    public short OvertimeLv3 { get; set; }

    public short MultiplePunch { get; set; }

    public short AvailableIntervalType { get; set; }

    public int AvailableInterval { get; set; }

    public int WorkTimeDuration { get; set; }

    public short FuncKey { get; set; }

    public short WorkType { get; set; }

    public TimeOnly DayChange { get; set; }

    public short Use24Mode { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AttChangeschedule> AttChangeschedules { get; set; } = new List<AttChangeschedule>();

    public virtual ICollection<AttPayloadbase> AttPayloadbases { get; set; } = new List<AttPayloadbase>();

    public virtual ICollection<AttShiftdetail> AttShiftdetails { get; set; } = new List<AttShiftdetail>();

    public virtual ICollection<AttTimeintervalBreakTime> AttTimeintervalBreakTimes { get; set; } = new List<AttTimeintervalBreakTime>();

    public virtual PersonnelCompany? Company { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttBreaktime
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Alias { get; set; } = null!;

    public TimeOnly PeriodStart { get; set; }

    public int Duration { get; set; }

    public int EndMargin { get; set; }

    public short FuncKey { get; set; }

    public short AvailableIntervalType { get; set; }

    public int AvailableInterval { get; set; }

    public short MultiplePunch { get; set; }

    public short CalcType { get; set; }

    public int? MinimumDuration { get; set; }

    public short EarlyIn { get; set; }

    public int MinEarlyIn { get; set; }

    public short LateIn { get; set; }

    public int MinLateIn { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AttTimeintervalBreakTime> AttTimeintervalBreakTimes { get; set; } = new List<AttTimeintervalBreakTime>();

    public virtual PersonnelCompany? Company { get; set; }
}

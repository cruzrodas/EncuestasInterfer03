using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttBreaktime
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Alias { get; set; }

    public DateTime? PeriodStart { get; set; }

    public int? Duration { get; set; }

    public int? EndMargin { get; set; }

    public short? FuncKey { get; set; }

    public short? AvailableIntervalType { get; set; }

    public int? AvailableInterval { get; set; }

    public short? MultiplePunch { get; set; }

    public short? CalcType { get; set; }

    public int? MinimumDuration { get; set; }

    public short? EarlyIn { get; set; }

    public int? MinEarlyIn { get; set; }

    public short? LateIn { get; set; }

    public int? MinLateIn { get; set; }

    public int? CompanyId { get; set; }
}

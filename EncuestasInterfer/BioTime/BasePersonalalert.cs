using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class BasePersonalalert
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Code { get; set; } = null!;

    public int? LateExceeds { get; set; }

    public int? EarlyLeaveExceeds { get; set; }

    public int? AbsentExceeds { get; set; }

    public int? IsEnbleAlert { get; set; }

    public int? SendingFrequency { get; set; }

    public int? Day { get; set; }

    public string? Time { get; set; }

    public int? IncludeToday { get; set; }

    public int? EmailAlert { get; set; }

    public int? PopAlert { get; set; }

    public int? AlertType { get; set; }

    public DateTime? LastActivity { get; set; }

    public int? MessageType { get; set; }

    public virtual BaseDepartmentalert? BaseDepartmentalert { get; set; }

    public virtual ICollection<BasePersonalalertEmployee> BasePersonalalertEmployees { get; set; } = new List<BasePersonalalertEmployee>();
}

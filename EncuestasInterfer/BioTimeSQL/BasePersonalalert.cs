using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BasePersonalalert
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Code { get; set; }

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

    public string? LastActivity { get; set; }

    public int? MessageType { get; set; }
}

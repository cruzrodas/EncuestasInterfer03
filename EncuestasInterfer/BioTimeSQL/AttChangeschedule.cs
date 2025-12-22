using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttChangeschedule
{
    public int? AbstractexceptionPtrId { get; set; }

    public DateOnly? AttDate { get; set; }

    public string? PreviousTimeinterval { get; set; }

    public string? ApplyTime { get; set; }

    public string? ApplyReason { get; set; }

    public string? AuditReason { get; set; }

    public string? AuditTime { get; set; }

    public string? Approver { get; set; }

    public int? EmployeeId { get; set; }

    public int? TimeintervalId { get; set; }
}

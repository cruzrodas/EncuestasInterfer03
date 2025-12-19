using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttChangeschedule
{
    public int AbstractexceptionPtrId { get; set; }

    public DateOnly AttDate { get; set; }

    public string? PreviousTimeinterval { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? ApplyReason { get; set; }

    public string? AuditReason { get; set; }

    public DateTime AuditTime { get; set; }

    public string? Approver { get; set; }

    public int EmployeeId { get; set; }

    public int TimeintervalId { get; set; }

    public virtual WorkflowAbstractexception AbstractexceptionPtr { get; set; } = null!;

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual AttTimeinterval Timeinterval { get; set; } = null!;
}

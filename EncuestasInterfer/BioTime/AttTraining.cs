using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttTraining
{
    public int AbstractexceptionPtrId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string? ApplyReason { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? AuditReason { get; set; }

    public DateTime AuditTime { get; set; }

    public short? ApprovalLevel { get; set; }

    public int? AuditUserId { get; set; }

    public string? Approver { get; set; }

    public string? Attachment { get; set; }

    public int CategoryId { get; set; }

    public int EmployeeId { get; set; }

    public virtual WorkflowAbstractexception AbstractexceptionPtr { get; set; } = null!;

    public virtual AttTrainingcategory Category { get; set; } = null!;

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}

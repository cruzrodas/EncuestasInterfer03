using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttManuallog
{
    public int AbstractexceptionPtrId { get; set; }

    public DateTime PunchTime { get; set; }

    public int PunchState { get; set; }

    public string? WorkCode { get; set; }

    public decimal? Temperature { get; set; }

    public bool IsMask { get; set; }

    public string? ApplyReason { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? AuditReason { get; set; }

    public DateTime AuditTime { get; set; }

    public short? ApprovalLevel { get; set; }

    public int? AuditUserId { get; set; }

    public string? Approver { get; set; }

    public string? Attachment { get; set; }

    public int EmployeeId { get; set; }

    public virtual WorkflowAbstractexception AbstractexceptionPtr { get; set; } = null!;

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}

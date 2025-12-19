using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttLeave
{
    public int AbstractexceptionPtrId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public short Type { get; set; }

    public string? ApplyReason { get; set; }

    public DateTime ApplyTime { get; set; }

    public string? AuditReason { get; set; }

    public DateTime AuditTime { get; set; }

    public short? ApprovalLevel { get; set; }

    public int? AuditUserId { get; set; }

    public string? Approver { get; set; }

    public short VacationNumber { get; set; }

    public string? Attachment { get; set; }

    public int CategoryId { get; set; }

    public int EmployeeId { get; set; }

    public virtual WorkflowAbstractexception AbstractexceptionPtr { get; set; } = null!;

    public virtual ICollection<AttPayloadexception> AttPayloadexceptions { get; set; } = new List<AttPayloadexception>();

    public virtual ICollection<AttVacationemployee> AttVacationemployees { get; set; } = new List<AttVacationemployee>();

    public virtual AttLeavecategory Category { get; set; } = null!;

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}

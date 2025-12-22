using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttOvertime
{
    public int? AbstractexceptionPtrId { get; set; }

    public short? OvertimeType { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? ApplyReason { get; set; }

    public string? ApplyTime { get; set; }

    public string? AuditReason { get; set; }

    public string? AuditTime { get; set; }

    public short? ApprovalLevel { get; set; }

    public int? AuditUserId { get; set; }

    public string? Approver { get; set; }

    public string? Attachment { get; set; }

    public int? EmployeeId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttManuallog
{
    public int? AbstractexceptionPtrId { get; set; }

    public string? PunchTime { get; set; }

    public int? PunchState { get; set; }

    public string? WorkCode { get; set; }

    public decimal? Temperature { get; set; }

    public bool? IsMask { get; set; }

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

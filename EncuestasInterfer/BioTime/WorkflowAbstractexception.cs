using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowAbstractexception
{
    public int Id { get; set; }

    public short AuditStatus { get; set; }

    public string? RevokeReason { get; set; }

    public virtual AttChangeschedule? AttChangeschedule { get; set; }

    public virtual AttLeave? AttLeave { get; set; }

    public virtual AttManuallog? AttManuallog { get; set; }

    public virtual AttOvertime? AttOvertime { get; set; }

    public virtual AttTraining? AttTraining { get; set; }

    public virtual WorkflowWorkflowinstance? WorkflowWorkflowinstance { get; set; }
}

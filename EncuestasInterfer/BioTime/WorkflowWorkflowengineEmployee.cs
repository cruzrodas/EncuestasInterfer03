using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowWorkflowengineEmployee
{
    public int Id { get; set; }

    public int WorkflowengineId { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual WorkflowWorkflowengine Workflowengine { get; set; } = null!;
}

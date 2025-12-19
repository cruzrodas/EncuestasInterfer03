using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelEmployeeFlowRole
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int WorkflowroleId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual WorkflowWorkflowrole Workflowrole { get; set; } = null!;
}

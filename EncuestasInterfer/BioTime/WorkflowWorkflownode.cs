using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowWorkflownode
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string NodeCode { get; set; } = null!;

    public string NodeName { get; set; } = null!;

    public int OrderId { get; set; }

    public short? ApproverType { get; set; }

    public short? NotifierType { get; set; }

    public bool ApproverByOverall { get; set; }

    public bool NotifyByOverall { get; set; }

    public int WorkflowEngine { get; set; }

    public string WorkflowEngineName { get; set; } = null!;

    public int? CompanyId { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; } = new List<WorkflowNodeinstance>();

    public virtual ICollection<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; set; } = new List<WorkflowWorkflownodeApprover>();

    public virtual ICollection<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; set; } = new List<WorkflowWorkflownodeNotifier>();
}

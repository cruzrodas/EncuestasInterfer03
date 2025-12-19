using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowWorkflowrole
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string RoleCode { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public int? CompanyId { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<PersonnelEmployeeFlowRole> PersonnelEmployeeFlowRoles { get; set; } = new List<PersonnelEmployeeFlowRole>();

    public virtual ICollection<WorkflowWorkflownodeApprover> WorkflowWorkflownodeApprovers { get; set; } = new List<WorkflowWorkflownodeApprover>();

    public virtual ICollection<WorkflowWorkflownodeNotifier> WorkflowWorkflownodeNotifiers { get; set; } = new List<WorkflowWorkflownodeNotifier>();
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowNodeinstance
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public short Order { get; set; }

    public short State { get; set; }

    public bool IsLastNode { get; set; }

    public bool IsNextNode { get; set; }

    public string? Remark { get; set; }

    public DateTime? ApplyTime { get; set; }

    public int? ApproverAdminId { get; set; }

    public int? ApproverEmployeeId { get; set; }

    public int? DepartmentsId { get; set; }

    public int? NodeEngineId { get; set; }

    public int? WorkflowInstanceId { get; set; }

    public virtual AuthUser? ApproverAdmin { get; set; }

    public virtual PersonnelEmployee? ApproverEmployee { get; set; }

    public virtual PersonnelDepartment? Departments { get; set; }

    public virtual WorkflowWorkflownode? NodeEngine { get; set; }

    public virtual WorkflowWorkflowinstance? WorkflowInstance { get; set; }
}

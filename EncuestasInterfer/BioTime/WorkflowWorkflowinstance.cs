using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowWorkflowinstance
{
    public int Id { get; set; }

    public string WorkflowCode { get; set; } = null!;

    public string WorkflowName { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateOnly IssueDate { get; set; }

    public string Description { get; set; } = null!;

    public int ContentType { get; set; }

    public short InformType { get; set; }

    public bool DelFlag { get; set; }

    public int EmployeeId { get; set; }

    public int? ExceptionId { get; set; }

    public int? WorkflowEngineId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual WorkflowAbstractexception? Exception { get; set; }

    public virtual WorkflowWorkflowengine? WorkflowEngine { get; set; }

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; } = new List<WorkflowNodeinstance>();
}

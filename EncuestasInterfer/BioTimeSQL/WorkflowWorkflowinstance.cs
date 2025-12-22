using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class WorkflowWorkflowinstance
{
    public int? Id { get; set; }

    public string? WorkflowCode { get; set; }

    public string? WorkflowName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? IssueDate { get; set; }

    public string? Description { get; set; }

    public int? ContentType { get; set; }

    public short? InformType { get; set; }

    public bool? DelFlag { get; set; }

    public int? EmployeeId { get; set; }

    public int? ExceptionId { get; set; }

    public int? WorkflowEngineId { get; set; }
}

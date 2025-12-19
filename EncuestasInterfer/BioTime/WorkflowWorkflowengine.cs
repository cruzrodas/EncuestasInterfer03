using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class WorkflowWorkflowengine
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string WorkflowCode { get; set; } = null!;

    public string WorkflowName { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Description { get; set; } = null!;

    public short WorkflowType { get; set; }

    public short InformType { get; set; }

    public short? DelFlag { get; set; }

    public int? ApplicantPositionId { get; set; }

    public int? CompanyId { get; set; }

    public int? ContentTypeId { get; set; }

    public int? DepartmentsId { get; set; }

    public virtual PersonnelPosition? ApplicantPosition { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual DjangoContentType? ContentType { get; set; }

    public virtual PersonnelDepartment? Departments { get; set; }

    public virtual ICollection<WorkflowWorkflowengineEmployee> WorkflowWorkflowengineEmployees { get; set; } = new List<WorkflowWorkflowengineEmployee>();

    public virtual ICollection<WorkflowWorkflowinstance> WorkflowWorkflowinstances { get; set; } = new List<WorkflowWorkflowinstance>();
}

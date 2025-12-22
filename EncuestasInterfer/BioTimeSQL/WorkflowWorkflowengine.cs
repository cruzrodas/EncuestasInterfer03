using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class WorkflowWorkflowengine
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? WorkflowCode { get; set; }

    public string? WorkflowName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Description { get; set; }

    public short? WorkflowType { get; set; }

    public short? InformType { get; set; }

    public short? DelFlag { get; set; }

    public int? ApplicantPositionId { get; set; }

    public int? CompanyId { get; set; }

    public int? ContentTypeId { get; set; }

    public int? DepartmentsId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class WorkflowWorkflownode
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? NodeCode { get; set; }

    public string? NodeName { get; set; }

    public int? OrderId { get; set; }

    public short? ApproverType { get; set; }

    public short? NotifierType { get; set; }

    public bool? ApproverByOverall { get; set; }

    public bool? NotifyByOverall { get; set; }

    public int? WorkflowEngine { get; set; }

    public string? WorkflowEngineName { get; set; }

    public int? CompanyId { get; set; }
}

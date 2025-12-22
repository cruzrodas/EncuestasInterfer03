using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class WorkflowWorkflowrole
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? RoleCode { get; set; }

    public string? RoleName { get; set; }

    public string? Description { get; set; }

    public int? CompanyId { get; set; }
}

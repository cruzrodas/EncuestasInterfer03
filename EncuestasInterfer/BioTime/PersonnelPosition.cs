using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelPosition
{
    public int Id { get; set; }

    public string PositionCode { get; set; } = null!;

    public string PositionName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentPositionId { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<PersonnelPosition> InverseParentPosition { get; set; } = new List<PersonnelPosition>();

    public virtual PersonnelPosition? ParentPosition { get; set; }

    public virtual ICollection<PersonnelEmployee> PersonnelEmployees { get; set; } = new List<PersonnelEmployee>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; } = new List<WorkflowWorkflowengine>();
}

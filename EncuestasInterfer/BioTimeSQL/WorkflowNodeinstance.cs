using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class WorkflowNodeinstance
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public short? Order { get; set; }

    public short? State { get; set; }

    public bool? IsLastNode { get; set; }

    public bool? IsNextNode { get; set; }

    public string? Remark { get; set; }

    public string? ApplyTime { get; set; }

    public int? ApproverAdminId { get; set; }

    public int? ApproverEmployeeId { get; set; }

    public int? DepartmentsId { get; set; }

    public int? NodeEngineId { get; set; }

    public int? WorkflowInstanceId { get; set; }
}

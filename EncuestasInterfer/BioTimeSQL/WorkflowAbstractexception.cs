using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class WorkflowAbstractexception
{
    public int? Id { get; set; }

    public short? AuditStatus { get; set; }

    public string? RevokeReason { get; set; }
}

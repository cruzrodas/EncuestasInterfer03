using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class SyncDepartment
{
    public int? Id { get; set; }

    public string? PostTime { get; set; }

    public short? Flag { get; set; }

    public string? UpdateTime { get; set; }

    public string? SyncRet { get; set; }

    public string? DeptCode { get; set; }

    public string? DeptName { get; set; }
}

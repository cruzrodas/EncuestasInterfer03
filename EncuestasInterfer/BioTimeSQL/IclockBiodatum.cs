using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockBiodatum
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? BioTmp { get; set; }

    public int? BioNo { get; set; }

    public int? BioIndex { get; set; }

    public int? BioType { get; set; }

    public string? MajorVer { get; set; }

    public string? MinorVer { get; set; }

    public int? BioFormat { get; set; }

    public int? Valid { get; set; }

    public int? Duress { get; set; }

    public string? UpdateTime { get; set; }

    public string? Sn { get; set; }

    public int? EmployeeId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AccountsAdminbiodatum
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

    public bool? Valid { get; set; }

    public bool? Duress { get; set; }

    public int? AdminId { get; set; }
}

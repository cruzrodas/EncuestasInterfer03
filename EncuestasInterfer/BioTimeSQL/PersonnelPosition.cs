using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PersonnelPosition
{
    public int? Id { get; set; }

    public string? PositionCode { get; set; }

    public string? PositionName { get; set; }

    public bool? IsDefault { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentPositionId { get; set; }
}

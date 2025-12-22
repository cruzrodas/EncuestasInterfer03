using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PersonnelArea
{
    public int? Id { get; set; }

    public string? AreaCode { get; set; }

    public string? AreaName { get; set; }

    public bool? IsDefault { get; set; }

    public int? CompanyId { get; set; }

    public int? ParentAreaId { get; set; }
}

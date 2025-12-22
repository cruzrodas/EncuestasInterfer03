using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseSysparam
{
    public int? Id { get; set; }

    public string? ParaName { get; set; }

    public string? ParaType { get; set; }

    public string? ParaValue { get; set; }
}

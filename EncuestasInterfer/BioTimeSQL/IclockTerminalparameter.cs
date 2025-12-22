using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockTerminalparameter
{
    public int? Id { get; set; }

    public string? ParamType { get; set; }

    public string? ParamName { get; set; }

    public string? ParamValue { get; set; }

    public int? TerminalId { get; set; }
}

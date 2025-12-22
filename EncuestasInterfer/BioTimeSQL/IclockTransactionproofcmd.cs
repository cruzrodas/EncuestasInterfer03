using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockTransactionproofcmd
{
    public int? Id { get; set; }

    public string? ActionTime { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? TerminalCount { get; set; }

    public int? ServerCount { get; set; }

    public short? Flag { get; set; }

    public int? ReservedInit { get; set; }

    public double? ReservedFloat { get; set; }

    public string? ReservedChar { get; set; }

    public int? TerminalId { get; set; }
}

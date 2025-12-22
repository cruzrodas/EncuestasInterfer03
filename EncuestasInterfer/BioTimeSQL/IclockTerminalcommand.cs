using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockTerminalcommand
{
    public int? Id { get; set; }

    public string? Content { get; set; }

    public string? CommitTime { get; set; }

    public string? TransferTime { get; set; }

    public string? ReturnTime { get; set; }

    public int? ReturnValue { get; set; }

    public int? TerminalId { get; set; }
}

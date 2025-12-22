using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockPublicmessage
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Uid { get; set; }

    public string? StartTime { get; set; }

    public int? Duration { get; set; }

    public string? Content { get; set; }

    public string? LastSend { get; set; }

    public int? TerminalId { get; set; }
}

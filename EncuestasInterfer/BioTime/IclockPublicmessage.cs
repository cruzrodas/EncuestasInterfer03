using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class IclockPublicmessage
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string? Uid { get; set; }

    public DateTime StartTime { get; set; }

    public int Duration { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? LastSend { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}

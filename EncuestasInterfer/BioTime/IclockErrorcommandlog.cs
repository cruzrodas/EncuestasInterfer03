using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class IclockErrorcommandlog
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMsg { get; set; }

    public string? DataOrigin { get; set; }

    public string? Cmd { get; set; }

    public string? Additional { get; set; }

    public DateTime UploadTime { get; set; }

    public int TerminalId { get; set; }

    public virtual IclockTerminal Terminal { get; set; } = null!;
}

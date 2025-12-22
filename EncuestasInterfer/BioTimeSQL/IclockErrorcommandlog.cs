using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockErrorcommandlog
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMsg { get; set; }

    public string? DataOrigin { get; set; }

    public string? Cmd { get; set; }

    public string? Additional { get; set; }

    public string? UploadTime { get; set; }

    public int? TerminalId { get; set; }
}

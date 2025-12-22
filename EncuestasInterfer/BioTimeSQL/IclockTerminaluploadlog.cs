using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockTerminaluploadlog
{
    public int? Id { get; set; }

    public string? Event { get; set; }

    public string? Content { get; set; }

    public int? UploadCount { get; set; }

    public int? ErrorCount { get; set; }

    public string? UploadTime { get; set; }

    public int? TerminalId { get; set; }
}

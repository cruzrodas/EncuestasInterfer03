using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseSendemail
{
    public int? Id { get; set; }

    public int? Purpose { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? EmailBcc { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailContent { get; set; }

    public string? SendTime { get; set; }

    public short? SendStatus { get; set; }
}

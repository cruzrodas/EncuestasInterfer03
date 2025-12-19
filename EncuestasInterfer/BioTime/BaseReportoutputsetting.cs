using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class BaseReportoutputsetting
{
    public int Id { get; set; }

    public string AgreementMessageId { get; set; } = null!;

    public string ReportName { get; set; } = null!;

    public string? AgreementMessage { get; set; }
}

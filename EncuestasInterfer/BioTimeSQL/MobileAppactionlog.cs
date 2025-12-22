using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class MobileAppactionlog
{
    public int? Id { get; set; }

    public string? User { get; set; }

    public string? Client { get; set; }

    public string? Action { get; set; }

    public string? Params { get; set; }

    public string? Describe { get; set; }

    public short? RequestStatus { get; set; }

    public string? ActionTime { get; set; }

    public string? RemoteIp { get; set; }
}

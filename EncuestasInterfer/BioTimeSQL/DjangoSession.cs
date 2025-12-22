using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class DjangoSession
{
    public string? SessionKey { get; set; }

    public string? SessionData { get; set; }

    public string? ExpireDate { get; set; }
}

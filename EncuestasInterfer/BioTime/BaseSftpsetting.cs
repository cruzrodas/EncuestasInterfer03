using System;
using System.Collections.Generic;
using System.Net;

namespace EncuestasInterfer.BioTime;

public partial class BaseSftpsetting
{
    public int Id { get; set; }

    public IPAddress Host { get; set; } = null!;

    public int Port { get; set; }

    public int AuthMethod { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserPassword { get; set; }

    public string? UserKey { get; set; }

    public string? KeyPassword { get; set; }
}

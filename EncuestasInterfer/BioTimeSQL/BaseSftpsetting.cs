using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseSftpsetting
{
    public int? Id { get; set; }

    public string? Host { get; set; }

    public int? Port { get; set; }

    public int? AuthMethod { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public string? UserKey { get; set; }

    public string? KeyPassword { get; set; }
}

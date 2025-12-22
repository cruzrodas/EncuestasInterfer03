using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseSystemsetting
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }
}

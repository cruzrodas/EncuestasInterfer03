using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class MobileApplist
{
    public int? Id { get; set; }

    public string? Username { get; set; }

    public string? LoginTime { get; set; }

    public string? LastActive { get; set; }

    public string? Token { get; set; }

    public string? DeviceToken { get; set; }

    public string? ClientId { get; set; }

    public short? ClientCategory { get; set; }

    public short? Active { get; set; }

    public short? Enable { get; set; }
}

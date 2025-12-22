using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseAdminlog
{
    public int? Id { get; set; }

    public string? Action { get; set; }

    public string? Targets { get; set; }

    public string? TargetsRepr { get; set; }

    public short? ActionStatus { get; set; }

    public string? Description { get; set; }

    public string? IpAddress { get; set; }

    public bool? CanRoutable { get; set; }

    public string? OpTime { get; set; }

    public int? ContentTypeId { get; set; }

    public int? UserId { get; set; }
}

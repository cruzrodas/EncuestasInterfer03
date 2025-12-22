using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class DjangoAdminLog
{
    public int? Id { get; set; }

    public string? ActionTime { get; set; }

    public string? ObjectId { get; set; }

    public string? ObjectRepr { get; set; }

    public short? ActionFlag { get; set; }

    public string? ChangeMessage { get; set; }

    public int? ContentTypeId { get; set; }

    public int? UserId { get; set; }
}

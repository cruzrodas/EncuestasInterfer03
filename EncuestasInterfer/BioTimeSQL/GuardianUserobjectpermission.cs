using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class GuardianUserobjectpermission
{
    public int? Id { get; set; }

    public string? ObjectPk { get; set; }

    public int? ContentTypeId { get; set; }

    public int? PermissionId { get; set; }

    public int? UserId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class GuardianGroupobjectpermission
{
    public int? Id { get; set; }

    public string? ObjectPk { get; set; }

    public int? ContentTypeId { get; set; }

    public int? GroupId { get; set; }

    public int? PermissionId { get; set; }
}

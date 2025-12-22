using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AuthGroupPermission
{
    public int? Id { get; set; }

    public int? GroupId { get; set; }

    public int? PermissionId { get; set; }
}

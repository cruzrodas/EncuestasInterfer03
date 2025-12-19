using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AuthGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; } = new List<AuthGroupPermission>();

    public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; } = new List<AuthUserGroup>();

    public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; } = new List<GuardianGroupobjectpermission>();
}

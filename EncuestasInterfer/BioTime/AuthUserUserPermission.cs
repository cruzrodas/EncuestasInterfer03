using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AuthUserUserPermission
{
    public int Id { get; set; }

    public int MyuserId { get; set; }

    public int PermissionId { get; set; }

    public virtual AuthUser Myuser { get; set; } = null!;

    public virtual AuthPermission Permission { get; set; } = null!;
}

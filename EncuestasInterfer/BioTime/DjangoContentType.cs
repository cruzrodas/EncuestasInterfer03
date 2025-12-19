using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class DjangoContentType
{
    public int Id { get; set; }

    public string AppLabel { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ICollection<AuthPermission> AuthPermissions { get; set; } = new List<AuthPermission>();

    public virtual ICollection<BaseAdminlog> BaseAdminlogs { get; set; } = new List<BaseAdminlog>();

    public virtual ICollection<BaseBookmark> BaseBookmarks { get; set; } = new List<BaseBookmark>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; } = new List<DjangoAdminLog>();

    public virtual ICollection<GuardianGroupobjectpermission> GuardianGroupobjectpermissions { get; set; } = new List<GuardianGroupobjectpermission>();

    public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; } = new List<GuardianUserobjectpermission>();

    public virtual ICollection<WorkflowWorkflowengine> WorkflowWorkflowengines { get; set; } = new List<WorkflowWorkflowengine>();
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AuthUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? UpdateTime { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? EmpPin { get; set; }

    public string Email { get; set; } = null!;

    public string? TelePhone { get; set; }

    public int? AuthTimeDept { get; set; }

    public int? LoginId { get; set; }

    public int? LoginType { get; set; }

    public int? LoginCount { get; set; }

    public bool IsStaff { get; set; }

    public bool IsActive { get; set; }

    public bool IsSuperuser { get; set; }

    public bool IsPublic { get; set; }

    public bool CanManageAllDept { get; set; }

    public int? DelFlag { get; set; }

    public DateTime DateJoined { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? AuthCompanyId { get; set; }

    public bool IsTest { get; set; }

    public virtual ICollection<AccountsAdminbiodatum> AccountsAdminbiodata { get; set; } = new List<AccountsAdminbiodatum>();

    public virtual PersonnelCompany? AuthCompany { get; set; }

    public virtual ICollection<AuthUserAuthArea> AuthUserAuthAreas { get; set; } = new List<AuthUserAuthArea>();

    public virtual ICollection<AuthUserAuthDept> AuthUserAuthDepts { get; set; } = new List<AuthUserAuthDept>();

    public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; } = new List<AuthUserGroup>();

    public virtual AuthUserProfile? AuthUserProfile { get; set; }

    public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; } = new List<AuthUserUserPermission>();

    public virtual AuthtokenToken? AuthtokenToken { get; set; }

    public virtual ICollection<BaseAdminlog> BaseAdminlogs { get; set; } = new List<BaseAdminlog>();

    public virtual ICollection<BaseBookmark> BaseBookmarks { get; set; } = new List<BaseBookmark>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; } = new List<DjangoAdminLog>();

    public virtual ICollection<GuardianUserobjectpermission> GuardianUserobjectpermissions { get; set; } = new List<GuardianUserobjectpermission>();

    public virtual ICollection<WorkflowNodeinstance> WorkflowNodeinstances { get; set; } = new List<WorkflowNodeinstance>();
}

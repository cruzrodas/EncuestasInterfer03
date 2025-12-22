using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AuthUserProfile
{
    public int? Id { get; set; }

    public string? LoginName { get; set; }

    public string? PinTabs { get; set; }

    public string? DisabledFields { get; set; }

    public string? ColumnOrder { get; set; }

    public string? Preferences { get; set; }

    public string? PwdUpdateTime { get; set; }

    public int? UserId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AccountsUsersecuritypolicy
{
    public int? Id { get; set; }

    public short? Account { get; set; }

    public string? Username { get; set; }

    public DateOnly? PasswordDate { get; set; }

    public short? PasswordExpired { get; set; }

    public string? UnlockTime { get; set; }

    public string? SessionKey { get; set; }
}

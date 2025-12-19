using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelCompanyregister
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string CompanyAddress { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public short? DesiredLicenseVersion { get; set; }

    public string? DesiredOptionalFunctions { get; set; }

    public string SecurityCode { get; set; } = null!;

    public bool SendMail { get; set; }
}

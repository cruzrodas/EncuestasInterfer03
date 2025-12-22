using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PersonnelCompanyregister
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CountryName { get; set; }

    public string? ContactName { get; set; }

    public string? AreaName { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public short? DesiredLicenseVersion { get; set; }

    public string? DesiredOptionalFunctions { get; set; }

    public string? SecurityCode { get; set; }

    public bool? SendMail { get; set; }
}

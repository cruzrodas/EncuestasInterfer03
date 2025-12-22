using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PersonnelCompany
{
    public int? Id { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyCode { get; set; }

    public string? Logo { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? State { get; set; }

    public string? Phone { get; set; }

    public string? Website { get; set; }

    public string? PostalCode { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public bool? ShowInReport { get; set; }

    public bool? IsDefault { get; set; }

    public int? LogPosition { get; set; }

    public int? NamePosition { get; set; }

    public long? EmployeeNumberGt { get; set; }

    public long? EmployeeNumberLt { get; set; }

    public long? AreaNumberGt { get; set; }

    public long? AreaNumberLt { get; set; }

    public long? PositionNumberGt { get; set; }

    public long? PositionNumberLt { get; set; }

    public long? DepartmentNumberGt { get; set; }

    public long? DepartmentNumberLt { get; set; }
}

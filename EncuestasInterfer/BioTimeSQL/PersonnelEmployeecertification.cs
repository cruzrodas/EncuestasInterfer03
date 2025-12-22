using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PersonnelEmployeecertification
{
    public int? Id { get; set; }

    public DateOnly? ExpireOn { get; set; }

    public bool? EmailAlert { get; set; }

    public int? Before { get; set; }

    public string? FileName { get; set; }

    public string? File { get; set; }

    public int? CertificationId { get; set; }

    public int? EmployeeId { get; set; }
}

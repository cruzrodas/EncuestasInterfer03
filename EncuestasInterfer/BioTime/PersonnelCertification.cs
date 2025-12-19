using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PersonnelCertification
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string CertCode { get; set; } = null!;

    public string CertName { get; set; } = null!;

    public int? CompanyId { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<PersonnelEmployeecertification> PersonnelEmployeecertifications { get; set; } = new List<PersonnelEmployeecertification>();
}

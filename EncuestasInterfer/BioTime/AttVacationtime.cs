using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttVacationtime
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public int? CompanyId { get; set; }

    public virtual ICollection<AttVacationemployee> AttVacationemployees { get; set; } = new List<AttVacationemployee>();

    public virtual ICollection<AttVacationtimeseniority> AttVacationtimeseniorities { get; set; } = new List<AttVacationtimeseniority>();

    public virtual PersonnelCompany? Company { get; set; }
}

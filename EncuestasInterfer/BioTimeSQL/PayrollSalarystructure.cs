using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollSalarystructure
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public int? SalaryAmount { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public string? SalaryRemark { get; set; }

    public int? EmployeeId { get; set; }
}

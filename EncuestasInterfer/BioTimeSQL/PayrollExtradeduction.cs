using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollExtradeduction
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public int? Amount { get; set; }

    public string? IssuedTime { get; set; }

    public string? Remark { get; set; }

    public int? EmployeeId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollEmploan
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public int? LoanAmount { get; set; }

    public string? LoanTime { get; set; }

    public short? RefundCycle { get; set; }

    public double? PerCycleRefund { get; set; }

    public string? LoanCleanTime { get; set; }

    public string? Remark { get; set; }

    public int? EmployeeId { get; set; }
}

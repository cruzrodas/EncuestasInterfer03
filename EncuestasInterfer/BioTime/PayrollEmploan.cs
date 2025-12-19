using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollEmploan
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int LoanAmount { get; set; }

    public DateTime LoanTime { get; set; }

    public short RefundCycle { get; set; }

    public double PerCycleRefund { get; set; }

    public DateTime? LoanCleanTime { get; set; }

    public string? Remark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}

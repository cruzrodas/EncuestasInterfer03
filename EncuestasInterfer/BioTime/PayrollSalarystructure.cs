using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollSalarystructure
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public int SalaryAmount { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public string? SalaryRemark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }

    public virtual ICollection<PayrollSalarystructureDeductionformula> PayrollSalarystructureDeductionformulas { get; set; } = new List<PayrollSalarystructureDeductionformula>();

    public virtual ICollection<PayrollSalarystructureExceptionformula> PayrollSalarystructureExceptionformulas { get; set; } = new List<PayrollSalarystructureExceptionformula>();

    public virtual ICollection<PayrollSalarystructureIncreasementformula> PayrollSalarystructureIncreasementformulas { get; set; } = new List<PayrollSalarystructureIncreasementformula>();

    public virtual ICollection<PayrollSalarystructureLeaveformula> PayrollSalarystructureLeaveformulas { get; set; } = new List<PayrollSalarystructureLeaveformula>();

    public virtual ICollection<PayrollSalarystructureOvertimeformula> PayrollSalarystructureOvertimeformulas { get; set; } = new List<PayrollSalarystructureOvertimeformula>();
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollMonthlysalary
{
    public int Id { get; set; }

    public DateOnly? CalcTime { get; set; }

    public double? BasicSalary { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public string? FormatDict { get; set; }

    public double? Ot1 { get; set; }

    public double? Ot2 { get; set; }

    public double? Ot3 { get; set; }

    public double? NormalOt { get; set; }

    public double? WeekendOt { get; set; }

    public double? HolidayOt { get; set; }

    public double? LateTime { get; set; }

    public double? EarlyLeave { get; set; }

    public double? AbsentTime { get; set; }

    public double? Increase { get; set; }

    public double? Deduction { get; set; }

    public string? Leave { get; set; }

    public string? Ot1Formula { get; set; }

    public string? Ot2Formula { get; set; }

    public string? Ot3Formula { get; set; }

    public string? NormalOtFormula { get; set; }

    public string? WeekendOtFormula { get; set; }

    public string? HolidayOtFormula { get; set; }

    public string? LateTimeFormula { get; set; }

    public string? EarlyLeaveFormula { get; set; }

    public string? AbsentTimeFormula { get; set; }

    public string? IncreaseFormula { get; set; }

    public string? DeductionFormula { get; set; }

    public string? LeaveFormula { get; set; }

    public string? Ot1FormulaName { get; set; }

    public string? Ot2FormulaName { get; set; }

    public string? Ot3FormulaName { get; set; }

    public string? NormalOtFormulaName { get; set; }

    public string? WeekendOtFormulaName { get; set; }

    public string? HolidayOtFormulaName { get; set; }

    public string? LateTimeFormulaName { get; set; }

    public string? EarlyLeaveFormulaName { get; set; }

    public string? AbsentTimeFormulaName { get; set; }

    public string? IncreaseFormulaName { get; set; }

    public string? DeductionFormulaName { get; set; }

    public string? LeaveFormulaName { get; set; }

    public double? ExtraIncrease { get; set; }

    public double? ExtraDeduction { get; set; }

    public double? TotalLoanAmount { get; set; }

    public double? RefundLoanAmount { get; set; }

    public double? UnrefundLoanAmount { get; set; }

    public double? LoanDeduction { get; set; }

    public double? LoanIncrease { get; set; }

    public double? AdvanceIncrease { get; set; }

    public double? AdvanceDeduction { get; set; }

    public double? Reimbursement { get; set; }

    public string? TotalIncreaseFormula { get; set; }

    public string? TotalIncreaseFormulaName { get; set; }

    public string? TotalIncreaseExpression { get; set; }

    public double? TotalIncrease { get; set; }

    public string? TotalDeductionFormula { get; set; }

    public string? TotalDeductionFormulaName { get; set; }

    public string? TotalDeductionExpression { get; set; }

    public double? TotalDeduction { get; set; }

    public string? TotalSalaryExpression { get; set; }

    public double? TotalSalary { get; set; }

    public int EmployeeId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;
}

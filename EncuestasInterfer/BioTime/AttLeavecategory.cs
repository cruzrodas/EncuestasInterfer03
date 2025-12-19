using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttLeavecategory
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public double MinimumUnit { get; set; }

    public short Unit { get; set; }

    public short RoundOff { get; set; }

    public string ReportSymbol { get; set; } = null!;

    public short LeaveCategoryType { get; set; }

    public virtual ICollection<AttLeave> AttLeaves { get; set; } = new List<AttLeave>();

    public virtual ICollection<PayrollLeaveformula> PayrollLeaveformulas { get; set; } = new List<PayrollLeaveformula>();
}

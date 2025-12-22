using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttLeavecategory
{
    public int? Id { get; set; }

    public string? CategoryName { get; set; }

    public double? MinimumUnit { get; set; }

    public short? Unit { get; set; }

    public short? RoundOff { get; set; }

    public string? ReportSymbol { get; set; }

    public short? LeaveCategoryType { get; set; }
}

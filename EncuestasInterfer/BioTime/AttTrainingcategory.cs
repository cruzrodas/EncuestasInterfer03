using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttTrainingcategory
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public double MinimumUnit { get; set; }

    public short Unit { get; set; }

    public short RoundOff { get; set; }

    public string ReportSymbol { get; set; } = null!;

    public virtual ICollection<AttTraining> AttTrainings { get; set; } = new List<AttTraining>();
}

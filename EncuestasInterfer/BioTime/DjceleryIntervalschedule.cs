using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class DjceleryIntervalschedule
{
    public int Id { get; set; }

    public int Every { get; set; }

    public string Period { get; set; } = null!;

    public virtual ICollection<DjceleryPeriodictask> DjceleryPeriodictasks { get; set; } = new List<DjceleryPeriodictask>();
}

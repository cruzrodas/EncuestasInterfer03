using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class DjceleryCrontabschedule
{
    public int Id { get; set; }

    public string Minute { get; set; } = null!;

    public string Hour { get; set; } = null!;

    public string DayOfWeek { get; set; } = null!;

    public string DayOfMonth { get; set; } = null!;

    public string MonthOfYear { get; set; } = null!;

    public virtual ICollection<DjceleryPeriodictask> DjceleryPeriodictasks { get; set; } = new List<DjceleryPeriodictask>();
}

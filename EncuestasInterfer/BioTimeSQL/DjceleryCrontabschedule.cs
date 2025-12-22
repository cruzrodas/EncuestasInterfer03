using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class DjceleryCrontabschedule
{
    public int? Id { get; set; }

    public string? Minute { get; set; }

    public string? Hour { get; set; }

    public string? DayOfWeek { get; set; }

    public string? DayOfMonth { get; set; }

    public string? MonthOfYear { get; set; }
}

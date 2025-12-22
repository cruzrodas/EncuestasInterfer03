using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttShiftdetail
{
    public int? Id { get; set; }

    public DateTime? InTime { get; set; }

    public DateTime? OutTime { get; set; }

    public int? DayIndex { get; set; }

    public int? ShiftId { get; set; }

    public int? TimeIntervalId { get; set; }
}

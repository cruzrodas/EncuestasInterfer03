using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttAttschedule
{
    public int? Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShiftId { get; set; }
}

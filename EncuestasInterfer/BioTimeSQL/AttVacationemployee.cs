using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AttVacationemployee
{
    public int? Id { get; set; }

    public short? DaysLeft { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? EmployeeId { get; set; }

    public int? LeaveId { get; set; }

    public int? VacationAvailableId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttVacationemployee
{
    public int Id { get; set; }

    public short DaysLeft { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int EmployeeId { get; set; }

    public int LeaveId { get; set; }

    public int VacationAvailableId { get; set; }

    public virtual PersonnelEmployee Employee { get; set; } = null!;

    public virtual AttLeave Leave { get; set; } = null!;

    public virtual AttVacationtime VacationAvailable { get; set; } = null!;
}

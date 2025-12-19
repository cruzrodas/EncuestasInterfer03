using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttVacationtimeseniority
{
    public int Id { get; set; }

    public short Seniority { get; set; }

    public short? Days { get; set; }

    public int VacationTimeId { get; set; }

    public virtual AttVacationtime VacationTime { get; set; } = null!;
}

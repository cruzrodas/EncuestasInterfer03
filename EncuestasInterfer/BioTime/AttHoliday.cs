using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class AttHoliday
{
    public int Id { get; set; }

    public string Alias { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public short DurationDay { get; set; }

    public short WorkType { get; set; }

    public short OvertimeLv1 { get; set; }

    public short OvertimeLv2 { get; set; }

    public short OvertimeLv3 { get; set; }

    public int? DepartmentId { get; set; }

    public virtual ICollection<AccAccholiday> AccAccholidays { get; set; } = new List<AccAccholiday>();

    public virtual PersonnelDepartment? Department { get; set; }
}

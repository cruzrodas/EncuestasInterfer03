using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class MobileGpsfordepartment
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Location { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    public int Distance { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int DepartmentId { get; set; }

    public virtual PersonnelDepartment Department { get; set; } = null!;
}

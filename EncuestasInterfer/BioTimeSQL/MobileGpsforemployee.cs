using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class MobileGpsforemployee
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Location { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public int? Distance { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? EmployeeId { get; set; }
}

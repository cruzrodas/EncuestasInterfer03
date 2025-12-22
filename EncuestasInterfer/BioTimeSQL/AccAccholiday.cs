using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AccAccholiday
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? UpdateTime { get; set; }

    public int? AreaId { get; set; }

    public int? HolidayId { get; set; }

    public int? TimezoneId { get; set; }
}

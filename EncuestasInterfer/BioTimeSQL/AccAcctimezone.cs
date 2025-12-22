using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AccAcctimezone
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public int? TimezoneNo { get; set; }

    public string? TimezoneName { get; set; }

    public DateTime? SunStart { get; set; }

    public DateTime? SunEnd { get; set; }

    public short? SunOn { get; set; }

    public DateTime? MonStart { get; set; }

    public DateTime? MonEnd { get; set; }

    public short? MonOn { get; set; }

    public DateTime? TueStart { get; set; }

    public DateTime? TueEnd { get; set; }

    public short? TueOn { get; set; }

    public DateTime? WedStart { get; set; }

    public DateTime? WedEnd { get; set; }

    public short? WedOn { get; set; }

    public DateTime? ThuStart { get; set; }

    public DateTime? ThuEnd { get; set; }

    public short? ThuOn { get; set; }

    public DateTime? FriStart { get; set; }

    public DateTime? FriEnd { get; set; }

    public short? FriOn { get; set; }

    public DateTime? SatStart { get; set; }

    public DateTime? SatEnd { get; set; }

    public short? SatOn { get; set; }

    public string? Remark { get; set; }

    public string? UpdateTime { get; set; }

    public int? AreaId { get; set; }
}

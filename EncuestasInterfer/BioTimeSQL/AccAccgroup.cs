using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class AccAccgroup
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public int? GroupNo { get; set; }

    public string? GroupName { get; set; }

    public int? VerifyMode { get; set; }

    public int? Timezone1 { get; set; }

    public int? Timezone2 { get; set; }

    public int? Timezone3 { get; set; }

    public short? IsIncludeHoliday { get; set; }

    public string? UpdateTime { get; set; }

    public int? AreaId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class EpEptransaction
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Area { get; set; }

    public string? CheckDatetime { get; set; }

    public DateOnly? CheckDate { get; set; }

    public DateTime? CheckTime { get; set; }

    public decimal? Temperature { get; set; }

    public bool? IsMask { get; set; }

    public string? UploadTime { get; set; }

    public short? Source { get; set; }

    public int? EmpId { get; set; }

    public int? TerminalId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class EpEpsetup
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public bool TempAlarm { get; set; }

    public decimal TempWarning { get; set; }

    public short TempUnit { get; set; }

    public bool MaskAlarm { get; set; }
}

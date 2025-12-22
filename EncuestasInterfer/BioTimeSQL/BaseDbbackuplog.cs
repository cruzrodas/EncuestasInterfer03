using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseDbbackuplog
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? DbType { get; set; }

    public string? DbName { get; set; }

    public string? Operator { get; set; }

    public string? BackupFile { get; set; }

    public string? BackupTime { get; set; }

    public short? BackupStatus { get; set; }

    public string? Remark { get; set; }
}

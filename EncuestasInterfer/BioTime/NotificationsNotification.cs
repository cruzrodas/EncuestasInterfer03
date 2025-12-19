using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class NotificationsNotification
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public bool IsSent { get; set; }

    public short? Event { get; set; }

    public DateOnly CommitTime { get; set; }

    public DateOnly? SendTime { get; set; }

    public string? ExceptionId { get; set; }

    public string? ContentTypeId { get; set; }
}

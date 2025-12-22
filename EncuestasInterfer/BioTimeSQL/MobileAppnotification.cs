using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class MobileAppnotification
{
    public int? Id { get; set; }

    public string? Sender { get; set; }

    public string? SystemSender { get; set; }

    public short? Category { get; set; }

    public int? SubCategory { get; set; }

    public string? Content { get; set; }

    public int? Source { get; set; }

    public string? NotificationTime { get; set; }

    public short? ReadStatus { get; set; }

    public string? ReadTime { get; set; }

    public int? ReceiverId { get; set; }
}

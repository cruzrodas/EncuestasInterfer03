using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class MobileAnnouncement
{
    public int? Id { get; set; }

    public string? Subject { get; set; }

    public string? Content { get; set; }

    public short? Category { get; set; }

    public string? Sender { get; set; }

    public string? SystemSender { get; set; }

    public string? CreateTime { get; set; }

    public int? ReceiverId { get; set; }
}

using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class MobileAnnouncement
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public string Content { get; set; } = null!;

    public short Category { get; set; }

    public string? Sender { get; set; }

    public string? SystemSender { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? ReceiverId { get; set; }

    public virtual PersonnelEmployee? Receiver { get; set; }
}
